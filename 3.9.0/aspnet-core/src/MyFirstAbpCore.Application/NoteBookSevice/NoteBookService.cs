using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.UI;
using AutoMapper;
using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using MyFirstAbpCore.Entities;
using MyFirstAbpCore.NoteBookSevice.DTO;

namespace MyFirstAbpCore.NoteBookSevice
{
    public class NoteBookService : INoteBookService
    { 
        private readonly IRepository<NoteBook, Int32> _notebookRepository;

        public NoteBookService(IRepository<NoteBook, Int32> notebookRepository)
        {
            _notebookRepository = notebookRepository;
        }

        public void CreateNoteBook(NoteBookListInput input)
        {
            var notebook = _notebookRepository.FirstOrDefault(p => p.Version == input.Version);
            if (notebook != null)
            {
                throw new UserFriendlyException("xxxx");

            }

            notebook = new NoteBook { Version = input.Version, Brand = input.Brand, Size = input.Size, Vender = input.Vender };
            _notebookRepository.Insert(notebook);
        }

        public   void  DeleteNOteBook(NoteBookListInput input)
        {
           
        }

        //当你调用仓储中的GetAll()方法时，它将返回一个IQueryable。数据库连接应会在调用仓储方法后打开。这是因为IQueryable和LINQ的延迟执行。当你调用类似ToList()方法时，数据库查询才会真正的开始执行
        public NoteBookDto GetAll(NoteBookListInput input)
        {
            //获取实体
            var query = _notebookRepository.GetAllList(t => t.Vender.Contains(input.Vender));
            //转换成DTO
            var notebookList = query.Select(n => new NoteBookDto()
            {
                Version = n.Version,
                Brand = n.Brand,
                Weight = n.Weight,
                Size = n.Size,
                Vender = n.Vender,
                Code = n.Code,
                CpuPara = n.CpuPara,
                StorageSize = n.StorageSize

            }).ToList();
            return new NoteBookDto { NoteBooks = Mapper.Map<List<NoteBookDto>>(notebookList) };
        }

        public async Task<List<NoteBookDto>> SerachAllNoteBook(NoteBookListInput input)
        {
            var query = await _notebookRepository.GetAllListAsync();
            var notebookList = query.ToList();
            return new List<NoteBookDto>(AutoMapper.Mapper.Map<List<NoteBookDto>>(notebookList));
        }

        public void UpdateNoteBook(NoteBookListInput input)
        {
            throw new NotImplementedException();
        }
    }
}

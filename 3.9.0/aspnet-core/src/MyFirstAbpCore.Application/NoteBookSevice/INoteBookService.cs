using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstAbpCore.NoteBookSevice.DTO;

namespace MyFirstAbpCore.NoteBookSevice
{
    //在ABP中，使用AutoMapper对Dto与实体层最为自动对应

    //1.建立一个应用层接口文件例如IUserService

    //2.在接口文件中IUserService建立方法，例如GetAll方法

    //3.建立接口层中方法的输入对象，和输出对象（Dtos）

    //4.新建服务实现文件UserService

    //5.使用仓储Repository实现对数据库的业务逻辑操作。

    //6.在展现层调用服务方法
    public  interface INoteBookService:IApplicationService //继承接口
    {
        NoteBookDto GetAll(NoteBookListInput input);
        Task<List<NoteBookDto>> SerachAllNoteBook(NoteBookListInput input);
        void CreateNoteBook(NoteBookListInput input);
        void UpdateNoteBook(NoteBookListInput input);
        void DeleteNOteBook(NoteBookListInput input);
    }
}

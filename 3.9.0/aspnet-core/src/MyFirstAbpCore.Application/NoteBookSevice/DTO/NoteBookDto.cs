using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using MyFirstAbpCore.Entities;

namespace MyFirstAbpCore.NoteBookSevice.DTO
{
    //output,DTO与Entity如何转换，ABP通过AutoMapper来进行自动转换。
    [AutoMapFrom(typeof(NoteBook))]
    public class NoteBookDto:EntityDto
    {
    
        public long Weight { get; set; }
        public string Size { get; set; }

        public string Vender { get; set; }
        public string Brand { get; set; }
        public string Code { get; set; }//出产编号
        public string CpuPara { get; set; }
        public int StorageSize { get; set; }

        public string Version { get; set; }//型号

        public List<NoteBookDto> NoteBooks { get; set; }
    }
}

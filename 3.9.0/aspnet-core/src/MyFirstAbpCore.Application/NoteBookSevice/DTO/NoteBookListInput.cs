using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using MyFirstAbpCore.Entities;

namespace MyFirstAbpCore.NoteBookSevice.DTO
{
    //input
    [AutoMapTo(typeof(NoteBook))]
    public class NoteBookListInput
    {
            
        public string Size { get; set; }

        public string Vender { get; set; }
        public string Brand { get; set; }
        public string Version { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace MyFirstAbpCore.Entities
{
    [Table("Tb_NoteBook")]
    public class NoteBook : Entity
    {
        public string Code { get; set; }//出产编号
        public long Weight { get; set; }
        public string Size { get; set; }

        public string Vender { get; set; }
        public string Brand { get; set; }//品牌
        public string Version { get; set; }//型号
        public string CpuPara { get; set; }
       public int StorageSize { get; set; }
        

    }
}

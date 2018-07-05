using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace MyFirstAbpCore.People
{
   public class Person:Entity
    {
        public virtual string Name { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Password { get; set; }
    }
}

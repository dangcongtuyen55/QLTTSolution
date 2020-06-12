using QLTT.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }

        public List<StudentInClass> StudentInClass { get; set; }
    }
}

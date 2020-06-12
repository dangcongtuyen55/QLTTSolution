using Microsoft.Office.Interop.Excel;
using QLTT.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class Student
    {
      public int ID { get; set; }
        public string FullName { get; set; }
        public string Khoa { get; set; }
        public int ID_class { get; set; }
        public int Accumulated_Points{ get; set; }
        public Status Status_1{ get; set; }
        public Status Status_2 { get; set; }

        public List<StudentInClass> StudentInClass { get; set; }

        

    }
}

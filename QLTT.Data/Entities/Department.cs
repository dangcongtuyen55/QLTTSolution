using Microsoft.Office.Interop.Excel;
using QLTT.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}

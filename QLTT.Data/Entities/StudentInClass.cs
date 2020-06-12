using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class StudentInClass
    {

        public int StudentId { get; set; }
        
        public Student Student { get; set; }

        public int ClassId { get; set; }

        public ClassRoom ClassRoom { get; set; }

    }
}

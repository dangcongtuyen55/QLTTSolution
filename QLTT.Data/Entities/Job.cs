using QLTT.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public int Id_Comapany { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

       public List<DescriptionJob> DescriptionJobs { get; set; }
        

    }
}

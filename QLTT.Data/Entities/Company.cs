using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class Company
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Adress { set; get; }
        public string Description { set; get; }
        public string Url { set; get; }
        public string Status { set; get; }

        public List<DescriptionJob> DescriptionJobs { get; set; }



    }
}

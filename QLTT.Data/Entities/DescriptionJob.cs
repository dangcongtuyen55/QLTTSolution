using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Entities
{
    public class DescriptionJob
    {
        public int Job_Id { get; set; }

        public Job Job { get; set; }

        public int Company_id { get; set; }

        public Company Company { get; set; }
    }
}

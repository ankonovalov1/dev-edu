using System;
using System.Collections.Generic;
using System.Text;

namespace DevEdu.Data.Models
{
    public class ThemeDetails
    { 
        public int? Id { get; set; }
        public int ProgramDetailId { get; }
        public string Topic { get; set; }
    }
}

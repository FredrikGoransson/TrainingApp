using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingApp.Models
{
    public class TrainingProgram
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeOfProgram { get; set; }
        public int CycleLengthInWeeks { get; set; }
    }
}
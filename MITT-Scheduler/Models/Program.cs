using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MITT_Scheduler.Models
{
    public class Program
    {
        public int? ProgramId { get;}
        public string ProgramName { get;}

        public Program(int? id, string programName)
        {
            ProgramId = id;
            ProgramName = programName;
        }
    }
}
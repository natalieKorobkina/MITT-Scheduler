using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MITT_Scheduler.Models
{
    public class UpdateHolidaysViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
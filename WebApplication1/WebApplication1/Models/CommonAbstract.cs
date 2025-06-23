using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public abstract class CommonAbstract 
	{
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime MotifiledDate { get; set; }
        public string Motifiledby { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EF
{
	[Table("tb_Adv")]
	public class Adv : CommonAbstract
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
        public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public string Link { get; set; }
		public int Type { get; set; }
		

	}
}
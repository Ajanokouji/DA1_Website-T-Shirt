using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EF
{
	[Table("tb_Subscribe")]
	public class Subscribe
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
        [Required(ErrorMessage = "Tên không được trống")]
        public string Name { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
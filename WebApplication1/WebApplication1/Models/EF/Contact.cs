using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EF
{
	[Table("tb_Contact")]
	public class Contact : CommonAbstract
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required(ErrorMessage ="Tên không được trống")]
		public string Name { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		public string Website { get; set; }
		public string Message { get; set; }
		public string IsRead { get; set; }
	}
}
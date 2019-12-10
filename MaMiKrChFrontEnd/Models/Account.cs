using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrChFrontEnd.Models
{
	public class Account
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[Display(Name = "First name")]
		[StringLength(15, MinimumLength = 2)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
		public string FirstName { get; set; }
		
		[Required]
		[Display(Name = "Last name")]
		[StringLength(15, MinimumLength = 2)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
		public string LastName { get; set; }

		[Display(Name = "Fødselsdag")]
		[Required]
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }

		[DataType(DataType.EmailAddress)]
		[Required]
		public string Email { get; set; }
		
		[Display(Name="Adresse")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
		public string Address { get; set; }

		[Required]
		[Range(4,4)]
		[Display(Name="Post nr.")]
		public int PostNumber { get; set; }

		[Display(Name="By")]
		[StringLength(15, MinimumLength = 1)]
		public string City { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		[Display(Name="Telefon nr.")]
		public int TelfonNumber { get; set; }


	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain {
	public class User : BaseDeletable {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		//[DataType(DataType.EmailAddress, ErrorMessage = "Incorrect email format!")]
		public string Email { get; set; }
		public string Password { get; set; }

		public ICollection<User> Friend { get; set; }
		//public virtual ICollection<Friend> Friends { get; set; }
	}
}

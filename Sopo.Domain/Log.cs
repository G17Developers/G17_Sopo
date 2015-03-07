using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Sopo.Domain {
	public class Log : BaseRecord {
		[Required]
		public DateTime Date { get; set; }

		[Required]
		public string Text { get; set; }
	}
}

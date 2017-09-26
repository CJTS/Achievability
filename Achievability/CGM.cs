using System;
using System.Collections.Generic;
using System.Text;

namespace Achievability
{
	public class CGM
    {
		public List<Goal> Goals { get; set; }

		public CGM(List<Goal> goals) {
			Goals = goals;
		}

		public Goal getRoot() {
			return Goals[0];
		}
	}
}

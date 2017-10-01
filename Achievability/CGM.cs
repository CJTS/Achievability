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

		/// <summary>
        /// Get the root goal of the cgm tree
        /// </summary>
        /// <returns>Goal node</returns>
        public Goal GetRoot() {
			return Goals[0];
		}
	}
}

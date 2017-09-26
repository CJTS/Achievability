using System;
using System.Collections.Generic;
using System.Text;

namespace Achievability
{
	public class Plan
	{
		public List<Goal> GoalSequence { get; set; }

		public Plan(Goal root) {
			GoalSequence = new List<Goal>();
			GoalSequence.Add(root);
		}

		public Plan(Plan p1, Plan p2) {
			GoalSequence = new List<Goal>();
			GoalSequence.AddRange(p1.GoalSequence);
			if(p2 != null) {
				GoalSequence.AddRange(p2.GoalSequence);
			}
		}
	}
}

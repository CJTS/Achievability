using System.Collections.Generic;
using static Achievability.Enums;

namespace Achievability
{
	public class Goal {
		public string Name { get; set; }
		public GoalTypes Type { get; set; }
		public DecompositionTypes Decomposition { get; set; }
		public List<Goal> GoalConstraints { get; set; }
		public List<WorldContext> ContextConstraints { get; set; }

		public Goal(string name, GoalTypes type, DecompositionTypes decomposition, List<Goal> goalConstraints, List<WorldContext> contextConstraints) {
			Name = name;
			Type = type;
			Decomposition = decomposition;
			GoalConstraints = goalConstraints;
			ContextConstraints = contextConstraints;
		}

		public bool isApplicable(Context currentPersona) {
			var orValue = false;
			var useOr = false;
			foreach (var contextConstraint in ContextConstraints) {
				if (contextConstraint.Type == currentPersona.Type) {
					if (contextConstraint.isOrDecomposition()) {
						useOr = true;
						orValue |= contextConstraint.satisfies(currentPersona) == contextConstraint.Happen;
					} else if (contextConstraint.isAndDecomposition()) {
						if (contextConstraint.satisfies(currentPersona) != contextConstraint.Happen) {
							return false;
						}
					}
				}
			}

			return useOr ? orValue : true;
		}

		public GoalTypes myType() {
			return Type;
		}

		public List<Goal> getRefinements() {
			return GoalConstraints;
		}

		public bool isOrDecomposition() {
			return Decomposition == DecompositionTypes.OR;
		}

		public bool isAndDecomposition() {
			return Decomposition == DecompositionTypes.AND;
		}

		public Plan isAchievable(CGM cgm, Context currentPersona) {
			Goal root = this;

			if (!root.isApplicable(currentPersona)) {
				return null;
			}
			
			if(root.myType() == GoalTypes.TASK) {
				return new Plan(root);
			}

			Plan complete = null;
			var deps = root.getRefinements();
			foreach (var d in deps) {
				Plan p = d.isAchievable(cgm, currentPersona);
				if (p != null) {
					if (root.isOrDecomposition()) {
						return p;
					}
					if (root.isAndDecomposition()) {
						complete = addPlanToPlan(p, complete);
					}
				} else if (root.isAndDecomposition()) {
					if(root == cgm.getRoot()) {
						return new Plan(d);
					}
					return null;
				}
			}
			return complete;
		}

		static public Plan addPlanToPlan(Plan p, Plan complete) {
			return new Plan(p, complete);
		}
	}
}

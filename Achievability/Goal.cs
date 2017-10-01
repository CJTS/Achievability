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

        /// <summary>
        /// Verifies if the current goal or task is valid given a persona context.
        /// </summary>
        /// <param name="currentPersona"></param>
        /// <returns>True or false</returns>
        public bool IsApplicable(Context currentPersona) {
			var orValue = false;
			var useOr = false;
			foreach (var contextConstraint in ContextConstraints) {
				if (contextConstraint.Type == currentPersona.Type) {
					if (contextConstraint.IsOrDecomposition()) {
						useOr = true;
						orValue |= contextConstraint.Satisfies(currentPersona) == contextConstraint.Happen;
					} else if (contextConstraint.IsAndDecomposition()) {
						if (contextConstraint.Satisfies(currentPersona) != contextConstraint.Happen) {
							return false;
						}
					}
				}
			}

			return useOr ? orValue : true;
		}

		/// <summary>
        /// Return if this node is a Goal or a task.
        /// </summary>
        /// <returns>Goal or Task</returns>
        public GoalTypes MyType() {
			return Type;
		}

		/// <summary>
        /// Gets the list of children goal nodes of the node (goals or tasks).
        /// </summary>
        /// <returns>List of goal nodes</returns>
        public List<Goal> GetRefinements() {
			return GoalConstraints;
		}

        /// <summary>
        /// Return if this node has a OR decomposition of its children.
        /// </summary>
        /// <returns>True or false</returns>
        public bool IsOrDecomposition() {
			return Decomposition == DecompositionTypes.OR;
		}


        /// <summary>
        /// Return if this node has a AND decomposition of its children.
        /// </summary>
        /// <returns>True or false</returns>
        public bool IsAndDecomposition() {
			return Decomposition == DecompositionTypes.AND;
		}

		/// <summary>
        /// Main function of the program. Discovers if a given cgm, that is, a root goal of aa tree of goal nodes (goal or tasks) 
        /// can be achievable given a set of persona contexts.
        /// </summary>
        /// <param name="cgm"></param>
        /// <param name="currentPersona"></param>
        /// <returns></returns>
        public Plan IsAchievable(CGM cgm, Context currentPersona) {
			Goal root = this;

			if (!root.IsApplicable(currentPersona)) {
				return null;
			}
			
			if(root.MyType() == GoalTypes.TASK) {
				return new Plan(root);
			}

			Plan complete = null;
			var deps = root.GetRefinements();
			foreach (var d in deps) {
				Plan p = d.IsAchievable(cgm, currentPersona);
				if (p != null) {
					if (root.IsOrDecomposition()) {
						return p;
					}
					if (root.IsAndDecomposition()) {
						complete = AddPlanToPlan(p, complete);
					}
				} else if (root.IsAndDecomposition()) {
					if(root == cgm.GetRoot()) {
						return new Plan(d);
					}
					return null;
				}
			}
			return complete;
		}

		/// <summary>
        /// Adds a plan p to a plan complete.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="complete"></param>
        /// <returns>Plan</returns>
        static public Plan AddPlanToPlan(Plan p, Plan complete) {
			return new Plan(p, complete);
		}
	}
}

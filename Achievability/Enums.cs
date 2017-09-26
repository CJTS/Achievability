using System;
using System.Collections.Generic;
using System.Text;

namespace Achievability
{
    public class Enums
	{
		public enum GoalTypes {
			GOAL,
			TASK
		}

		public enum DecompositionTypes {
			AND,
			OR
		}

		public enum FactTypes {
			HasDiabetes = 1,
			HasHBP,
			Cardiac,
			HasRheumatiod,
			ProneToFalling,
			HasOsteoporosis,
			CanWalk,
			HasAWheelChair,
			DontLikeTecnology,
			HasBadExperiencesWithTecnology,
			LivesWithHisOrHersChildrens,
			HasANurse,
			LivesInAnAsylum,
			HasAnAssistedLivingDevice,
			WalksOrRunsAsAPhysicalActivity
		}

	}
}

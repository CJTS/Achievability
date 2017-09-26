using System.Collections.Generic;
using static Achievability.Enums;

namespace Achievability {
	public class Context
	{
		public List<FactTypes> Facts { get; set; }

		public Context(List<FactTypes> facts) {
			Facts = facts;
		}
	}

	public class Fact {
		public FactTypes Type { get; set; }
		public DecompositionTypes Decomposition { get; set; }

		public Fact(FactTypes type, DecompositionTypes decomposition) {
			Type = type;
			Decomposition = decomposition;
		}

		public bool isOrDecomposition() {
			return Decomposition == DecompositionTypes.OR;
		}

		public bool isAndDecomposition() {
			return Decomposition == DecompositionTypes.AND;
		}
	}

	public class WorldContext {
		public List<Fact> Facts { get; set; }
		public bool Happen { get; set; }
		public DecompositionTypes Decomposition { get; set; }

		public bool isOrDecomposition() {
			return Decomposition == DecompositionTypes.OR;
		}

		public bool isAndDecomposition() {
			return Decomposition == DecompositionTypes.AND;
		}

		public bool satisfies(Context personaContext) {
			var orValue = false;
			foreach (var fact in Facts) {
				if (fact.isOrDecomposition()) {
					orValue |= personaContext.Facts.Contains(fact.Type);
				}
			}

			return orValue;
		}
	}

	public class HealthRiskContext : WorldContext {
		public HealthRiskContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.HasDiabetes , DecompositionTypes.OR),
				new Fact(FactTypes.HasHBP , DecompositionTypes.OR),
				new Fact(FactTypes.Cardiac , DecompositionTypes.OR),
				new Fact(FactTypes.HasRheumatiod , DecompositionTypes.OR),
				new Fact(FactTypes.ProneToFalling , DecompositionTypes.OR),
				new Fact(FactTypes.HasOsteoporosis , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class AbiltyToMoveContext : WorldContext {
		public AbiltyToMoveContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.CanWalk , DecompositionTypes.OR),
				new Fact(FactTypes.HasAWheelChair , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class TecnologyAversionContext : WorldContext {
		public TecnologyAversionContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.DontLikeTecnology , DecompositionTypes.OR),
				new Fact(FactTypes.HasBadExperiencesWithTecnology , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class HomeAssistanceContext : WorldContext {
		public HomeAssistanceContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.LivesWithHisOrHersChildrens , DecompositionTypes.OR),
				new Fact(FactTypes.HasANurse , DecompositionTypes.OR),
				new Fact(FactTypes.LivesInAnAsylum , DecompositionTypes.OR),
				new Fact(FactTypes.HasAnAssistedLivingDevice , DecompositionTypes.OR),				
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class PhysicalActivityContext : WorldContext {
		public PhysicalActivityContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.WalksOrRunsAsAPhysicalActivity , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}
}

using System.Collections.Generic;
using static Achievability.Enums;

namespace Achievability {
	public class Context {
		public List<FactTypes> Facts { get; set; }
		public PersonaType Type { get; set; }

		public Context(List<FactTypes> facts, PersonaType type) {
			Facts = facts;
			Type = type;
		}
	}

	public class Fact {
		public FactTypes Type { get; set; }
		public DecompositionTypes Decomposition { get; set; }

		public Fact(FactTypes type, DecompositionTypes decomposition) {
			Type = type;
			Decomposition = decomposition;
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
	}

	public class WorldContext {
		public List<Fact> Facts { get; set; }
		public bool Happen { get; set; }
		public DecompositionTypes Decomposition { get; set; }
		public PersonaType Type { get; set; }

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
        /// Discovers if the persona contexts satisfies the cgm context 
        /// </summary>
        /// <param name="personaContext"></param>
        /// <returns>True or false</returns>
        public bool Satisfies(Context personaContext) {
			var orValue = false;
			foreach (var fact in Facts) {
				if (fact.IsOrDecomposition()) {
					orValue |= personaContext.Facts.Contains(fact.Type);
				}
			}

			return orValue;
		}
	}

	public class PatientContext : WorldContext {
		public PatientContext() {
			Type = PersonaType.PATIENT;
		}
	}

	public class DoctorContext : WorldContext {
		public DoctorContext() {
			Type = PersonaType.DOCTOR;
		}
	}

	public class HealthRiskContext : PatientContext {
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

	public class MobilityIssue : PatientContext {
		public MobilityIssue(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.DifficultyInWalking , DecompositionTypes.OR),
				new Fact(FactTypes.HasAWheelChair , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class TecnologyAversionContext : PatientContext {
		public TecnologyAversionContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.DontLikeTecnology , DecompositionTypes.OR),
				new Fact(FactTypes.HasBadExperiencesWithTecnology , DecompositionTypes.OR),
				new Fact(FactTypes.WantsToAvoidFrustatingExperiencesWithTecnoloies , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class HomeAssistanceContext : PatientContext {
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

	public class PhysicalActivityContext : PatientContext {
		public PhysicalActivityContext(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.WalksOrRunsAsAPhysicalActivity , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class MeansOfCommunication : DoctorContext {
		public MeansOfCommunication(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.HasCellPhone , DecompositionTypes.OR),
				new Fact(FactTypes.HasInternet , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class MeansOfInformation : DoctorContext {
		public MeansOfInformation(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.HasCellPhone , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}

	public class MeansOfHelping : DoctorContext {
		public MeansOfHelping(DecompositionTypes decomposition, bool happen = true) {
			Facts = new List<Fact>() {
				new Fact(FactTypes.HasAmbulanceAccess , DecompositionTypes.OR),
			};
			Happen = happen;
			Decomposition = decomposition;
		}
	}
}

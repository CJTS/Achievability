using System;
using System.Collections.Generic;
using static Achievability.Enums;

namespace Achievability
{
    class Program
	{
        static void Main(string[] args) {
			var T1 = new Goal("T1", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>());
			var T2 = new Goal("T2", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>());
			var T3 = new Goal("T3", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>());
			var T4 = new Goal("T4", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>());
			var T5 = new Goal("T5", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());
			var T6 = new Goal("T6", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>() { new HomeAssistanceContext(DecompositionTypes.OR), new PhysicalActivityContext(DecompositionTypes.OR) });
			var T7 = new Goal("T7", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>() { new TecnologyAversionContext(DecompositionTypes.AND, false), new MeansOfCommunication(DecompositionTypes.AND) });
			var T8 = new Goal("T8", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>() { new TecnologyAversionContext(DecompositionTypes.AND, false), new MeansOfCommunication(DecompositionTypes.AND) });
			var T9 = new Goal("T9", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new TecnologyAversionContext(DecompositionTypes.OR, false), new HomeAssistanceContext(DecompositionTypes.OR), new MeansOfInformation(DecompositionTypes.AND) });
			var T10 = new Goal("T10", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new TecnologyAversionContext(DecompositionTypes.OR, false), new HomeAssistanceContext(DecompositionTypes.OR), new MeansOfInformation(DecompositionTypes.AND) });
			var T11 = new Goal("T11", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new HomeAssistanceContext(DecompositionTypes.AND), new TecnologyAversionContext(DecompositionTypes.AND, false), new MeansOfCommunication(DecompositionTypes.AND) });
			var T12 = new Goal("T12", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());
			var T13 = new Goal("T13", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());
			var T14 = new Goal("T14", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());
			var T15 = new Goal("T15", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());
			var T16 = new Goal("T16", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new AbiltyToMoveContext(DecompositionTypes.AND, false) });
			var T17 = new Goal("T17", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new AbiltyToMoveContext(DecompositionTypes.OR, false), new HomeAssistanceContext(DecompositionTypes.OR), new TecnologyAversionContext(DecompositionTypes.OR) });
			var T18 = new Goal("T18", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new AbiltyToMoveContext(DecompositionTypes.OR, false), new TecnologyAversionContext(DecompositionTypes.OR, false) });
			var T19 = new Goal("T19", GoalTypes.TASK, DecompositionTypes.OR, new List<Goal>(), new List<WorldContext>() { new AbiltyToMoveContext(DecompositionTypes.OR, false), new TecnologyAversionContext(DecompositionTypes.OR, false) });
			var T20 = new Goal("T20", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());
			var T21 = new Goal("T21", GoalTypes.TASK, DecompositionTypes.AND, new List<Goal>(), new List<WorldContext>());

			var G18 = new Goal("G18", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T20 }, new List<WorldContext>());
			var G17 = new Goal("G17", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T16, T17, T18, T19 }, new List<WorldContext>());
			var G16 = new Goal("G16", GoalTypes.GOAL, DecompositionTypes.OR, new List<Goal>() { T15 }, new List<WorldContext>() { new HomeAssistanceContext(DecompositionTypes.AND), new TecnologyAversionContext(DecompositionTypes.AND, false), new MeansOfCommunication(DecompositionTypes.AND) });
			var G15 = new Goal("G15", GoalTypes.GOAL, DecompositionTypes.OR, new List<Goal>() { T14 }, new List<WorldContext>());
			var G14 = new Goal("G14", GoalTypes.GOAL, DecompositionTypes.OR, new List<Goal>() { G17, G18 }, new List<WorldContext>());
			var G13 = new Goal("G13", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T12, T13 }, new List<WorldContext>() { new HealthRiskContext(DecompositionTypes.OR) , new PhysicalActivityContext(DecompositionTypes.OR) });
			var G12 = new Goal("G12", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T11, G16 }, new List<WorldContext>() { });
			var G11 = new Goal("G11", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T9, T10 }, new List<WorldContext>() { });
			var G10 = new Goal("G10", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T21 }, new List<WorldContext>() { new HealthRiskContext(DecompositionTypes.AND), new MeansOfHelping(DecompositionTypes.AND) });
			var G9 = new Goal("G9", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G14, G15 }, new List<WorldContext>());
			var G8 = new Goal("G8", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T7, T8 }, new List<WorldContext>());
			var G7 = new Goal("G7", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G13 }, new List<WorldContext>());
			var G6 = new Goal("G6", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G11, G12 }, new List<WorldContext>());
			var G5 = new Goal("G5", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G10 }, new List<WorldContext>());
			var G4 = new Goal("G4", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G8, G9 }, new List<WorldContext>());
			var G3 = new Goal("G3", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { T1, T2, T3, T4 }, new List<WorldContext>());
			var G2 = new Goal("G2", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G6, G7 }, new List<WorldContext>());
			var G1 = new Goal("G1", GoalTypes.GOAL, DecompositionTypes.AND, new List<Goal>() { G2, G3, G4, G5 }, new List<WorldContext>());

			CGM cgm = new CGM(new List<Goal>() { G1, G2, G3, G4, G5, G6, G7, G8, G9, G10, G11, G12, G13, G14, G15, G16, G17, G18 });

			Context mary = new Context(
				new List<FactTypes>() {
					FactTypes.HasDiabetes,
					FactTypes.ProneToFalling,
					FactTypes.HasOsteoporosis,
					FactTypes.CanWalk,
					FactTypes.HasAnAssistedLivingDevice
				},
				PersonaType.PATIENT);

			Context bruna = new Context(
				new List<FactTypes>() {
					FactTypes.HasDiabetes,
					FactTypes.CanWalk,
					FactTypes.LivesWithHisOrHersChildrens,
					FactTypes.HasAnAssistedLivingDevice,
					FactTypes.WalksOrRunsAsAPhysicalActivity
				},
				PersonaType.PATIENT);

			Context aurora = new Context(
				new List<FactTypes>() {
					FactTypes.HasDiabetes,
					FactTypes.HasHBP,
					FactTypes.Cardiac,
					FactTypes.ProneToFalling,
					FactTypes.LivesWithHisOrHersChildrens,
					FactTypes.HasAnAssistedLivingDevice,
				},
				PersonaType.PATIENT);

			Context murilo = new Context(
				new List<FactTypes>() {
					FactTypes.HasInternet,
					FactTypes.HasCellPhone,
					FactTypes.HasAmbulanceAccess
				},
				PersonaType.DOCTOR);

			var plan = cgm.getRoot().isAchievable(cgm, mary);;

			Console.WriteLine("Start. MARY");
			var watch = System.Diagnostics.Stopwatch.StartNew();
			plan = cgm.getRoot().isAchievable(cgm, bruna);
			watch.Stop();
			var elapsedMs = watch.Elapsed;
			var goalsNumber = 0;
			var tasksNumber = 0;
			if (plan != null) {
				Console.WriteLine("The main goal is achievable.");
				Console.WriteLine("The plan is:");
				foreach (var goal in plan.GoalSequence) {
					if(goal.Name.ToCharArray()[0] == 'G') {
						goalsNumber++;
					} else {
						tasksNumber++;
					}
					Console.WriteLine(goal.Name);
				}
			} else {
				Console.WriteLine("The main goal is NOT achievable.");
			}
			Console.WriteLine("Goals failed: " + (18 - goalsNumber) + ".");
			Console.WriteLine("Goals achieved: " + goalsNumber + ".");
			Console.WriteLine("Execution Time: " + elapsedMs + ".");
			Console.WriteLine("Tasks failed: " + (21 - tasksNumber) + ".");
			Console.WriteLine("Tasks achieved: " + tasksNumber + ".");
			Console.WriteLine("End.");

			Console.WriteLine("Start. BRUNA");
			watch = System.Diagnostics.Stopwatch.StartNew();
			plan = cgm.getRoot().isAchievable(cgm, bruna);
			watch.Stop();
			elapsedMs = watch.Elapsed;
			goalsNumber = 0;
			tasksNumber = 0;
			if (plan != null) {
				Console.WriteLine("The main goal is achievable.");
				Console.WriteLine("The plan is:");
				foreach (var goal in plan.GoalSequence) {
					if (goal.Name.ToCharArray()[0] == 'G') {
						goalsNumber++;
					} else {
						tasksNumber++;
					}
					Console.WriteLine(goal.Name);
				}
			} else {
				Console.WriteLine("The main goal is NOT achievable.");
			}
			Console.WriteLine("Goals failed: " + (18 - goalsNumber) + ".");
			Console.WriteLine("Goals achieved: " + goalsNumber + ".");
			Console.WriteLine("Execution Time: " + elapsedMs + ".");
			Console.WriteLine("Tasks failed: " + (21 - tasksNumber) + ".");
			Console.WriteLine("Tasks achieved: " + tasksNumber + ".");
			Console.WriteLine("End.");

			Console.WriteLine("Start AURORA.");
			watch = System.Diagnostics.Stopwatch.StartNew();
			plan = cgm.getRoot().isAchievable(cgm, aurora);
			watch.Stop();
			elapsedMs = watch.Elapsed;
			goalsNumber = 0;
			tasksNumber = 0;
			if (plan != null) {
				Console.WriteLine("The main goal is achievable.");
				Console.WriteLine("The plan is:");
				foreach (var goal in plan.GoalSequence) {
					if (goal.Name.ToCharArray()[0] == 'G') {
						goalsNumber++;
					} else {
						tasksNumber++;
					}
					Console.WriteLine(goal.Name);
				}
			} else {
				Console.WriteLine("The main goal is NOT achievable.");
			}
			Console.WriteLine("Goals failed: " + (18 - goalsNumber) + ".");
			Console.WriteLine("Goals achieved: " + goalsNumber + ".");
			Console.WriteLine("Execution Time: " + elapsedMs + ".");
			Console.WriteLine("Tasks failed: " + (21 - tasksNumber) + ".");
			Console.WriteLine("Tasks achieved: " + tasksNumber + ".");
			Console.WriteLine("End.");

			Console.WriteLine("Start MURILO.");
			watch = System.Diagnostics.Stopwatch.StartNew();
			plan = cgm.getRoot().isAchievable(cgm, murilo);
			watch.Stop();
			elapsedMs = watch.Elapsed;
			goalsNumber = 0;
			tasksNumber = 0;
			if (plan != null) {
				Console.WriteLine("The main goal is achievable.");
				Console.WriteLine("The plan is:");
				foreach (var goal in plan.GoalSequence) {
					if (goal.Name.ToCharArray()[0] == 'G') {
						goalsNumber++;
					} else {
						tasksNumber++;
					}
					Console.WriteLine(goal.Name);
				}
			} else {
				Console.WriteLine("The main goal is NOT achievable.");
			}
			Console.WriteLine("Goals failed: " + (18 - goalsNumber) + ".");
			Console.WriteLine("Goals achieved: " + goalsNumber + ".");
			Console.WriteLine("Execution Time: " + elapsedMs + ".");
			Console.WriteLine("Tasks failed: " + (21 - tasksNumber) + ".");
			Console.WriteLine("Tasks achieved: " + tasksNumber + ".");
			Console.WriteLine("End.");

			Console.WriteLine("Press any key to quit.");
			Console.ReadKey();
		}
	}
}

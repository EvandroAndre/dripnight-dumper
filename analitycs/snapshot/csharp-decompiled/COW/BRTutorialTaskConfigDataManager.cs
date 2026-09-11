using System;
using GCommon;

namespace COW;

public class BRTutorialTaskConfigDataManager : SingletonModule<BRTutorialTaskConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TutorialGoal, uint> _003C_003E9__2_0;

		public static Func<TutorialSubGoal, uint> _003C_003E9__2_1;

		internal uint _003COnInit_003Eb__2_0(TutorialGoal value)
		{
			return 0u;
		}

		internal uint _003COnInit_003Eb__2_1(TutorialSubGoal value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, TutorialGoal> m_GoalConfigs;

	private CSVAsyncDataMap<uint, TutorialSubGoal> m_SubGoalConfigs;

	public CSVAsyncDataMap<uint, TutorialGoal> GoalConfigs => null;

	public CSVAsyncDataMap<uint, TutorialSubGoal> SubGoalConfigs => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public bool TryGetGoal(uint phaseId, out TutorialGoal data)
	{
		data = null;
		return false;
	}

	public bool TryGetSubGoal(uint taskId, out TutorialSubGoal data)
	{
		data = null;
		return false;
	}

	public uint[] GetSubGoalIds(TutorialGoal data)
	{
		return null;
	}

	private static uint[] NormalizeSubGoalIds(uint[] subGoalIds)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}

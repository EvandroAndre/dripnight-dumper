using System.Collections.Generic;

namespace COW;

internal sealed class BRTutorialTaskConfig
{
	public const uint InvalidPhaseId = 0u;

	public const uint InvalidTaskId = 0u;

	private static readonly bool UseTemporaryHardcodedConfigData;

	private readonly IReadOnlyList<uint> m_EmptyTasks;

	private readonly Dictionary<uint, List<uint>> m_PhaseTasks;

	private readonly Dictionary<EBRTutorialTaskTriggerType, uint> m_TaskByTrigger;

	private readonly Dictionary<uint, string> m_PhaseTitles;

	private readonly Dictionary<uint, string> m_TaskDescriptions;

	private readonly List<uint> m_OrderedPhases;

	private bool m_CacheInitialized;

	public void Init()
	{
	}

	public void Cleanup()
	{
	}

	public IReadOnlyList<uint> GetTasks(uint phaseId)
	{
		return null;
	}

	public bool TryGetFirstPhase(out uint phaseId)
	{
		phaseId = default(uint);
		return false;
	}

	public bool TryGetNextPhase(uint currentPhaseId, out uint nextPhaseId)
	{
		nextPhaseId = default(uint);
		return false;
	}

	public bool TryGetPostLandingPhase(out uint phaseId)
	{
		phaseId = default(uint);
		return false;
	}

	public bool IsFirstPhase(uint phaseId)
	{
		return false;
	}

	public bool IsTaskInFirstPhase(uint taskId)
	{
		return false;
	}

	public string GetPhaseTitle(uint phaseId)
	{
		return null;
	}

	public string GetTaskDescription(uint taskId)
	{
		return null;
	}

	public bool TryMatchTrigger(EBRTutorialTaskTriggerType triggerType, out uint taskId)
	{
		taskId = default(uint);
		return false;
	}

	public bool TryMatchMapMarkTask(uint markType, out uint taskId)
	{
		taskId = default(uint);
		return false;
	}

	private bool IsTaskInPhase(uint phaseId, uint taskId)
	{
		return false;
	}

	private void TestInitConfigData()
	{
	}

	private int AddTestPhaseConfig(uint phaseId, string title, uint[] taskIds)
	{
		return 0;
	}

	private bool AddTestTaskConfig(uint taskId, string description, EBRTutorialTaskTriggerType triggerType)
	{
		return false;
	}

	private void EnsureInitialized()
	{
	}

	private void ClearCache()
	{
	}

	private void ClearCacheData()
	{
	}
}

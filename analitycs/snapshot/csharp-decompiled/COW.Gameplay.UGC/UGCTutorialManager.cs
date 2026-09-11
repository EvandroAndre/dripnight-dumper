using System.Collections.Generic;
using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialManager : SingletonModule<UGCTutorialManager>
{
	private const string PREFS_KEY_SEQUENCE_ID = "UGCTutorial_SequenceId";

	private const string PREFS_KEY_LEVEL_INDEX = "UGCTutorial_LevelIndex";

	private const string PREFS_KEY_TASK_INDEX = "UGCTutorial_TaskIndex";

	private string m_CurrentSequenceId;

	private int m_SavedLevelIndex;

	private int m_SavedTaskIndex;

	private Dictionary<string, UGCTutorialSequenceData> m_SequenceCache;

	private Dictionary<int, UGCTutorialLevelConfig> m_LevelConfigById;

	private Dictionary<int, UGCTutorialLevelConfig> m_LevelConfigByLevelId;

	public string CurrentSequenceId => null;

	public int SavedLevelIndex => 0;

	public int SavedTaskIndex => 0;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public UGCTutorialSequenceData GetSequenceData(string sequenceId)
	{
		return null;
	}

	public UGCTutorialSequenceData GetCurrentSequence()
	{
		return null;
	}

	public UGCTutorialLevelConfig GetLevelConfigById(int configId)
	{
		return null;
	}

	public UGCTutorialLevelConfig GetLevelConfigByLevelId(int levelId)
	{
		return null;
	}

	public UGCTutorialLevelConfig GetLevelConfigByRawLevelId(string rawLevelId)
	{
		return null;
	}

	public UGCTutorialLevelConfig GetCurrentLevelConfig()
	{
		return null;
	}

	public void SaveProgress(int levelIndex, int taskIndex)
	{
	}

	public void SetCurrentSequence(string sequenceId)
	{
	}

	public void ResetProgress()
	{
	}

	public bool IsSequenceCompleted()
	{
		return false;
	}

	private void LoadLevelConfigs()
	{
	}

	private bool TryParseLevelId(string rawLevelId, out int levelId)
	{
		levelId = default(int);
		return false;
	}
}

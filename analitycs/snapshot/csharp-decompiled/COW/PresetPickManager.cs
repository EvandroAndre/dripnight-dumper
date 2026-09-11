using System.Collections.Generic;
using GCommon;

namespace COW;

public class PresetPickManager : SingletonModule<PresetPickManager>
{
	private float PresetSkillLastRequestTime;

	private float PresetLoadoutLastRequestTime;

	private float PresetChangingStateSyncInterval;

	private List<PresetPickData> m_PresetPickDataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool SendPresetSkillChooseRequest(uint presetId)
	{
		return false;
	}

	public bool SendPresetLoadoutChooseRequest(uint loadoutId)
	{
		return false;
	}

	public bool SyncChangingState(bool forceSync, bool isChangingSkill, bool isChangingLoadout)
	{
		return false;
	}

	public bool CheckPlayerNeedAutoOpenPresetPick()
	{
		return false;
	}

	private uint GetCurPlayerPresetPickParam(uint gameMode, uint matchMode)
	{
		return 0u;
	}
}

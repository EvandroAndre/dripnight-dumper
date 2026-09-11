using System.Collections.Generic;
using GCommon;

namespace COW;

public class ClimbingTriggerSettingManager : SingletonModule<ClimbingTriggerSettingManager>
{
	private Dictionary<uint, ClimbingTriggerSettingData> m_ClimbingTriggerSettings;

	protected override void OnCleanup()
	{
	}

	private uint MakeDataKey(uint map_config_id, uint climbing_trigger_id)
	{
		return 0u;
	}

	protected override void OnInit()
	{
	}

	public ClimbingTriggerSettingData GetClimbingTriggerSetting(uint map_id, uint mode_id, uint climbing_trigger_id)
	{
		return null;
	}
}

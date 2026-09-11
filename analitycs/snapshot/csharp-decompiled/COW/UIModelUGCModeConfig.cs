using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelUGCModeConfig : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint gameMode;

		public uint templateID;

		internal bool _003CGetSwitchConfigData_003Eb__0(WorkshopModeSwitchDesc x)
		{
			return false;
		}
	}

	private List<WorkshopModeSwitchDesc> m_SwitchDataList;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void LoadSwitchConfig(List<WorkshopModeSwitchDesc> list)
	{
	}

	public WorkshopModeSwitchDesc GetSwitchConfigData(uint gameMode, uint templateID)
	{
		return null;
	}

	public bool CheckHudEnabled(uint gameMode, uint templateID)
	{
		return false;
	}

	public bool CheckGraphEnabled(uint gameMode, uint templateID)
	{
		return false;
	}
}

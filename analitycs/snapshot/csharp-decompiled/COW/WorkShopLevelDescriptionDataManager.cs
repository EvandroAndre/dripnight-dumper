using System.Collections.Generic;
using GCommon;

namespace COW;

internal class WorkShopLevelDescriptionDataManager : SingletonModule<WorkShopLevelDescriptionDataManager>
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public SceneEditSlotInfo info;

		internal bool _003CGetKeyBySlotInfo_003Eb__0(WorkShopLevelDescriptionData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint gameMode;

		public int templateID;

		internal bool _003CGetKeyByTemplateId_003Eb__0(WorkShopLevelDescriptionData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public uint gameMode;

		public int customTemplateID;

		internal bool _003CGetCDNUrlByGameMode_003Eb__0(WorkShopLevelDescriptionData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public uint gameMode;

		public uint templateIndex;

		internal bool _003CGetData_003Eb__0(WorkShopLevelDescriptionData x)
		{
			return false;
		}
	}

	private List<WorkShopLevelDescriptionData> m_WorkShopLevelDescList;

	protected override void OnInit()
	{
	}

	public string GetKeyBySlotInfo(SceneEditSlotInfo info)
	{
		return null;
	}

	public string GetKeyByTemplateId(uint gameMode, int templateID)
	{
		return null;
	}

	public string GetCDNUrlBySlotInfo(SceneEditSlotInfo info)
	{
		return null;
	}

	public string GetCDNUrlByGameMode(uint gameMode, int customTemplateID = 0)
	{
		return null;
	}

	public WorkShopLevelDescriptionData GetData(uint gameMode, uint templateIndex)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}

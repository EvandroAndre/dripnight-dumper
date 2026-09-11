using System.Collections.Generic;
using GCommon;

namespace COW;

internal class InviteTypeSettingDataManager : SingletonModule<InviteTypeSettingDataManager>
{
	private List<InviteTypeSettingData> m_InviteTypeSettingDataList;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public List<uint> GetInviteTypes(uint gameMode, uint matchMode)
	{
		return null;
	}
}

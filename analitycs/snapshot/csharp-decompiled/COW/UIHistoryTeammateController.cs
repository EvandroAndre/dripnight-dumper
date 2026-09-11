using GCommon;
using proto;

namespace COW;

public class UIHistoryTeammateController : UIBaseController
{
	private UIBriefProfileInfoController m_CallSign;

	private UIHistoryTeammateView m_View;

	private BaseProfileInfo m_Info;

	protected override void OnUIInit()
	{
	}

	public void SetData(TeammateStats info, uint gameMode)
	{
	}

	public void SetData(UGCPlayerStats stats, int[] scoreType, int ugcTemplateId)
	{
	}

	public void RefreshFriendBtnShow()
	{
	}

	private void OnAddFriendClick()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

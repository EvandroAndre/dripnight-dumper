using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIHUDUGC_TwoTeamLeaderboard_TeammateItemController : UIHUDUGC_BaseLeaderboard_TeammateItemController
{
	private UIHUDUGC_TwoTeamLeaderboard_TeammateItemView m_View;

	private Dictionary<int, UILabel> m_LabelDict;

	private List<UILabel> m_CustomLabelList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<int> scoreTypes)
	{
	}

	public void SetViewDataByCustomScore(int infoTypeCount)
	{
	}

	protected override void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	protected override void SetSelf(bool isSelf)
	{
	}

	public override void RefreshInfo(HPGAEEBKCIE infoType)
	{
	}

	public override void RefreshAllInfo()
	{
	}

	public void RefreshAllCustomInfo(List<object> customScore)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowProfileInfo(BaseProfileInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSelf(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshInfo(HPGAEEBKCIE P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAllInfo()
	{
	}
}

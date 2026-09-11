using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDUGC_SingleLeaderboard_ItemController : UIHUDUGC_BaseLeaderboard_TeammateItemController
{
	private UIHUDUGC_SingleLeaderboard_ItemView m_View;

	private List<int> m_ScoreTypes;

	private Dictionary<int, UILabel> m_LabelDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetScoreType(List<int> scoreTypes)
	{
	}

	protected override void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	public override void RefreshAllInfo()
	{
	}

	public void SetTeamRank(int rank)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void SetSelf(bool isSelf)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowProfileInfo(BaseProfileInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAllInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSelf(bool P0)
	{
	}
}

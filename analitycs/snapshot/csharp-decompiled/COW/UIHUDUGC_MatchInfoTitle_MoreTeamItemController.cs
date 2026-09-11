using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_MatchInfoTitle_MoreTeamItemController : UIBaseController
{
	private UIHUDUGC_MatchInfoTitle_MoreTeamItemView m_View;

	private UIHUDUGC_MatchInfoTitleController.MatchInfoTitleData m_ViewData;

	private uint m_TeamIndex;

	private Color m_DefaultColor;

	public uint TeamIndex => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIHUDUGC_MatchInfoTitleController.MatchInfoTitleData viewData)
	{
	}

	public void SetData(int rank, MatchTeam team, bool isSelf)
	{
	}

	public void SetFinishTeammateNum(int num)
	{
	}

	public void SetTeamTargetScore(int num, int max)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

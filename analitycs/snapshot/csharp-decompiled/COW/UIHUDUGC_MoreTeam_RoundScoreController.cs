using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDUGC_MoreTeam_RoundScoreController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_MoreTeam_RoundScoreView m_View;

	private UGCTeamRoundScoreBannerHudRepItem m_ViewData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private string GetLocText(string key, object[] param)
	{
		return null;
	}

	private void ShowFirstScore()
	{
	}

	private void ShowSecondScore()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnLocSwitchChanged(bool cur)
	{
	}

	private void OnFirstScoreTitleChanged(string cur)
	{
	}

	private void OnFirstScoreValueKeyChanged(string cur)
	{
	}

	private void OnFirstScoreValueParamsChanged(List<object> cur)
	{
	}

	private void OnSecondScoreTitleChanged(string cur)
	{
	}

	private void OnSecondScoreValueKeyChanged(string cur)
	{
	}

	private void OnSecondScoreValueParamsChanged(List<object> cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}

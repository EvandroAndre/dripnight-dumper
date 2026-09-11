using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDUGC_RoundStartBanner_RedBlueController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_RoundStartBanner_RedBlueView m_View;

	private UGCTwoTeamRoundStartBannerHudRepItem m_ViewData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private string GetLocText(string text, object[] parmas)
	{
		return null;
	}

	private void ShowRoundNum()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnRoundNumTextChanged(string cur)
	{
	}

	private void OnRoundNumParamsChanged(List<object> cur)
	{
	}

	private void OnDescTextChanged(string cur)
	{
	}

	private void OnLeftColorChanged(int cur)
	{
	}

	private void OnRightColorChanged(int cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}

using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_RoundStartBanner_YellowController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_RoundStartBanner_YellowView m_View;

	private UGCNormalRoundStartBannerHudRepItem m_ViewData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private string GetLocText(string text, object[] parmas)
	{
		return null;
	}

	private void ShowRoundNum()
	{
	}

	private bool IsBlack(Color c)
	{
		return false;
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

	private void OnThemeColorChanged(int cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

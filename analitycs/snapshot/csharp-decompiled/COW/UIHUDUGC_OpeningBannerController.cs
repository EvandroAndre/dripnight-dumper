using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_OpeningBannerController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_OpeningBannerView m_View;

	private UGCOpeningBannerHudRepItem m_ViewData;

	private List<UIProgressBar> m_CacheProgressItem;

	private int m_MaxProgress;

	private int m_CurProgress;

	private const int UIMAXPROGRESSCNT = 10;

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

	private void OnLocSwitch(bool cur)
	{
	}

	private void OnIconChange(string obj)
	{
	}

	public override void DestroyEntity()
	{
	}

	private string GetLocText(string value)
	{
		return null;
	}

	private bool IsBlack(Color c)
	{
		return false;
	}

	private void UpdateIconSprite()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnIconSpriteNameChanged(string cur)
	{
	}

	private void OnThemeColorChanged(int cur)
	{
	}

	private void OnTitleTextChanged(string cur)
	{
	}

	private void OnDescTextChanged(string cur)
	{
	}

	private void OnMaxProgressChanged(int cur)
	{
	}

	private void OnCurProgressChanged(int cur)
	{
	}

	private void CalcProgressUI()
	{
	}

	private void OnProgressIconChanged(string val)
	{
	}

	private void OnProgressIconSpriteNameChanged(string val)
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

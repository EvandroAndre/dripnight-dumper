using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TitleBannerController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_TitleBannerView m_View;

	private UGCTitleBannerHudRepItem m_Component;

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

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnLocalPositionChanged(Vector3 cur)
	{
	}

	private void OnFontSizeChanged(int cur)
	{
	}

	private void OnColorChanged(int cur)
	{
	}

	private void OnLabelKeyChanged(string cur)
	{
	}

	private void OnLabelParamsChanged(List<object> cur)
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

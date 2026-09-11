using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TextTipsController : UIHUDUGC_InternalHudController
{
	private UGCTextTipsHudRepItem m_UGCEntityRepItem;

	private UIHUDUGC_TextTipsView m_View;

	private UITweener[] m_Tweeners;

	private UIPanel m_HudPanel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
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

	private Transform GetAnchor(EUIAnchor anchor)
	{
		return null;
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnUIAnchorChanged(int cur)
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

	private void OnTweenerEnabledChanged(bool cur)
	{
	}

	private void OnLocSwitchChanged(bool switchOn)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
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

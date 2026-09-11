using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonTipsController : UIPopupWindowController
{
	private UICommonTipsView m_View;

	private Vector2 m_showOffset;

	private int m_Width;

	private int m_Height;

	private float m_scale;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowTipsAtPosition(List<string> list, float postionX, float postionY)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

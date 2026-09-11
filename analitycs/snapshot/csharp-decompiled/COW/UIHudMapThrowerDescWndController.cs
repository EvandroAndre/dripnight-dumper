using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapThrowerDescWndController : UIBaseController
{
	private UIHudMapThrowerDescWndView m_View;

	private Action<uint> m_ItemClick;

	private VisualInstanceHolder m_UIFXHolder;

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

	private void OnItemBtnClick(uint itemIndex)
	{
	}

	public void RefreshView(Action<uint> itemClick)
	{
	}

	private void RefreshUIView(AJMGIJJMNAH itemData, GameObject itemObj, UILabel itemTitle, UILabel itemDesc, UISprite itemIcon)
	{
	}

	public void RefreshUIFX(bool show)
	{
	}

	public UIWidget GetGuideWidget(TutorialEventEnum guideType)
	{
		return null;
	}

	private void _003COnUIInit_003Eb__4_0()
	{
	}

	private void _003COnUIInit_003Eb__4_1()
	{
	}

	private void _003COnUIInit_003Eb__4_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

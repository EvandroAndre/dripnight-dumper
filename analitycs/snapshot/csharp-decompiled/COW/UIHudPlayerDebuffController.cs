using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPlayerDebuffController : UIBaseController
{
	private UIHudPlayerDebuffInfoView m_View;

	private List<UIHudPlayerDebuffItem> m_DebuffItems;

	private int m_ActiveDebuffIconCnt;

	private Vector3 BGOriginalPosition;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	public UIWidget GetUIWidget()
	{
		return null;
	}

	private void OnHudCustomizeSettingChanged(object[] data)
	{
	}

	private void HideAllDeBuffItem()
	{
	}

	private void OnUpdateDebuff(object[] data)
	{
	}

	public void UpdateTableAlignmentAndPivot(UIWidget.Pivot alignment, UIWidget.Pivot pivot)
	{
	}

	public bool HasDebuffActive()
	{
		return false;
	}

	private void OnItemPress(GameObject ob)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

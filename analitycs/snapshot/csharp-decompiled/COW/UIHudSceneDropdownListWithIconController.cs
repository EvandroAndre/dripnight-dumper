using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudSceneDropdownListWithIconController : UIBaseController
{
	private UIHudSceneDropdownListWithIconView m_View;

	private List<UIHudSceneDropDownItemWithIconData> m_DataList;

	private List<UIHudSceneDropdownItemWithIconController> m_ItemCtrls;

	private UIHudSceneDropDownItemWithIconData m_CurrentSelectData;

	private Action m_OnCloseCallBack;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void InitDropDownTableTemplate()
	{
	}

	private void RefreshAllItemsState()
	{
	}

	private void OnCloseClick()
	{
	}

	public void BuildDropDownTable(List<UIHudSceneDropDownItemWithIconData> list, float itemWidth, float itemHeight)
	{
	}

	public void RegisterCallBack(Action onClose)
	{
	}

	public void OnItemClick(UIHudSceneDropDownItemWithIconData data)
	{
	}

	private UITable2.IUITable2Item _003CInitDropDownTableTemplate_003Eb__7_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

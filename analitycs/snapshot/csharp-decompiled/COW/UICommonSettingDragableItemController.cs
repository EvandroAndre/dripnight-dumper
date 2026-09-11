using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonSettingDragableItemController : UICommonSettingDragableItemBaseController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Action click;

		public UICommonSettingDragableItemController _003C_003E4__this;

		internal void _003CInitToggleBtns_003Eb__0()
		{
		}
	}

	private UICommonSettingDragableItemView m_View;

	private CommonSettingDragableItemData m_Data;

	private List<CommonSettingToggleItem> m_Toggles;

	private List<UICommonSettingDragableSliderItemController> m_Sliders;

	private int SubitemHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void RefreshContent()
	{
	}

	public void SetViewData(CommonSettingDragableItemData itemData, ICommonSettingDragParent settingParent)
	{
	}

	public void ShowDragDropBtn(bool show)
	{
	}

	public override void SetItemNoninteractable()
	{
	}

	private void InitToggleBtns()
	{
	}

	private int GetSelectBtn()
	{
		return 0;
	}

	private void UpdateToggles()
	{
	}

	public void CloseExpandToggle()
	{
	}

	public void RefreshExpandToggle()
	{
	}

	private void OnExpandToggleBtnChange()
	{
	}

	private void OpenMenuItemControllers()
	{
	}

	private void CloseMenuItemControllers()
	{
	}

	public override void UpdateHighLightState(uint itemId, bool up = false)
	{
	}

	public UIWidget GetSubItemDragBounds()
	{
		return null;
	}

	public bool IsSubitemExist(uint itemId)
	{
		return false;
	}

	public UIBaseController GetSubitemCtrl(uint itemId)
	{
		return null;
	}

	public GameObject GetDragItem()
	{
		return null;
	}

	public override void ResetHighLightState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_SetItemNoninteractable()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateHighLightState(uint P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetHighLightState()
	{
	}
}

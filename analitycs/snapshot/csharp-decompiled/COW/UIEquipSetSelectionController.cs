using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEquipSetSelectionController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIEquipSetSelectionView m_View;

	private UIModelLinkActivity m_Model;

	private bool m_ModelRegistered;

	private UITimeLabelHelper m_TimeHelper;

	private List<UIEquipSetItemController> m_Items;

	private int m_SelectedIndex;

	private bool m_InGame;

	private int m_SetId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetUIData(int setId)
	{
	}

	protected virtual UIEquipSetItemController OpenChildContainer(Transform parent)
	{
		return null;
	}

	private void SetLastTime(DateTime start, DateTime end)
	{
	}

	public void ShowInGameWindow(int index, float secs)
	{
	}

	private void InitUIDataAndShow(bool lobby)
	{
	}

	private void SetUIDataAndShow()
	{
	}

	private void ShowContent(bool inGame, bool lobby)
	{
	}

	private void RequestEquipSets()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SelectItem(int index)
	{
	}

	private void HighLightIndex(int index, bool hightlight)
	{
	}

	private void OnClickConfirm()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void EnableInventory(bool enable)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}

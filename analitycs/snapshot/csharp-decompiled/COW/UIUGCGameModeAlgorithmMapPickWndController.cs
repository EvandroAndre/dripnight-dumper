using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCGameModeAlgorithmMapPickWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIUGCGameModeAlgorithmMapPickWndView m_View;

	private WorkshopUGCOpeningInfoDesc m_WorkshopUGCOpeningInfoDesc;

	private List<string> m_SelectWorkshopCodes;

	private List<string> m_InitialWorkshopCodes;

	private UIModelMapOpeningInfo m_Model;

	private List<UIUGCGameModeAlgorithmMapPickItemController> m_PickItemCtrls;

	public List<int> Tags;

	private bool m_dirty;

	private EUGCScene m_src;

	private Action<string> m_NotifyWndConfirm;

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

	private void InitView()
	{
	}

	public void SetData(WorkshopUGCOpeningInfoDesc desc, Action<string> action, EUGCScene src = EUGCScene.EUGCScene_None)
	{
	}

	private bool IsPickAll()
	{
		return false;
	}

	private void OnBtnSelectAll()
	{
	}

	private void OnClickConfirm()
	{
	}

	public void OnItemSelect(bool select, string code)
	{
	}

	public void SaveAll()
	{
	}

	public void InitCloseUI()
	{
	}

	private void OnMyClose()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

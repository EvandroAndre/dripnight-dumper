using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITailorEntranceController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	private UITailorEntranceView m_View;

	private UIModelTailor m_ModelTailor;

	private bool m_NeedRefreshView;

	private ETailorTabType m_CurrentTab;

	private UIStandardTabController m_TabCtrl;

	private List<StandardTabItemViewData> m_TabDataList;

	private UIModelInventory m_ModelInventory;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void RefreshView()
	{
	}

	private void RequestListItemChannelinfo(List<TailorSettingDesc> tailorSettings)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void InitTabData()
	{
	}

	private void OpenLeftTab()
	{
	}

	private void SetTabBP()
	{
	}

	private void SetTabLegend()
	{
	}

	private void SetTabIP()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}

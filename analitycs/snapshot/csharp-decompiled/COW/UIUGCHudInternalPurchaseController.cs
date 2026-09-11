using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCHudInternalPurchaseController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum ContentTemplateType
	{
		Item,
		Title
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public int id;

		internal bool _003COnSelectItemByID_003Eb__0(UIUGCHudInternalPurchaseTabController e)
		{
			return false;
		}
	}

	private UIUGCHudInternalPurchaseView m_View;

	private UGCUIInternalPurchaseHudRepItem m_ViewData;

	private UIModelUGCCommerceIAP m_Model;

	private List<UIUGCHudInternalPurchaseTabController> m_TabCtrlList;

	private UITable2VirtualBoundsHelper m_Table2VirtualBoundsHelper;

	private List<int> m_ViewDataIndices;

	private List<UIUGCHudInternalPurchaseTokenController> m_TokenCtrlList;

	private List<UGCInternalPurchaseShelfData> m_ShelfDataList;

	private bool m_InGame;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitTable2Templates()
	{
	}

	private void InitVirtualBoundsHelper()
	{
	}

	private void OnBgBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateTabsHighlightState()
	{
	}

	private void SelectAndFocusTabWithIndex(int index)
	{
	}

	private void GetStoreData(bool needRefresh = false)
	{
	}

	public void RefreshContentTable2Data(bool keepScrollPosition = false)
	{
	}

	private void InitToken()
	{
	}

	private void RefreshToken()
	{
	}

	private void RefreshViewData()
	{
	}

	private void SendCommerceIAPState(bool state)
	{
	}

	public bool OnSelectItemByID(int id)
	{
		return false;
	}

	public void ShowTweenTips(string tips)
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__16_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__16_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}

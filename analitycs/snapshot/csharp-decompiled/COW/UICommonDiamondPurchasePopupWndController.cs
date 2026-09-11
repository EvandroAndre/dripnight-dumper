using GCommon;

namespace COW;

public class UICommonDiamondPurchasePopupWndController : UIPopupWindowController
{
	private bool m_ClosePopupAfterClick;

	private EventDelegate.Callback m_OnPurchaseBtnClick;

	private UICommonDiamondPurchasePopupWndView m_View;

	private UIStandardItemMiniController m_StandardItemMiniCtrl;

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

	private void PrepareStandardItem()
	{
	}

	private void SetupDefaultContent()
	{
	}

	private void RefreshItemPreviewGroup(string description, BaseItemInfo itemInfo)
	{
	}

	private void RefreshNoPreviewGroup(string description)
	{
	}

	private void RefreshPriceLabel(uint price)
	{
	}

	private void BindPurchaseBtn(EventDelegate.Callback onPurchaseBtnClick)
	{
	}

	private void RefreshPopupWndTitle(string titleKey)
	{
	}

	private void OnDiamondPurchaseBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	public void SetViewData(uint price, string description, string titleKey, EventDelegate.Callback onPurchaseBtnClick, bool closeAfterClick = true)
	{
	}

	public void SetViewData(uint price, string description, string titleKey, BaseItemInfo itemInfo, EventDelegate.Callback onPurchaseBtnClick, bool closeAfterClick = true)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

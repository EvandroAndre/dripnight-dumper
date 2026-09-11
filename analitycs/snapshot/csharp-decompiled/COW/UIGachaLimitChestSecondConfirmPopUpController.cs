using GCommon;

namespace COW;

public class UIGachaLimitChestSecondConfirmPopUpController : UIPopupWindowController
{
	private bool m_bIsInit;

	private int m_gachaID;

	private int m_uFirstItemID;

	private int m_uSecondItemID;

	private UICommonTinyMsgBoxView m_View;

	private void RefreshUI()
	{
	}

	public void Init(int gachaID, int itemID, int otherItemID)
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickConfirm()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

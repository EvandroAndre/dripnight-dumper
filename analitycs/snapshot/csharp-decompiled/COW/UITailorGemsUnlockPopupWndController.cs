using GCommon;
using proto;

namespace COW;

public class UITailorGemsUnlockPopupWndController : UIMallPurchaseBaseController
{
	private TailorUnlockDesc m_TailorUnlockDesc;

	private UIModelInventory m_ModelInventory;

	private bool m_isBundleCloth;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnTailorUnlockBtnClick()
	{
	}

	public void RefreshData(TailorUnlockDesc tailorUnlockDesc, bool isBundleCloth = false)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

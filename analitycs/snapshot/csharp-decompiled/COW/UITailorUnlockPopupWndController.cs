using GCommon;
using proto;

namespace COW;

public class UITailorUnlockPopupWndController : UIMallPurchaseBaseController
{
	private TailorUnlockDesc m_TailorUnlockDesc;

	private UIModelInventory m_ModelInventory;

	private uint m_UniqueTokenItemID;

	private uint m_GeneralTokenItemID;

	private const string TOKENFORMAT = "{0}/{1}";

	private const string TOKENNOTENOUGHFORMAT = "[FF0000]{0}[-]/{1}";

	private int m_tokenCnt;

	private uint m_needCnt;

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

	public void RefreshData(TailorUnlockDesc tailorUnlockDesc, uint uniqueTokenID, uint generalTokenID, bool isBundleCloth = false, ETailorUnlockTokenType TokenType = ETailorUnlockTokenType.None)
	{
	}

	private void RefreshBuyBtnTokenUI()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

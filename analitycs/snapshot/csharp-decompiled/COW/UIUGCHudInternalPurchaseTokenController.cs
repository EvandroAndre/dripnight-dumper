using GCommon;

namespace COW;

public class UIUGCHudInternalPurchaseTokenController : UIBaseController
{
	private enum EUGCInternalPurchaseTokenType
	{
		UGCToken,
		Gems
	}

	private UIUGCHudInternalPurchaseTokenView m_View;

	private UIModelUGCCommerceIAP m_Model;

	private uint m_TokenType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCTokenData data)
	{
	}

	public void RefreshTokenCount()
	{
	}

	private int GetUserTokenCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

using GCommon;

namespace COW;

public class UIDrawShopTokenPurchaseController : UIMallPurchaseBaseController
{
	private UIModelDrawShop m_ModelDrawShop;

	private uint m_DrawShopId;

	private uint m_CurrentTokenCnt;

	private uint m_TokenInCardPool;

	private uint[] m_TokenDiamonds;

	private uint m_TokenItemId;

	private UIModelDrawShop.EDrawShopCoinType m_CoinType;

	protected override int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(uint shopId, uint currentTokenCnt, uint tokenInCardPool, uint[] tokenDiamonds, uint tokenItemId)
	{
	}

	private uint CalculateTotalCost(int count)
	{
		return 0u;
	}

	private void RefreshTotalPrice()
	{
	}

	private void OnConfirmPurchase()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}
}

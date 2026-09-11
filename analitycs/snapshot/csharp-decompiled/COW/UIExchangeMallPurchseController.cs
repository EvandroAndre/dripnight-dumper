using GCommon;
using proto;

namespace COW;

public class UIExchangeMallPurchseController : UIMallPurchaseBaseController
{
	public enum EFromType
	{
		NONE,
		MALL,
		EXCHANGE_POP
	}

	protected ExchangeStoreItemDesc m_ExchangeStoreItem;

	private EFromType m_EntryFrom;

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

	protected void OnExchangeBtnClick()
	{
	}

	public virtual void RefreshData(ExchangeStoreItemDesc exchangeStoreItem, EFromType entryFrom = EFromType.MALL)
	{
	}

	protected void SetExchangeIcon(UISprite sprite)
	{
	}

	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}
}

using GCommon;
using proto;

namespace COW;

public class UIMallMysteryPurchaseController : UIMallPurchaseBaseController
{
	private MysteryPoolStoreItem m_MysteryStoreDesc;

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

	private void PurchaseItem()
	{
	}

	public void RefreshData(MysteryPoolStoreItem poolStoreItem)
	{
	}

	private void SetPriceData()
	{
	}

	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

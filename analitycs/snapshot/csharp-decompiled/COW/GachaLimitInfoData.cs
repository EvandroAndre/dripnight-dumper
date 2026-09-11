using System.Collections.Generic;
using proto;

namespace COW;

public class GachaLimitInfoData : GachaPackageInfoData
{
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public LimitedChestGoods superGood;

		internal bool _003CUpdateHackerStoreSuperGrandPrize_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	public static uint GACHA_LIMIT_POOL_MAX;

	private List<uint> _003CRemoveItemList_003Ek__BackingField;

	private List<uint> _003COwnedItemList_003Ek__BackingField;

	private List<uint> _003CPriceList_003Ek__BackingField;

	private List<uint> _003CPriceDiscountType_003Ek__BackingField;

	private List<uint> _003CPriceDiscountList_003Ek__BackingField;

	private uint _003CCurrentPurchaseRewardID_003Ek__BackingField;

	public List<uint> RemoveItemList
	{
		get
		{
			return _003CRemoveItemList_003Ek__BackingField;
		}
		private set
		{
			_003CRemoveItemList_003Ek__BackingField = value;
		}
	}

	public List<uint> OwnedItemList
	{
		get
		{
			return _003COwnedItemList_003Ek__BackingField;
		}
		private set
		{
			_003COwnedItemList_003Ek__BackingField = value;
		}
	}

	public List<uint> PriceList
	{
		get
		{
			return _003CPriceList_003Ek__BackingField;
		}
		private set
		{
			_003CPriceList_003Ek__BackingField = value;
		}
	}

	public List<uint> PriceDiscountType
	{
		get
		{
			return _003CPriceDiscountType_003Ek__BackingField;
		}
		private set
		{
			_003CPriceDiscountType_003Ek__BackingField = value;
		}
	}

	public List<uint> PriceDiscountList
	{
		get
		{
			return _003CPriceDiscountList_003Ek__BackingField;
		}
		private set
		{
			_003CPriceDiscountList_003Ek__BackingField = value;
		}
	}

	public uint CurrentPurchaseRewardID
	{
		get
		{
			return _003CCurrentPurchaseRewardID_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentPurchaseRewardID_003Ek__BackingField = value;
		}
	}

	public override void UpdateByGachaResult(CSLotteryRes gachaResult, UIModelGacha.GachaDrawType drawType = UIModelGacha.GachaDrawType.TYPE_NONE)
	{
	}

	private void SetCurrentResultID()
	{
	}

	protected override void OnUpdateInfoData()
	{
	}

	public int GetCurrentPurchaseCnt()
	{
		return 0;
	}

	public int GetPurchaseLimitCount()
	{
		return 0;
	}

	protected override void OnProcessDescData(GachaDesc gachaRes)
	{
	}

	private void UpdatePriceInfo(uint[] price, uint[] priceType, uint[] priceDiscount)
	{
	}

	public void UpdateLimitGachaRemoveItems()
	{
	}

	private void UpdateLimitGachaHasOwnedItems()
	{
	}

	public void UpdateHackerStoreSuperGrandPrize(List<LimitedChestGoods> goods)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateByGachaResult(CSLotteryRes P0, UIModelGacha.GachaDrawType P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateInfoData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnProcessDescData(GachaDesc P0)
	{
	}
}

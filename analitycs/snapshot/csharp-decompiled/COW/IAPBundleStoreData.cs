using GCommon;
using proto;

namespace COW;

public class IAPBundleStoreData : CSVBaseData
{
	private int _003CStoreID_003Ek__BackingField;

	private int _003CBundleID_003Ek__BackingField;

	private int _003CProductID_OriginalPrice_003Ek__BackingField;

	private float _003COriginalPrice_003Ek__BackingField;

	private int _003CRebateID_ActualPrice_003Ek__BackingField;

	private int _003CProductID_ActualPrice_003Ek__BackingField;

	private float _003CActualPrice_003Ek__BackingField;

	private string _003CSlogan_003Ek__BackingField;

	private int _003CDiamondPrice_003Ek__BackingField;

	private int _003CDiscountDiamondPrice_003Ek__BackingField;

	private int _003CDiamondBonus_003Ek__BackingField;

	private EStoreType _003CStoreType_003Ek__BackingField;

	private string _003CWebLink_003Ek__BackingField;

	private int _003CActivityId_003Ek__BackingField;

	public int StoreID
	{
		get
		{
			return _003CStoreID_003Ek__BackingField;
		}
		private set
		{
			_003CStoreID_003Ek__BackingField = value;
		}
	}

	public int BundleID
	{
		get
		{
			return _003CBundleID_003Ek__BackingField;
		}
		private set
		{
			_003CBundleID_003Ek__BackingField = value;
		}
	}

	public int ProductID_OriginalPrice
	{
		get
		{
			return _003CProductID_OriginalPrice_003Ek__BackingField;
		}
		private set
		{
			_003CProductID_OriginalPrice_003Ek__BackingField = value;
		}
	}

	public float OriginalPrice
	{
		get
		{
			return _003COriginalPrice_003Ek__BackingField;
		}
		private set
		{
			_003COriginalPrice_003Ek__BackingField = value;
		}
	}

	public int RebateID_ActualPrice
	{
		get
		{
			return _003CRebateID_ActualPrice_003Ek__BackingField;
		}
		private set
		{
			_003CRebateID_ActualPrice_003Ek__BackingField = value;
		}
	}

	public int ProductID_ActualPrice
	{
		get
		{
			return _003CProductID_ActualPrice_003Ek__BackingField;
		}
		private set
		{
			_003CProductID_ActualPrice_003Ek__BackingField = value;
		}
	}

	public float ActualPrice
	{
		get
		{
			return _003CActualPrice_003Ek__BackingField;
		}
		private set
		{
			_003CActualPrice_003Ek__BackingField = value;
		}
	}

	public int DiscountPercentage => 0;

	public string Slogan
	{
		get
		{
			return _003CSlogan_003Ek__BackingField;
		}
		private set
		{
			_003CSlogan_003Ek__BackingField = value;
		}
	}

	public int DiamondPrice
	{
		get
		{
			return _003CDiamondPrice_003Ek__BackingField;
		}
		private set
		{
			_003CDiamondPrice_003Ek__BackingField = value;
		}
	}

	public int DiscountDiamondPrice
	{
		get
		{
			return _003CDiscountDiamondPrice_003Ek__BackingField;
		}
		private set
		{
			_003CDiscountDiamondPrice_003Ek__BackingField = value;
		}
	}

	public int DiamondBonus
	{
		get
		{
			return _003CDiamondBonus_003Ek__BackingField;
		}
		private set
		{
			_003CDiamondBonus_003Ek__BackingField = value;
		}
	}

	public EStoreType StoreType
	{
		get
		{
			return _003CStoreType_003Ek__BackingField;
		}
		private set
		{
			_003CStoreType_003Ek__BackingField = value;
		}
	}

	public string WebLink
	{
		get
		{
			return _003CWebLink_003Ek__BackingField;
		}
		private set
		{
			_003CWebLink_003Ek__BackingField = value;
		}
	}

	public int ActivityId
	{
		get
		{
			return _003CActivityId_003Ek__BackingField;
		}
		private set
		{
			_003CActivityId_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public void ParseDataFromIAPStoreDes(IAPStoreDesc data)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}

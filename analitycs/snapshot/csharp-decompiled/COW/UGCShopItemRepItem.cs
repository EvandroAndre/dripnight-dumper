using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCShopItemRepItem
{
	public const int PROP_ID_ID = -71000;

	public const int PROP_ID_PRICE = -71001;

	public const int PROP_ID_MONEYTYPE = -71002;

	public const int PROP_ID_TOTALPURCHASELIMIT = -71003;

	public const int PROP_ID_CURTOTALPURCHASELIMIT = -71004;

	public const int PROP_ID_NAME = -71005;

	public const int PROP_ID_DESC = -71006;

	public const int PROP_ID_ITEMGOODSIDLIST = -71007;

	public const int PROP_ID_ITEMGOODSCNTLIST = -71008;

	public const int PROP_ID_ICONTYPE = -71009;

	public const int PROP_ID_CANPURCHAS = -71010;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnIDChangeEvent;

	public Action<int> OnPriceChangeEvent;

	public Action<int> OnMoneyTypeChangeEvent;

	public Action<int> OnTotalPurchaseLimitChangeEvent;

	public Action<int> OnCurTotalPurchaseLimitChangeEvent;

	public Action<string> OnNameChangeEvent;

	public Action<string> OnDescChangeEvent;

	public Action<List<object>> OnItemGoodsIDListChangeEvent;

	public Action<List<object>> OnItemGoodsCntListChangeEvent;

	public Action<string> OnIconTypeChangeEvent;

	public Action<bool> OnCanPurchasChangeEvent;

	private int _003CID_003Ek__BackingField;

	private int _003CPrice_003Ek__BackingField;

	private int _003CMoneyType_003Ek__BackingField;

	private int _003CTotalPurchaseLimit_003Ek__BackingField;

	private int _003CCurTotalPurchaseLimit_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CDesc_003Ek__BackingField;

	private List<object> _003CItemGoodsIDList_003Ek__BackingField;

	private List<object> _003CItemGoodsCntList_003Ek__BackingField;

	private string _003CIconType_003Ek__BackingField;

	private bool _003CCanPurchas_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		private set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public int Price
	{
		get
		{
			return _003CPrice_003Ek__BackingField;
		}
		private set
		{
			_003CPrice_003Ek__BackingField = value;
		}
	}

	public int MoneyType
	{
		get
		{
			return _003CMoneyType_003Ek__BackingField;
		}
		private set
		{
			_003CMoneyType_003Ek__BackingField = value;
		}
	}

	public int TotalPurchaseLimit
	{
		get
		{
			return _003CTotalPurchaseLimit_003Ek__BackingField;
		}
		private set
		{
			_003CTotalPurchaseLimit_003Ek__BackingField = value;
		}
	}

	public int CurTotalPurchaseLimit
	{
		get
		{
			return _003CCurTotalPurchaseLimit_003Ek__BackingField;
		}
		private set
		{
			_003CCurTotalPurchaseLimit_003Ek__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		private set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string Desc
	{
		get
		{
			return _003CDesc_003Ek__BackingField;
		}
		private set
		{
			_003CDesc_003Ek__BackingField = value;
		}
	}

	public List<object> ItemGoodsIDList
	{
		get
		{
			return _003CItemGoodsIDList_003Ek__BackingField;
		}
		private set
		{
			_003CItemGoodsIDList_003Ek__BackingField = value;
		}
	}

	public List<object> ItemGoodsCntList
	{
		get
		{
			return _003CItemGoodsCntList_003Ek__BackingField;
		}
		private set
		{
			_003CItemGoodsCntList_003Ek__BackingField = value;
		}
	}

	public string IconType
	{
		get
		{
			return _003CIconType_003Ek__BackingField;
		}
		private set
		{
			_003CIconType_003Ek__BackingField = value;
		}
	}

	public bool CanPurchas
	{
		get
		{
			return _003CCanPurchas_003Ek__BackingField;
		}
		private set
		{
			_003CCanPurchas_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCShopItemRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

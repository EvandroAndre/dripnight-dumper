using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCShopShelfRepItem
{
	public const int PROP_ID_NAME = -72000;

	public const int PROP_ID_SHOPITEMLIST = -72001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnNameChangeEvent;

	public Action<List<object>> OnShopItemListChangeEvent;

	private string _003CName_003Ek__BackingField;

	private List<object> _003CShopItemList_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public List<object> ShopItemList
	{
		get
		{
			return _003CShopItemList_003Ek__BackingField;
		}
		private set
		{
			_003CShopItemList_003Ek__BackingField = value;
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

	public UGCShopShelfRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCShopRepItem
{
	public const int PROP_ID_NAME = -73000;

	public const int PROP_ID_SHOPSHELFLIST = -73001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnNameChangeEvent;

	public Action<List<object>> OnShopShelfListChangeEvent;

	private string _003CName_003Ek__BackingField;

	private List<object> _003CShopShelfList_003Ek__BackingField;

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

	public List<object> ShopShelfList
	{
		get
		{
			return _003CShopShelfList_003Ek__BackingField;
		}
		private set
		{
			_003CShopShelfList_003Ek__BackingField = value;
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

	public UGCShopRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

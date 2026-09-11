using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCUGCShopHudRepItem
{
	public const int PROP_ID_OPENSTATE = -80000;

	public const int PROP_ID_CLOSEFORBIDEN = -80001;

	public const int PROP_ID_BINDSHOPENTITY = -80002;

	public const int PROP_ID_BINDMONEYENTITY = -80003;

	public const int PROP_ID_BINDMONEYENTITYLIST = -80004;

	public const int PROP_ID_BINDWALLETENTITYID = -80005;

	public const int PROP_ID_REQUESTTYPE = -80006;

	public const int PROP_ID_ASKEDLIST = -80007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnCloseForbidenChangeEvent;

	public Action<string> OnBindShopEntityChangeEvent;

	public Action<string> OnBindMoneyEntityChangeEvent;

	public Action<List<object>> OnBindMoneyEntityListChangeEvent;

	public Action<string> OnBindWalletEntityIDChangeEvent;

	public Action<int> OnRequestTypeChangeEvent;

	public Action<List<object>> OnAskedListChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CCloseForbiden_003Ek__BackingField;

	private string _003CBindShopEntity_003Ek__BackingField;

	private string _003CBindMoneyEntity_003Ek__BackingField;

	private List<object> _003CBindMoneyEntityList_003Ek__BackingField;

	private string _003CBindWalletEntityID_003Ek__BackingField;

	private int _003CRequestType_003Ek__BackingField;

	private List<object> _003CAskedList_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public bool CloseForbiden
	{
		get
		{
			return _003CCloseForbiden_003Ek__BackingField;
		}
		private set
		{
			_003CCloseForbiden_003Ek__BackingField = value;
		}
	}

	public string BindShopEntity
	{
		get
		{
			return _003CBindShopEntity_003Ek__BackingField;
		}
		private set
		{
			_003CBindShopEntity_003Ek__BackingField = value;
		}
	}

	public string BindMoneyEntity
	{
		get
		{
			return _003CBindMoneyEntity_003Ek__BackingField;
		}
		private set
		{
			_003CBindMoneyEntity_003Ek__BackingField = value;
		}
	}

	public List<object> BindMoneyEntityList
	{
		get
		{
			return _003CBindMoneyEntityList_003Ek__BackingField;
		}
		private set
		{
			_003CBindMoneyEntityList_003Ek__BackingField = value;
		}
	}

	public string BindWalletEntityID
	{
		get
		{
			return _003CBindWalletEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CBindWalletEntityID_003Ek__BackingField = value;
		}
	}

	public int RequestType
	{
		get
		{
			return _003CRequestType_003Ek__BackingField;
		}
		private set
		{
			_003CRequestType_003Ek__BackingField = value;
		}
	}

	public List<object> AskedList
	{
		get
		{
			return _003CAskedList_003Ek__BackingField;
		}
		private set
		{
			_003CAskedList_003Ek__BackingField = value;
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

	public UGCUGCShopHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

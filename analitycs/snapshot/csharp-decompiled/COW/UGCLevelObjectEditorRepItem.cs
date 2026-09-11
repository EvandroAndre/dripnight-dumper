using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLevelObjectEditorRepItem
{
	public const int PROP_ID_SHOPITEMID = -16005;

	public const int PROP_ID_SHOPITEMVERSION = -16006;

	public const int PROP_ID_EDITSTATE = -16007;

	private UGCEntityDataStore _repDataMgr;

	public Action<long> OnShopItemIDChangeEvent;

	public Action<int> OnShopItemVersionChangeEvent;

	public Action<int> OnEditStateChangeEvent;

	private long _003CShopItemID_003Ek__BackingField;

	private int _003CShopItemVersion_003Ek__BackingField;

	private int _003CEditState_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public long ShopItemID
	{
		get
		{
			return _003CShopItemID_003Ek__BackingField;
		}
		private set
		{
			_003CShopItemID_003Ek__BackingField = value;
		}
	}

	public int ShopItemVersion
	{
		get
		{
			return _003CShopItemVersion_003Ek__BackingField;
		}
		private set
		{
			_003CShopItemVersion_003Ek__BackingField = value;
		}
	}

	public int EditState
	{
		get
		{
			return _003CEditState_003Ek__BackingField;
		}
		private set
		{
			_003CEditState_003Ek__BackingField = value;
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

	public UGCLevelObjectEditorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

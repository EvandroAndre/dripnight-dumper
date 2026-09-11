using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMoneyRepItem
{
	public const int PROP_ID_TYPE = -89000;

	public const int PROP_ID_COUNT = -89001;

	public const int PROP_ID_MONEYICON = -89002;

	public const int PROP_ID_MONEYICONCOLOR = -89003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnTypeChangeEvent;

	public Action<float> OnCountChangeEvent;

	public Action<string> OnMoneyIconChangeEvent;

	public Action<int> OnMoneyIconColorChangeEvent;

	private int _003CType_003Ek__BackingField;

	private float _003CCount_003Ek__BackingField;

	private string _003CMoneyIcon_003Ek__BackingField;

	private int _003CMoneyIconColor_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		private set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public float Count
	{
		get
		{
			return _003CCount_003Ek__BackingField;
		}
		private set
		{
			_003CCount_003Ek__BackingField = value;
		}
	}

	public string MoneyIcon
	{
		get
		{
			return _003CMoneyIcon_003Ek__BackingField;
		}
		private set
		{
			_003CMoneyIcon_003Ek__BackingField = value;
		}
	}

	public int MoneyIconColor
	{
		get
		{
			return _003CMoneyIconColor_003Ek__BackingField;
		}
		private set
		{
			_003CMoneyIconColor_003Ek__BackingField = value;
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

	public UGCMoneyRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCoinGeneratorRepItem
{
	public const int PROP_ID_MONEYTYPE = -95000;

	public const int PROP_ID_COUNT = -95001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMoneyTypeChangeEvent;

	public Action<float> OnCountChangeEvent;

	private int _003CMoneyType_003Ek__BackingField;

	private float _003CCount_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public UGCCoinGeneratorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

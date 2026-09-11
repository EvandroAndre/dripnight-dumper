using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCVendingMachineRepItem
{
	public const int PROP_ID_BINDSHOP = -61000;

	public const int PROP_ID_TRIGGERRADIUS = -61001;

	public const int PROP_ID_MODELSHOW = -61002;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnBindShopChangeEvent;

	public Action<float> OnTriggerRadiusChangeEvent;

	public Action<bool> OnModelShowChangeEvent;

	private string _003CBindShop_003Ek__BackingField;

	private float _003CTriggerRadius_003Ek__BackingField;

	private bool _003CModelShow_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string BindShop
	{
		get
		{
			return _003CBindShop_003Ek__BackingField;
		}
		private set
		{
			_003CBindShop_003Ek__BackingField = value;
		}
	}

	public float TriggerRadius
	{
		get
		{
			return _003CTriggerRadius_003Ek__BackingField;
		}
		private set
		{
			_003CTriggerRadius_003Ek__BackingField = value;
		}
	}

	public bool ModelShow
	{
		get
		{
			return _003CModelShow_003Ek__BackingField;
		}
		private set
		{
			_003CModelShow_003Ek__BackingField = value;
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

	public UGCVendingMachineRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

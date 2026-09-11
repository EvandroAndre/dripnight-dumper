using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCVestRepItem
{
	public const int PROP_ID_LEVEL = -156000;

	public const int PROP_ID_DURABILITYMAX = -156001;

	public const int PROP_ID_DURABILITY = -156002;

	public const int PROP_ID_DAMAGEREDUCTIONFACTOR = -156003;

	public const int PROP_ID_DAMAGEREDUCTIONFACTOREXPLODE = -156004;

	public const int PROP_ID_COSTDURABILITY = -156005;

	public const int PROP_ID_CANDESTROY = -156006;

	public const int PROP_ID_OWNER = -156007;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnDurabilityMaxChangeEvent;

	public Action<int> OnDamageReductionFactorChangeEvent;

	public Action<int> OnDamageReductionFactorExplodeChangeEvent;

	public Action<bool> OnCostDurabilityChangeEvent;

	public Action<bool> OnCanDestroyChangeEvent;

	private int _003CDurabilityMax_003Ek__BackingField;

	private int _003CDamageReductionFactor_003Ek__BackingField;

	private int _003CDamageReductionFactorExplode_003Ek__BackingField;

	private bool _003CCostDurability_003Ek__BackingField;

	private bool _003CCanDestroy_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int DurabilityMax
	{
		get
		{
			return _003CDurabilityMax_003Ek__BackingField;
		}
		private set
		{
			_003CDurabilityMax_003Ek__BackingField = value;
		}
	}

	public int DamageReductionFactor
	{
		get
		{
			return _003CDamageReductionFactor_003Ek__BackingField;
		}
		private set
		{
			_003CDamageReductionFactor_003Ek__BackingField = value;
		}
	}

	public int DamageReductionFactorExplode
	{
		get
		{
			return _003CDamageReductionFactorExplode_003Ek__BackingField;
		}
		private set
		{
			_003CDamageReductionFactorExplode_003Ek__BackingField = value;
		}
	}

	public bool CostDurability
	{
		get
		{
			return _003CCostDurability_003Ek__BackingField;
		}
		private set
		{
			_003CCostDurability_003Ek__BackingField = value;
		}
	}

	public bool CanDestroy
	{
		get
		{
			return _003CCanDestroy_003Ek__BackingField;
		}
		private set
		{
			_003CCanDestroy_003Ek__BackingField = value;
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

	public UGCVestRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

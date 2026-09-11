using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCDoubleJumpShoesRepItem
{
	public const int PROP_ID_MAXJUMPHEIGHT = -204000;

	public const int PROP_ID_DAMAGEREDUCE = -204001;

	public const int PROP_ID_ENERGYRECOVERY = -204002;

	public const int PROP_ID_JUMPCONSUME = -204003;

	public const int PROP_ID_MAXENERGY = -204004;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnMaxJumpHeightChangeEvent;

	public Action<float> OnDamageReduceChangeEvent;

	public Action<int> OnEnergyRecoveryChangeEvent;

	public Action<int> OnJumpConsumeChangeEvent;

	public Action<int> OnMaxEnergyChangeEvent;

	private float _003CMaxJumpHeight_003Ek__BackingField;

	private float _003CDamageReduce_003Ek__BackingField;

	private int _003CEnergyRecovery_003Ek__BackingField;

	private int _003CJumpConsume_003Ek__BackingField;

	private int _003CMaxEnergy_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float MaxJumpHeight
	{
		get
		{
			return _003CMaxJumpHeight_003Ek__BackingField;
		}
		private set
		{
			_003CMaxJumpHeight_003Ek__BackingField = value;
		}
	}

	public float DamageReduce
	{
		get
		{
			return _003CDamageReduce_003Ek__BackingField;
		}
		private set
		{
			_003CDamageReduce_003Ek__BackingField = value;
		}
	}

	public int EnergyRecovery
	{
		get
		{
			return _003CEnergyRecovery_003Ek__BackingField;
		}
		private set
		{
			_003CEnergyRecovery_003Ek__BackingField = value;
		}
	}

	public int JumpConsume
	{
		get
		{
			return _003CJumpConsume_003Ek__BackingField;
		}
		private set
		{
			_003CJumpConsume_003Ek__BackingField = value;
		}
	}

	public int MaxEnergy
	{
		get
		{
			return _003CMaxEnergy_003Ek__BackingField;
		}
		private set
		{
			_003CMaxEnergy_003Ek__BackingField = value;
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

	public UGCDoubleJumpShoesRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

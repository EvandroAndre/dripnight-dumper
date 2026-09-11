using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPacemakerRepItem
{
	public const int PROP_ID_HEALTH = -355000;

	public const int PROP_ID_ENERGY = -355001;

	public const int PROP_ID_PRETIME = -355002;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnHealthChangeEvent;

	public Action<int> OnEnergyChangeEvent;

	public Action<int> OnPretimeChangeEvent;

	private int _003CHealth_003Ek__BackingField;

	private int _003CEnergy_003Ek__BackingField;

	private int _003CPretime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Health
	{
		get
		{
			return _003CHealth_003Ek__BackingField;
		}
		private set
		{
			_003CHealth_003Ek__BackingField = value;
		}
	}

	public int Energy
	{
		get
		{
			return _003CEnergy_003Ek__BackingField;
		}
		private set
		{
			_003CEnergy_003Ek__BackingField = value;
		}
	}

	public int Pretime
	{
		get
		{
			return _003CPretime_003Ek__BackingField;
		}
		private set
		{
			_003CPretime_003Ek__BackingField = value;
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

	public UGCPacemakerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

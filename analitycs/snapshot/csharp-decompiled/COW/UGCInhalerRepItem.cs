using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCInhalerRepItem
{
	public const int PROP_ID_ENERGY = -354000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnEnergyChangeEvent;

	private int _003CEnergy_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public UGCInhalerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

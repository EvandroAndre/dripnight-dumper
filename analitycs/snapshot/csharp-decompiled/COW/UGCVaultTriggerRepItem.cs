using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCVaultTriggerRepItem
{
	public const int PROP_ID_VAULTDISTANCE = -406000;

	public const int PROP_ID_VAULTHEIGHT = -406001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnVaultDistanceChangeEvent;

	public Action<float> OnVaultHeightChangeEvent;

	private float _003CVaultDistance_003Ek__BackingField;

	private float _003CVaultHeight_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float VaultDistance
	{
		get
		{
			return _003CVaultDistance_003Ek__BackingField;
		}
		private set
		{
			_003CVaultDistance_003Ek__BackingField = value;
		}
	}

	public float VaultHeight
	{
		get
		{
			return _003CVaultHeight_003Ek__BackingField;
		}
		private set
		{
			_003CVaultHeight_003Ek__BackingField = value;
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

	public UGCVaultTriggerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

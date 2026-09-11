using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCResetableEntityRepItem
{
	public const int PROP_ID_RESETPERROUND = -28000;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnResetPerRoundChangeEvent;

	private bool _003CResetPerRound_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool ResetPerRound
	{
		get
		{
			return _003CResetPerRound_003Ek__BackingField;
		}
		private set
		{
			_003CResetPerRound_003Ek__BackingField = value;
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

	public UGCResetableEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

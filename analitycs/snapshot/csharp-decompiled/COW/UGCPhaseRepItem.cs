using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPhaseRepItem
{
	public const int PROP_ID_PHASEINDEX = -25000;

	public const int PROP_ID_PHASESTARTTIME = -25001;

	public const int PROP_ID_PHASEENDTIME = -25002;

	public const int PROP_ID_PHASEDURATION = -25003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnPhaseIndexChangeEvent;

	public Action<int> OnPhaseEndTimeChangeEvent;

	private int _003CPhaseIndex_003Ek__BackingField;

	private int _003CPhaseEndTime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int PhaseIndex
	{
		get
		{
			return _003CPhaseIndex_003Ek__BackingField;
		}
		private set
		{
			_003CPhaseIndex_003Ek__BackingField = value;
		}
	}

	public int PhaseEndTime
	{
		get
		{
			return _003CPhaseEndTime_003Ek__BackingField;
		}
		private set
		{
			_003CPhaseEndTime_003Ek__BackingField = value;
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

	public UGCPhaseRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

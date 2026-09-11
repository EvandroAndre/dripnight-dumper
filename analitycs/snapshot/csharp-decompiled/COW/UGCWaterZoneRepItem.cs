using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCWaterZoneRepItem
{
	public const int PROP_ID_DECELERATIONRATIO = -201000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnDecelerationRatioChangeEvent;

	private int _003CDecelerationRatio_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int DecelerationRatio
	{
		get
		{
			return _003CDecelerationRatio_003Ek__BackingField;
		}
		private set
		{
			_003CDecelerationRatio_003Ek__BackingField = value;
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

	public UGCWaterZoneRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCRGBSplitFilterStyleRepItem
{
	public const int PROP_ID_SPLITOFFSET = -484000;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnSplitOffsetChangeEvent;

	private float _003CSplitOffset_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float SplitOffset
	{
		get
		{
			return _003CSplitOffset_003Ek__BackingField;
		}
		private set
		{
			_003CSplitOffset_003Ek__BackingField = value;
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

	public UGCRGBSplitFilterStyleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

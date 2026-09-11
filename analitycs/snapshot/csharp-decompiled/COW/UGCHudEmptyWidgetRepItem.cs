using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHudEmptyWidgetRepItem
{
	public const int PROP_ID_ALPHA = -38000;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAlphaChangeEvent;

	private float _003CAlpha_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Alpha
	{
		get
		{
			return _003CAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CAlpha_003Ek__BackingField = value;
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

	public UGCHudEmptyWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

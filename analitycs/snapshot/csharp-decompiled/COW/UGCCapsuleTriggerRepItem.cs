using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCapsuleTriggerRepItem
{
	public const int PROP_ID_RADIUS = -281000;

	public const int PROP_ID_HEIGHT = -281001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnRadiusChangeEvent;

	public Action<float> OnHeightChangeEvent;

	private float _003CRadius_003Ek__BackingField;

	private float _003CHeight_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Radius
	{
		get
		{
			return _003CRadius_003Ek__BackingField;
		}
		private set
		{
			_003CRadius_003Ek__BackingField = value;
		}
	}

	public float Height
	{
		get
		{
			return _003CHeight_003Ek__BackingField;
		}
		private set
		{
			_003CHeight_003Ek__BackingField = value;
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

	public UGCCapsuleTriggerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

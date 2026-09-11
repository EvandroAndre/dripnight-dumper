using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBasicSphereItemRepItem
{
	public const int PROP_ID_RADIUS = -179000;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnRadiusChangeEvent;

	private float _003CRadius_003Ek__BackingField;

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

	public UGCBasicSphereItemRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

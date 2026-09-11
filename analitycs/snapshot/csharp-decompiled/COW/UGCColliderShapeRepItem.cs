using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCColliderShapeRepItem
{
	public const int PROP_ID_COLLIDERID = -186000;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnColliderIDChangeEvent;

	private string _003CColliderID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string ColliderID
	{
		get
		{
			return _003CColliderID_003Ek__BackingField;
		}
		private set
		{
			_003CColliderID_003Ek__BackingField = value;
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

	public UGCColliderShapeRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

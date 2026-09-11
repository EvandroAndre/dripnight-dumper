using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSkeletonPartLookAtControllerRepItem
{
	public const int PROP_ID_CONTROLBONE = -448000;

	public const int PROP_ID_LOOKAT = -448001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnControlBoneChangeEvent;

	public Action<string> OnLookAtChangeEvent;

	private string _003CControlBone_003Ek__BackingField;

	private string _003CLookAt_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string ControlBone
	{
		get
		{
			return _003CControlBone_003Ek__BackingField;
		}
		private set
		{
			_003CControlBone_003Ek__BackingField = value;
		}
	}

	public string LookAt
	{
		get
		{
			return _003CLookAt_003Ek__BackingField;
		}
		private set
		{
			_003CLookAt_003Ek__BackingField = value;
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

	public UGCSkeletonPartLookAtControllerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

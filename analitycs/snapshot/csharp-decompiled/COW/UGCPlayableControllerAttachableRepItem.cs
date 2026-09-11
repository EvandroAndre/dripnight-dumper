using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayableControllerAttachableRepItem
{
	public const int PROP_ID_PLAYABLECONTROLLER = -446000;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnPlayableControllerChangeEvent;

	private string _003CPlayableController_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string PlayableController
	{
		get
		{
			return _003CPlayableController_003Ek__BackingField;
		}
		private set
		{
			_003CPlayableController_003Ek__BackingField = value;
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

	public UGCPlayableControllerAttachableRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

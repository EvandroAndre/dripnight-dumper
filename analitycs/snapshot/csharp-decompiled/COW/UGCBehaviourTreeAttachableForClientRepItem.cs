using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBehaviourTreeAttachableForClientRepItem
{
	public const int PROP_ID_BTREEID = -461000;

	public const int PROP_ID_TARGETTREE = -461001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnBTreeIDChangeEvent;

	public Action<string> OnTargetTreeChangeEvent;

	private string _003CBTreeID_003Ek__BackingField;

	private string _003CTargetTree_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string BTreeID
	{
		get
		{
			return _003CBTreeID_003Ek__BackingField;
		}
		private set
		{
			_003CBTreeID_003Ek__BackingField = value;
		}
	}

	public string TargetTree
	{
		get
		{
			return _003CTargetTree_003Ek__BackingField;
		}
		private set
		{
			_003CTargetTree_003Ek__BackingField = value;
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

	public UGCBehaviourTreeAttachableForClientRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAvatarAbleRepItem
{
	public const int PROP_ID_AVATARRESUUID = -327000;

	public const int PROP_ID_PARTVISABLEMASK1 = -327001;

	public const int PROP_ID_PARTVISABLEMASK2 = -327002;

	public const int PROP_ID_PARTVISABLEMASK3 = -327003;

	public const int PROP_ID_PARTVISABLEMASK4 = -327004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnAvatarResUUIDChangeEvent;

	public Action<int> OnPartVisableMask1ChangeEvent;

	public Action<int> OnPartVisableMask2ChangeEvent;

	public Action<int> OnPartVisableMask3ChangeEvent;

	public Action<int> OnPartVisableMask4ChangeEvent;

	private string _003CAvatarResUUID_003Ek__BackingField;

	private int _003CPartVisableMask1_003Ek__BackingField;

	private int _003CPartVisableMask2_003Ek__BackingField;

	private int _003CPartVisableMask3_003Ek__BackingField;

	private int _003CPartVisableMask4_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string AvatarResUUID
	{
		get
		{
			return _003CAvatarResUUID_003Ek__BackingField;
		}
		private set
		{
			_003CAvatarResUUID_003Ek__BackingField = value;
		}
	}

	public int PartVisableMask1
	{
		get
		{
			return _003CPartVisableMask1_003Ek__BackingField;
		}
		private set
		{
			_003CPartVisableMask1_003Ek__BackingField = value;
		}
	}

	public int PartVisableMask2
	{
		get
		{
			return _003CPartVisableMask2_003Ek__BackingField;
		}
		private set
		{
			_003CPartVisableMask2_003Ek__BackingField = value;
		}
	}

	public int PartVisableMask3
	{
		get
		{
			return _003CPartVisableMask3_003Ek__BackingField;
		}
		private set
		{
			_003CPartVisableMask3_003Ek__BackingField = value;
		}
	}

	public int PartVisableMask4
	{
		get
		{
			return _003CPartVisableMask4_003Ek__BackingField;
		}
		private set
		{
			_003CPartVisableMask4_003Ek__BackingField = value;
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

	public UGCAvatarAbleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

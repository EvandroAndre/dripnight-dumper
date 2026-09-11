using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCIconNotificationHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1029000;

	public const int PROP_ID_ICONSPRITENAME = -1029001;

	public const int PROP_ID_BGICONSPRITENAME = -1029002;

	public const int PROP_ID_DESCRIPTION = -1029003;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnIconSpriteNameChangeEvent;

	public Action<string> OnBgIconSpriteNameChangeEvent;

	public Action<string> OnDescriptionChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CIconSpriteName_003Ek__BackingField;

	private string _003CBgIconSpriteName_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public string IconSpriteName
	{
		get
		{
			return _003CIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CIconSpriteName_003Ek__BackingField = value;
		}
	}

	public string BgIconSpriteName
	{
		get
		{
			return _003CBgIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CBgIconSpriteName_003Ek__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		private set
		{
			_003CDescription_003Ek__BackingField = value;
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

	public UGCIconNotificationHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

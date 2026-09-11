using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCIdentityNotifyHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1041000;

	public const int PROP_ID_LOCSWITCH = -1041001;

	public const int PROP_ID_POSITION = -1041002;

	public const int PROP_ID_ICONSPRITE = -1041003;

	public const int PROP_ID_LABEL = -1041004;

	public const int PROP_ID_BGCOLOR = -1041005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<Vector3> OnPositionChangeEvent;

	public Action<string> OnIconSpriteChangeEvent;

	public Action<string> OnLabelChangeEvent;

	public Action<int> OnBGColorChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private Vector3 _003CPosition_003Ek__BackingField;

	private string _003CIconSprite_003Ek__BackingField;

	private string _003CLabel_003Ek__BackingField;

	private int _003CBGColor_003Ek__BackingField;

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

	public bool LocSwitch
	{
		get
		{
			return _003CLocSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CLocSwitch_003Ek__BackingField = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		private set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public string IconSprite
	{
		get
		{
			return _003CIconSprite_003Ek__BackingField;
		}
		private set
		{
			_003CIconSprite_003Ek__BackingField = value;
		}
	}

	public string Label
	{
		get
		{
			return _003CLabel_003Ek__BackingField;
		}
		private set
		{
			_003CLabel_003Ek__BackingField = value;
		}
	}

	public int BGColor
	{
		get
		{
			return _003CBGColor_003Ek__BackingField;
		}
		private set
		{
			_003CBGColor_003Ek__BackingField = value;
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

	public UGCIdentityNotifyHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCSkillButtonHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1045000;

	public const int PROP_ID_NAME = -1045001;

	public const int PROP_ID_ICONSPRITE = -1045002;

	public const int PROP_ID_ICONCOLOR = -1045003;

	public const int PROP_ID_SIZE = -1045004;

	public const int PROP_ID_LOCALPOSITION = -1045005;

	public const int PROP_ID_COUNT = -1045006;

	public const int PROP_ID_CDSTARTTIME = -1045007;

	public const int PROP_ID_CDDURATIONTIME = -1045008;

	public const int PROP_ID_GREY = -1045009;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnNameChangeEvent;

	public Action<string> OnIconSpriteChangeEvent;

	public Action<int> OnIconColorChangeEvent;

	public Action<int> OnSizeChangeEvent;

	public Action<Vector3> OnLocalPositionChangeEvent;

	public Action<int> OnCountChangeEvent;

	public Action<int> OnCDStartTimeChangeEvent;

	public Action<int> OnCDDurationTimeChangeEvent;

	public Action<bool> OnGreyChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CIconSprite_003Ek__BackingField;

	private int _003CIconColor_003Ek__BackingField;

	private int _003CSize_003Ek__BackingField;

	private Vector3 _003CLocalPosition_003Ek__BackingField;

	private int _003CCount_003Ek__BackingField;

	private int _003CCDStartTime_003Ek__BackingField;

	private int _003CCDDurationTime_003Ek__BackingField;

	private bool _003CGrey_003Ek__BackingField;

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

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		private set
		{
			_003CName_003Ek__BackingField = value;
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

	public int IconColor
	{
		get
		{
			return _003CIconColor_003Ek__BackingField;
		}
		private set
		{
			_003CIconColor_003Ek__BackingField = value;
		}
	}

	public int Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		private set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	public Vector3 LocalPosition
	{
		get
		{
			return _003CLocalPosition_003Ek__BackingField;
		}
		private set
		{
			_003CLocalPosition_003Ek__BackingField = value;
		}
	}

	public int Count
	{
		get
		{
			return _003CCount_003Ek__BackingField;
		}
		private set
		{
			_003CCount_003Ek__BackingField = value;
		}
	}

	public int CDStartTime
	{
		get
		{
			return _003CCDStartTime_003Ek__BackingField;
		}
		private set
		{
			_003CCDStartTime_003Ek__BackingField = value;
		}
	}

	public int CDDurationTime
	{
		get
		{
			return _003CCDDurationTime_003Ek__BackingField;
		}
		private set
		{
			_003CCDDurationTime_003Ek__BackingField = value;
		}
	}

	public bool Grey
	{
		get
		{
			return _003CGrey_003Ek__BackingField;
		}
		private set
		{
			_003CGrey_003Ek__BackingField = value;
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

	public UGCSkillButtonHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

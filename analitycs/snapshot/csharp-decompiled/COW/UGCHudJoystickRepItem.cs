using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudJoystickRepItem
{
	public const int PROP_ID_OFFSET = -389000;

	public const int PROP_ID_BACKGROUNDIMAGE = -389001;

	public const int PROP_ID_BACKGROUNDRADIUS = -389002;

	public const int PROP_ID_JOYSTICKCAPIMAGE = -389003;

	public const int PROP_ID_JOYSTICKCAPRADIUS = -389004;

	public const int PROP_ID_JOYSTICKCAPDRAGRADIUS = -389005;

	public const int PROP_ID_ARROWIMAGE = -389006;

	public const int PROP_ID_ARROWSIZE = -389007;

	public const int PROP_ID_ARROWOFFSET = -389008;

	public const int PROP_ID_ACTIVATEDALPHA = -389009;

	public const int PROP_ID_INACTIVATEDALPHA = -389010;

	public const int PROP_ID_DISABLECOLLIDER = -389011;

	private UGCEntityDataStore _repDataMgr;

	public Action<Vector2> OnOffsetChangeEvent;

	public Action<string> OnBackGroundImageChangeEvent;

	public Action<int> OnBackGroundRadiusChangeEvent;

	public Action<string> OnJoystickCapImageChangeEvent;

	public Action<int> OnJoystickCapRadiusChangeEvent;

	public Action<int> OnJoystickCapDragRadiusChangeEvent;

	public Action<string> OnArrowImageChangeEvent;

	public Action<Vector2> OnArrowSizeChangeEvent;

	public Action<int> OnArrowOffsetChangeEvent;

	public Action<float> OnActivatedAlphaChangeEvent;

	public Action<float> OnInactivatedAlphaChangeEvent;

	public Action<bool> OnDisableColliderChangeEvent;

	private Vector2 _003COffset_003Ek__BackingField;

	private string _003CBackGroundImage_003Ek__BackingField;

	private int _003CBackGroundRadius_003Ek__BackingField;

	private string _003CJoystickCapImage_003Ek__BackingField;

	private int _003CJoystickCapRadius_003Ek__BackingField;

	private int _003CJoystickCapDragRadius_003Ek__BackingField;

	private string _003CArrowImage_003Ek__BackingField;

	private Vector2 _003CArrowSize_003Ek__BackingField;

	private int _003CArrowOffset_003Ek__BackingField;

	private float _003CActivatedAlpha_003Ek__BackingField;

	private float _003CInactivatedAlpha_003Ek__BackingField;

	private bool _003CDisableCollider_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public Vector2 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public string BackGroundImage
	{
		get
		{
			return _003CBackGroundImage_003Ek__BackingField;
		}
		private set
		{
			_003CBackGroundImage_003Ek__BackingField = value;
		}
	}

	public int BackGroundRadius
	{
		get
		{
			return _003CBackGroundRadius_003Ek__BackingField;
		}
		private set
		{
			_003CBackGroundRadius_003Ek__BackingField = value;
		}
	}

	public string JoystickCapImage
	{
		get
		{
			return _003CJoystickCapImage_003Ek__BackingField;
		}
		private set
		{
			_003CJoystickCapImage_003Ek__BackingField = value;
		}
	}

	public int JoystickCapRadius
	{
		get
		{
			return _003CJoystickCapRadius_003Ek__BackingField;
		}
		private set
		{
			_003CJoystickCapRadius_003Ek__BackingField = value;
		}
	}

	public int JoystickCapDragRadius
	{
		get
		{
			return _003CJoystickCapDragRadius_003Ek__BackingField;
		}
		private set
		{
			_003CJoystickCapDragRadius_003Ek__BackingField = value;
		}
	}

	public string ArrowImage
	{
		get
		{
			return _003CArrowImage_003Ek__BackingField;
		}
		private set
		{
			_003CArrowImage_003Ek__BackingField = value;
		}
	}

	public Vector2 ArrowSize
	{
		get
		{
			return _003CArrowSize_003Ek__BackingField;
		}
		private set
		{
			_003CArrowSize_003Ek__BackingField = value;
		}
	}

	public int ArrowOffset
	{
		get
		{
			return _003CArrowOffset_003Ek__BackingField;
		}
		private set
		{
			_003CArrowOffset_003Ek__BackingField = value;
		}
	}

	public float ActivatedAlpha
	{
		get
		{
			return _003CActivatedAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CActivatedAlpha_003Ek__BackingField = value;
		}
	}

	public float InactivatedAlpha
	{
		get
		{
			return _003CInactivatedAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CInactivatedAlpha_003Ek__BackingField = value;
		}
	}

	public bool DisableCollider
	{
		get
		{
			return _003CDisableCollider_003Ek__BackingField;
		}
		private set
		{
			_003CDisableCollider_003Ek__BackingField = value;
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

	public UGCHudJoystickRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

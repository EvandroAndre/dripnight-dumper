using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHudToggleRepItem
{
	public const int PROP_ID_ALPHA = -352000;

	public const int PROP_ID_UNSELECTEDSPRITE = -352001;

	public const int PROP_ID_UNSELECTEDTYPE = -352002;

	public const int PROP_ID_UNSELECTEDCOLOR = -352003;

	public const int PROP_ID_SELECTEDSPRITE = -352004;

	public const int PROP_ID_SELECTEDTYPE = -352005;

	public const int PROP_ID_SELECTEDCOLOR = -352006;

	public const int PROP_ID_DISABLECOLLIDER = -352007;

	public const int PROP_ID_VALUE = -352008;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAlphaChangeEvent;

	public Action<string> OnUnSelectedSpriteChangeEvent;

	public Action<int> OnUnSelectedTypeChangeEvent;

	public Action<int> OnUnSelectedColorChangeEvent;

	public Action<string> OnSelectedSpriteChangeEvent;

	public Action<int> OnSelectedTypeChangeEvent;

	public Action<int> OnSelectedColorChangeEvent;

	public Action<bool> OnDisableColliderChangeEvent;

	public Action<bool> OnValueChangeEvent;

	private float _003CAlpha_003Ek__BackingField;

	private string _003CUnSelectedSprite_003Ek__BackingField;

	private int _003CUnSelectedType_003Ek__BackingField;

	private int _003CUnSelectedColor_003Ek__BackingField;

	private string _003CSelectedSprite_003Ek__BackingField;

	private int _003CSelectedType_003Ek__BackingField;

	private int _003CSelectedColor_003Ek__BackingField;

	private bool _003CDisableCollider_003Ek__BackingField;

	private bool _003CValue_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Alpha
	{
		get
		{
			return _003CAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CAlpha_003Ek__BackingField = value;
		}
	}

	public string UnSelectedSprite
	{
		get
		{
			return _003CUnSelectedSprite_003Ek__BackingField;
		}
		private set
		{
			_003CUnSelectedSprite_003Ek__BackingField = value;
		}
	}

	public int UnSelectedType
	{
		get
		{
			return _003CUnSelectedType_003Ek__BackingField;
		}
		private set
		{
			_003CUnSelectedType_003Ek__BackingField = value;
		}
	}

	public int UnSelectedColor
	{
		get
		{
			return _003CUnSelectedColor_003Ek__BackingField;
		}
		private set
		{
			_003CUnSelectedColor_003Ek__BackingField = value;
		}
	}

	public string SelectedSprite
	{
		get
		{
			return _003CSelectedSprite_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedSprite_003Ek__BackingField = value;
		}
	}

	public int SelectedType
	{
		get
		{
			return _003CSelectedType_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedType_003Ek__BackingField = value;
		}
	}

	public int SelectedColor
	{
		get
		{
			return _003CSelectedColor_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedColor_003Ek__BackingField = value;
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

	public bool Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		private set
		{
			_003CValue_003Ek__BackingField = value;
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

	public UGCHudToggleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

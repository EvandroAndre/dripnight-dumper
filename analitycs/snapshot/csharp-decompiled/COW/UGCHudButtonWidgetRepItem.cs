using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHudButtonWidgetRepItem
{
	public const int PROP_ID_SPRITENAME = -41000;

	public const int PROP_ID_COLOR = -41001;

	public const int PROP_ID_ALPHA = -41002;

	public const int PROP_ID_DISABLECOLOR = -41003;

	public const int PROP_ID_PRESSEDCOLOR = -41004;

	public const int PROP_ID_SPRITETYPE = -41005;

	public const int PROP_ID_ISFEBUTTON = -41006;

	public const int PROP_ID_PRESSEDSPRITE = -41007;

	public const int PROP_ID_PRESSEDSPRITETYPE = -41008;

	public const int PROP_ID_FLIPTYPE = -41009;

	public const int PROP_ID_CENTERINVISIBLE = -41010;

	public const int PROP_ID_FILLDIR = -41011;

	public const int PROP_ID_FILLAMOUNT = -41012;

	public const int PROP_ID_INVERTFILL = -41013;

	public const int PROP_ID_GRADIENT = -41014;

	public const int PROP_ID_GRADIENTTOP = -41015;

	public const int PROP_ID_GRADIENTBOTTOM = -41016;

	public const int PROP_ID_GRADIENTTOPALPHA = -41017;

	public const int PROP_ID_GRADIENTBOTTOMALPHA = -41018;

	public const int PROP_ID_DISABLECOLLIDER = -41019;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnSpriteNameChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<float> OnAlphaChangeEvent;

	public Action<int> OnDisableColorChangeEvent;

	public Action<int> OnPressedColorChangeEvent;

	public Action<int> OnSpriteTypeChangeEvent;

	public Action<bool> OnIsFEButtonChangeEvent;

	public Action<string> OnPressedSpriteChangeEvent;

	public Action<int> OnPressedSpriteTypeChangeEvent;

	public Action<int> OnFlipTypeChangeEvent;

	public Action<bool> OnCenterInvisibleChangeEvent;

	public Action<int> OnFillDirChangeEvent;

	public Action<float> OnFillAmountChangeEvent;

	public Action<bool> OnInvertFillChangeEvent;

	public Action<int> OnGradientChangeEvent;

	public Action<int> OnGradientTopChangeEvent;

	public Action<int> OnGradientBottomChangeEvent;

	public Action<float> OnGradientTopAlphaChangeEvent;

	public Action<float> OnGradientBottomAlphaChangeEvent;

	public Action<bool> OnDisableColliderChangeEvent;

	private string _003CSpriteName_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private float _003CAlpha_003Ek__BackingField;

	private int _003CDisableColor_003Ek__BackingField;

	private int _003CPressedColor_003Ek__BackingField;

	private int _003CSpriteType_003Ek__BackingField;

	private bool _003CIsFEButton_003Ek__BackingField;

	private string _003CPressedSprite_003Ek__BackingField;

	private int _003CPressedSpriteType_003Ek__BackingField;

	private int _003CFlipType_003Ek__BackingField;

	private bool _003CCenterInvisible_003Ek__BackingField;

	private int _003CFillDir_003Ek__BackingField;

	private float _003CFillAmount_003Ek__BackingField;

	private bool _003CInvertFill_003Ek__BackingField;

	private int _003CGradient_003Ek__BackingField;

	private int _003CGradientTop_003Ek__BackingField;

	private int _003CGradientBottom_003Ek__BackingField;

	private float _003CGradientTopAlpha_003Ek__BackingField;

	private float _003CGradientBottomAlpha_003Ek__BackingField;

	private bool _003CDisableCollider_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string SpriteName
	{
		get
		{
			return _003CSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CSpriteName_003Ek__BackingField = value;
		}
	}

	public int Color
	{
		get
		{
			return _003CColor_003Ek__BackingField;
		}
		private set
		{
			_003CColor_003Ek__BackingField = value;
		}
	}

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

	public int DisableColor
	{
		get
		{
			return _003CDisableColor_003Ek__BackingField;
		}
		private set
		{
			_003CDisableColor_003Ek__BackingField = value;
		}
	}

	public int PressedColor
	{
		get
		{
			return _003CPressedColor_003Ek__BackingField;
		}
		private set
		{
			_003CPressedColor_003Ek__BackingField = value;
		}
	}

	public int SpriteType
	{
		get
		{
			return _003CSpriteType_003Ek__BackingField;
		}
		private set
		{
			_003CSpriteType_003Ek__BackingField = value;
		}
	}

	public bool IsFEButton
	{
		get
		{
			return _003CIsFEButton_003Ek__BackingField;
		}
		private set
		{
			_003CIsFEButton_003Ek__BackingField = value;
		}
	}

	public string PressedSprite
	{
		get
		{
			return _003CPressedSprite_003Ek__BackingField;
		}
		private set
		{
			_003CPressedSprite_003Ek__BackingField = value;
		}
	}

	public int PressedSpriteType
	{
		get
		{
			return _003CPressedSpriteType_003Ek__BackingField;
		}
		private set
		{
			_003CPressedSpriteType_003Ek__BackingField = value;
		}
	}

	public int FlipType
	{
		get
		{
			return _003CFlipType_003Ek__BackingField;
		}
		private set
		{
			_003CFlipType_003Ek__BackingField = value;
		}
	}

	public bool CenterInvisible
	{
		get
		{
			return _003CCenterInvisible_003Ek__BackingField;
		}
		private set
		{
			_003CCenterInvisible_003Ek__BackingField = value;
		}
	}

	public int FillDir
	{
		get
		{
			return _003CFillDir_003Ek__BackingField;
		}
		private set
		{
			_003CFillDir_003Ek__BackingField = value;
		}
	}

	public float FillAmount
	{
		get
		{
			return _003CFillAmount_003Ek__BackingField;
		}
		private set
		{
			_003CFillAmount_003Ek__BackingField = value;
		}
	}

	public bool InvertFill
	{
		get
		{
			return _003CInvertFill_003Ek__BackingField;
		}
		private set
		{
			_003CInvertFill_003Ek__BackingField = value;
		}
	}

	public int Gradient
	{
		get
		{
			return _003CGradient_003Ek__BackingField;
		}
		private set
		{
			_003CGradient_003Ek__BackingField = value;
		}
	}

	public int GradientTop
	{
		get
		{
			return _003CGradientTop_003Ek__BackingField;
		}
		private set
		{
			_003CGradientTop_003Ek__BackingField = value;
		}
	}

	public int GradientBottom
	{
		get
		{
			return _003CGradientBottom_003Ek__BackingField;
		}
		private set
		{
			_003CGradientBottom_003Ek__BackingField = value;
		}
	}

	public float GradientTopAlpha
	{
		get
		{
			return _003CGradientTopAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CGradientTopAlpha_003Ek__BackingField = value;
		}
	}

	public float GradientBottomAlpha
	{
		get
		{
			return _003CGradientBottomAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CGradientBottomAlpha_003Ek__BackingField = value;
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

	public UGCHudButtonWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

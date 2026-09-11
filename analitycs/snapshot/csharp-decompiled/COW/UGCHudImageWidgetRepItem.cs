using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHudImageWidgetRepItem
{
	public const int PROP_ID_COLOR = -39000;

	public const int PROP_ID_SPRITENAME = -39001;

	public const int PROP_ID_ALPHA = -39002;

	public const int PROP_ID_SPRITEFLIP = -39003;

	public const int PROP_ID_SPRITETYPE = -39004;

	public const int PROP_ID_CENTERINVISIBLE = -39005;

	public const int PROP_ID_FILLDIR = -39006;

	public const int PROP_ID_FILLAMOUNT = -39007;

	public const int PROP_ID_INVERTFILL = -39008;

	public const int PROP_ID_GRADIENT = -39009;

	public const int PROP_ID_GRADIENTTOP = -39010;

	public const int PROP_ID_GRADIENTBOTTOM = -39011;

	public const int PROP_ID_GRADIENTTOPALPHA = -39012;

	public const int PROP_ID_GRADIENTBOTTOMALPHA = -39013;

	public const int PROP_ID_ISAPPLYANIMATION = -39014;

	public const int PROP_ID_ATLASID = -39015;

	public const int PROP_ID_FRAMERATE = -39016;

	public const int PROP_ID_LOOP = -39017;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnColorChangeEvent;

	public Action<string> OnSpriteNameChangeEvent;

	public Action<float> OnAlphaChangeEvent;

	public Action<int> OnSpriteFlipChangeEvent;

	public Action<int> OnSpriteTypeChangeEvent;

	public Action<bool> OnCenterInvisibleChangeEvent;

	public Action<int> OnFillDirChangeEvent;

	public Action<float> OnFillAmountChangeEvent;

	public Action<bool> OnInvertFillChangeEvent;

	public Action<int> OnGradientChangeEvent;

	public Action<int> OnGradientTopChangeEvent;

	public Action<int> OnGradientBottomChangeEvent;

	public Action<float> OnGradientTopAlphaChangeEvent;

	public Action<float> OnGradientBottomAlphaChangeEvent;

	public Action<bool> OnIsApplyAnimationChangeEvent;

	public Action<string> OnAtlasIDChangeEvent;

	public Action<int> OnFrameRateChangeEvent;

	public Action<bool> OnLoopChangeEvent;

	private int _003CColor_003Ek__BackingField;

	private string _003CSpriteName_003Ek__BackingField;

	private float _003CAlpha_003Ek__BackingField;

	private int _003CSpriteFlip_003Ek__BackingField;

	private int _003CSpriteType_003Ek__BackingField;

	private bool _003CCenterInvisible_003Ek__BackingField;

	private int _003CFillDir_003Ek__BackingField;

	private float _003CFillAmount_003Ek__BackingField;

	private bool _003CInvertFill_003Ek__BackingField;

	private int _003CGradient_003Ek__BackingField;

	private int _003CGradientTop_003Ek__BackingField;

	private int _003CGradientBottom_003Ek__BackingField;

	private float _003CGradientTopAlpha_003Ek__BackingField;

	private float _003CGradientBottomAlpha_003Ek__BackingField;

	private bool _003CIsApplyAnimation_003Ek__BackingField;

	private string _003CAtlasID_003Ek__BackingField;

	private int _003CFrameRate_003Ek__BackingField;

	private bool _003CLoop_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public int SpriteFlip
	{
		get
		{
			return _003CSpriteFlip_003Ek__BackingField;
		}
		private set
		{
			_003CSpriteFlip_003Ek__BackingField = value;
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

	public bool IsApplyAnimation
	{
		get
		{
			return _003CIsApplyAnimation_003Ek__BackingField;
		}
		private set
		{
			_003CIsApplyAnimation_003Ek__BackingField = value;
		}
	}

	public string AtlasID
	{
		get
		{
			return _003CAtlasID_003Ek__BackingField;
		}
		private set
		{
			_003CAtlasID_003Ek__BackingField = value;
		}
	}

	public int FrameRate
	{
		get
		{
			return _003CFrameRate_003Ek__BackingField;
		}
		private set
		{
			_003CFrameRate_003Ek__BackingField = value;
		}
	}

	public bool Loop
	{
		get
		{
			return _003CLoop_003Ek__BackingField;
		}
		private set
		{
			_003CLoop_003Ek__BackingField = value;
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

	public UGCHudImageWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

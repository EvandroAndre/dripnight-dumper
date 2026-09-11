using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudLabelWidgetRepItem
{
	public const int PROP_ID_COLOR = -40000;

	public const int PROP_ID_TEXT = -40001;

	public const int PROP_ID_ALPHA = -40002;

	public const int PROP_ID_LOCKEY = -40003;

	public const int PROP_ID_FONTSIZE = -40004;

	public const int PROP_ID_ALIGNMENT = -40005;

	public const int PROP_ID_ALIGNMENTVERTICAL = -40006;

	public const int PROP_ID_ISBOLD = -40007;

	public const int PROP_ID_ISITALIC = -40008;

	public const int PROP_ID_ISUNDERLINE = -40009;

	public const int PROP_ID_LINESPACING = -40010;

	public const int PROP_ID_OVERFLOW = -40011;

	public const int PROP_ID_FONTTYPE = -40012;

	public const int PROP_ID_ISAPPLYSHADOW = -40013;

	public const int PROP_ID_SHADOWCOLOR = -40014;

	public const int PROP_ID_SHADOWOFFSET = -40015;

	public const int PROP_ID_SHADOWALPHA = -40016;

	public const int PROP_ID_ISAPPLYOUTLINE = -40017;

	public const int PROP_ID_OUTLINECOLOR = -40018;

	public const int PROP_ID_OUTLINEALPHA = -40019;

	public const int PROP_ID_OUTLINEOFFSET = -40020;

	public const int PROP_ID_GRADIENT = -40021;

	public const int PROP_ID_GRADIENTTOP = -40022;

	public const int PROP_ID_GRADIENTBOTTOM = -40023;

	public const int PROP_ID_GRADIENTTOPALPHA = -40024;

	public const int PROP_ID_GRADIENTBOTTOMALPHA = -40025;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnColorChangeEvent;

	public Action<string> OnTextChangeEvent;

	public Action<float> OnAlphaChangeEvent;

	public Action<string> OnLocKeyChangeEvent;

	public Action<int> OnFontSizeChangeEvent;

	public Action<int> OnAlignmentChangeEvent;

	public Action<int> OnAlignmentVerticalChangeEvent;

	public Action<bool> OnIsBoldChangeEvent;

	public Action<bool> OnIsItalicChangeEvent;

	public Action<bool> OnIsUnderlineChangeEvent;

	public Action<float> OnLineSpacingChangeEvent;

	public Action<int> OnOverflowChangeEvent;

	public Action<string> OnFontTypeChangeEvent;

	public Action<bool> OnIsApplyShadowChangeEvent;

	public Action<int> OnShadowColorChangeEvent;

	public Action<Vector2> OnShadowOffsetChangeEvent;

	public Action<float> OnShadowAlphaChangeEvent;

	public Action<bool> OnIsApplyOutlineChangeEvent;

	public Action<int> OnOutlineColorChangeEvent;

	public Action<float> OnOutlineAlphaChangeEvent;

	public Action<float> OnOutlineOffsetChangeEvent;

	public Action<int> OnGradientChangeEvent;

	public Action<int> OnGradientTopChangeEvent;

	public Action<int> OnGradientBottomChangeEvent;

	public Action<float> OnGradientTopAlphaChangeEvent;

	public Action<float> OnGradientBottomAlphaChangeEvent;

	private int _003CColor_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private float _003CAlpha_003Ek__BackingField;

	private string _003CLocKey_003Ek__BackingField;

	private int _003CFontSize_003Ek__BackingField;

	private int _003CAlignment_003Ek__BackingField;

	private int _003CAlignmentVertical_003Ek__BackingField;

	private bool _003CIsBold_003Ek__BackingField;

	private bool _003CIsItalic_003Ek__BackingField;

	private bool _003CIsUnderline_003Ek__BackingField;

	private float _003CLineSpacing_003Ek__BackingField;

	private int _003COverflow_003Ek__BackingField;

	private string _003CFontType_003Ek__BackingField;

	private bool _003CIsApplyShadow_003Ek__BackingField;

	private int _003CShadowColor_003Ek__BackingField;

	private Vector2 _003CShadowOffset_003Ek__BackingField;

	private float _003CShadowAlpha_003Ek__BackingField;

	private bool _003CIsApplyOutline_003Ek__BackingField;

	private int _003COutlineColor_003Ek__BackingField;

	private float _003COutlineAlpha_003Ek__BackingField;

	private float _003COutlineOffset_003Ek__BackingField;

	private int _003CGradient_003Ek__BackingField;

	private int _003CGradientTop_003Ek__BackingField;

	private int _003CGradientBottom_003Ek__BackingField;

	private float _003CGradientTopAlpha_003Ek__BackingField;

	private float _003CGradientBottomAlpha_003Ek__BackingField;

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

	public string Text
	{
		get
		{
			return _003CText_003Ek__BackingField;
		}
		private set
		{
			_003CText_003Ek__BackingField = value;
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

	public string LocKey
	{
		get
		{
			return _003CLocKey_003Ek__BackingField;
		}
		private set
		{
			_003CLocKey_003Ek__BackingField = value;
		}
	}

	public int FontSize
	{
		get
		{
			return _003CFontSize_003Ek__BackingField;
		}
		private set
		{
			_003CFontSize_003Ek__BackingField = value;
		}
	}

	public int Alignment
	{
		get
		{
			return _003CAlignment_003Ek__BackingField;
		}
		private set
		{
			_003CAlignment_003Ek__BackingField = value;
		}
	}

	public int AlignmentVertical
	{
		get
		{
			return _003CAlignmentVertical_003Ek__BackingField;
		}
		private set
		{
			_003CAlignmentVertical_003Ek__BackingField = value;
		}
	}

	public bool IsBold
	{
		get
		{
			return _003CIsBold_003Ek__BackingField;
		}
		private set
		{
			_003CIsBold_003Ek__BackingField = value;
		}
	}

	public bool IsItalic
	{
		get
		{
			return _003CIsItalic_003Ek__BackingField;
		}
		private set
		{
			_003CIsItalic_003Ek__BackingField = value;
		}
	}

	public bool IsUnderline
	{
		get
		{
			return _003CIsUnderline_003Ek__BackingField;
		}
		private set
		{
			_003CIsUnderline_003Ek__BackingField = value;
		}
	}

	public float LineSpacing
	{
		get
		{
			return _003CLineSpacing_003Ek__BackingField;
		}
		private set
		{
			_003CLineSpacing_003Ek__BackingField = value;
		}
	}

	public int Overflow
	{
		get
		{
			return _003COverflow_003Ek__BackingField;
		}
		private set
		{
			_003COverflow_003Ek__BackingField = value;
		}
	}

	public string FontType
	{
		get
		{
			return _003CFontType_003Ek__BackingField;
		}
		private set
		{
			_003CFontType_003Ek__BackingField = value;
		}
	}

	public bool IsApplyShadow
	{
		get
		{
			return _003CIsApplyShadow_003Ek__BackingField;
		}
		private set
		{
			_003CIsApplyShadow_003Ek__BackingField = value;
		}
	}

	public int ShadowColor
	{
		get
		{
			return _003CShadowColor_003Ek__BackingField;
		}
		private set
		{
			_003CShadowColor_003Ek__BackingField = value;
		}
	}

	public Vector2 ShadowOffset
	{
		get
		{
			return _003CShadowOffset_003Ek__BackingField;
		}
		private set
		{
			_003CShadowOffset_003Ek__BackingField = value;
		}
	}

	public float ShadowAlpha
	{
		get
		{
			return _003CShadowAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CShadowAlpha_003Ek__BackingField = value;
		}
	}

	public bool IsApplyOutline
	{
		get
		{
			return _003CIsApplyOutline_003Ek__BackingField;
		}
		private set
		{
			_003CIsApplyOutline_003Ek__BackingField = value;
		}
	}

	public int OutlineColor
	{
		get
		{
			return _003COutlineColor_003Ek__BackingField;
		}
		private set
		{
			_003COutlineColor_003Ek__BackingField = value;
		}
	}

	public float OutlineAlpha
	{
		get
		{
			return _003COutlineAlpha_003Ek__BackingField;
		}
		private set
		{
			_003COutlineAlpha_003Ek__BackingField = value;
		}
	}

	public float OutlineOffset
	{
		get
		{
			return _003COutlineOffset_003Ek__BackingField;
		}
		private set
		{
			_003COutlineOffset_003Ek__BackingField = value;
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

	public UGCHudLabelWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

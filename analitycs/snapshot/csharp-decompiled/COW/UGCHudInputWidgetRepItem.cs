using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHudInputWidgetRepItem
{
	public const int PROP_ID_DEFAULTTEXT = -42000;

	public const int PROP_ID_ACTIVETEXT = -42001;

	public const int PROP_ID_FONTSIZE = -42002;

	public const int PROP_ID_ALIGNMENT = -42003;

	public const int PROP_ID_ALIGNMENTVERTICAL = -42004;

	public const int PROP_ID_ISBOLD = -42005;

	public const int PROP_ID_ISITALIC = -42006;

	public const int PROP_ID_ISUNDERLINE = -42007;

	public const int PROP_ID_LINESPACING = -42008;

	public const int PROP_ID_WORDWRAP = -42009;

	public const int PROP_ID_MAXLENGTH = -42010;

	public const int PROP_ID_TRANSITIONTYPE = -42011;

	public const int PROP_ID_LABELCOLOR = -42012;

	public const int PROP_ID_NORMALCOLOR = -42013;

	public const int PROP_ID_PRESSEDCOLOR = -42014;

	public const int PROP_ID_DISABLECOLOR = -42015;

	public const int PROP_ID_LOCKEY = -42016;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnDefaultTextChangeEvent;

	public Action<string> OnActiveTextChangeEvent;

	public Action<int> OnFontSizeChangeEvent;

	public Action<int> OnAlignmentChangeEvent;

	public Action<int> OnAlignmentVerticalChangeEvent;

	public Action<bool> OnIsBoldChangeEvent;

	public Action<bool> OnIsItalicChangeEvent;

	public Action<bool> OnIsUnderlineChangeEvent;

	public Action<float> OnLineSpacingChangeEvent;

	public Action<int> OnWordWrapChangeEvent;

	public Action<int> OnMaxLengthChangeEvent;

	public Action<int> OnTransitionTypeChangeEvent;

	public Action<int> OnLabelColorChangeEvent;

	public Action<int> OnNormalColorChangeEvent;

	public Action<int> OnPressedColorChangeEvent;

	public Action<int> OnDisableColorChangeEvent;

	public Action<string> OnLocKeyChangeEvent;

	private string _003CDefaultText_003Ek__BackingField;

	private string _003CActiveText_003Ek__BackingField;

	private int _003CFontSize_003Ek__BackingField;

	private int _003CAlignment_003Ek__BackingField;

	private int _003CAlignmentVertical_003Ek__BackingField;

	private bool _003CIsBold_003Ek__BackingField;

	private bool _003CIsItalic_003Ek__BackingField;

	private bool _003CIsUnderline_003Ek__BackingField;

	private float _003CLineSpacing_003Ek__BackingField;

	private int _003CWordWrap_003Ek__BackingField;

	private int _003CMaxLength_003Ek__BackingField;

	private int _003CTransitionType_003Ek__BackingField;

	private int _003CLabelColor_003Ek__BackingField;

	private int _003CNormalColor_003Ek__BackingField;

	private int _003CPressedColor_003Ek__BackingField;

	private int _003CDisableColor_003Ek__BackingField;

	private string _003CLocKey_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string DefaultText
	{
		get
		{
			return _003CDefaultText_003Ek__BackingField;
		}
		private set
		{
			_003CDefaultText_003Ek__BackingField = value;
		}
	}

	public string ActiveText
	{
		get
		{
			return _003CActiveText_003Ek__BackingField;
		}
		private set
		{
			_003CActiveText_003Ek__BackingField = value;
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

	public int WordWrap
	{
		get
		{
			return _003CWordWrap_003Ek__BackingField;
		}
		private set
		{
			_003CWordWrap_003Ek__BackingField = value;
		}
	}

	public int MaxLength
	{
		get
		{
			return _003CMaxLength_003Ek__BackingField;
		}
		private set
		{
			_003CMaxLength_003Ek__BackingField = value;
		}
	}

	public int TransitionType
	{
		get
		{
			return _003CTransitionType_003Ek__BackingField;
		}
		private set
		{
			_003CTransitionType_003Ek__BackingField = value;
		}
	}

	public int LabelColor
	{
		get
		{
			return _003CLabelColor_003Ek__BackingField;
		}
		private set
		{
			_003CLabelColor_003Ek__BackingField = value;
		}
	}

	public int NormalColor
	{
		get
		{
			return _003CNormalColor_003Ek__BackingField;
		}
		private set
		{
			_003CNormalColor_003Ek__BackingField = value;
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

	public UGCHudInputWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

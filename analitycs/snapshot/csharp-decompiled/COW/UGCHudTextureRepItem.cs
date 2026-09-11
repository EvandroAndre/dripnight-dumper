using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudTextureRepItem
{
	public const int PROP_ID_TEXTURENAME = -316000;

	public const int PROP_ID_SHADERNAME = -316001;

	public const int PROP_ID_UVRECTXY = -316002;

	public const int PROP_ID_UVRECTWH = -316003;

	public const int PROP_ID_FILLTYPE = -316004;

	public const int PROP_ID_BORDERLR = -316005;

	public const int PROP_ID_BORDERTB = -316006;

	public const int PROP_ID_CENTERINVISIBLE = -316007;

	public const int PROP_ID_FILLDIR = -316008;

	public const int PROP_ID_FILLAMOUNT = -316009;

	public const int PROP_ID_INVERTFILL = -316010;

	public const int PROP_ID_FLIP = -316011;

	public const int PROP_ID_COLOR = -316012;

	public const int PROP_ID_GRADIENT = -316013;

	public const int PROP_ID_GRADIENTTOP = -316014;

	public const int PROP_ID_GRADIENTBOTTOM = -316015;

	public const int PROP_ID_ALPHA = -316016;

	public const int PROP_ID_GRADIENTTOPALPHA = -316017;

	public const int PROP_ID_GRADIENTBOTTOMALPHA = -316018;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTextureNameChangeEvent;

	public Action<string> OnShaderNameChangeEvent;

	public Action<Vector2> OnUVRectXYChangeEvent;

	public Action<Vector2> OnUVRectWHChangeEvent;

	public Action<int> OnFillTypeChangeEvent;

	public Action<Vector2> OnBorderLRChangeEvent;

	public Action<Vector2> OnBorderTBChangeEvent;

	public Action<bool> OnCenterInvisibleChangeEvent;

	public Action<int> OnFillDirChangeEvent;

	public Action<float> OnFillAmountChangeEvent;

	public Action<bool> OnInvertFillChangeEvent;

	public Action<int> OnFlipChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<int> OnGradientChangeEvent;

	public Action<int> OnGradientTopChangeEvent;

	public Action<int> OnGradientBottomChangeEvent;

	public Action<float> OnAlphaChangeEvent;

	public Action<float> OnGradientTopAlphaChangeEvent;

	public Action<float> OnGradientBottomAlphaChangeEvent;

	private string _003CTextureName_003Ek__BackingField;

	private string _003CShaderName_003Ek__BackingField;

	private Vector2 _003CUVRectXY_003Ek__BackingField;

	private Vector2 _003CUVRectWH_003Ek__BackingField;

	private int _003CFillType_003Ek__BackingField;

	private Vector2 _003CBorderLR_003Ek__BackingField;

	private Vector2 _003CBorderTB_003Ek__BackingField;

	private bool _003CCenterInvisible_003Ek__BackingField;

	private int _003CFillDir_003Ek__BackingField;

	private float _003CFillAmount_003Ek__BackingField;

	private bool _003CInvertFill_003Ek__BackingField;

	private int _003CFlip_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private int _003CGradient_003Ek__BackingField;

	private int _003CGradientTop_003Ek__BackingField;

	private int _003CGradientBottom_003Ek__BackingField;

	private float _003CAlpha_003Ek__BackingField;

	private float _003CGradientTopAlpha_003Ek__BackingField;

	private float _003CGradientBottomAlpha_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string TextureName
	{
		get
		{
			return _003CTextureName_003Ek__BackingField;
		}
		private set
		{
			_003CTextureName_003Ek__BackingField = value;
		}
	}

	public string ShaderName
	{
		get
		{
			return _003CShaderName_003Ek__BackingField;
		}
		private set
		{
			_003CShaderName_003Ek__BackingField = value;
		}
	}

	public Vector2 UVRectXY
	{
		get
		{
			return _003CUVRectXY_003Ek__BackingField;
		}
		private set
		{
			_003CUVRectXY_003Ek__BackingField = value;
		}
	}

	public Vector2 UVRectWH
	{
		get
		{
			return _003CUVRectWH_003Ek__BackingField;
		}
		private set
		{
			_003CUVRectWH_003Ek__BackingField = value;
		}
	}

	public int FillType
	{
		get
		{
			return _003CFillType_003Ek__BackingField;
		}
		private set
		{
			_003CFillType_003Ek__BackingField = value;
		}
	}

	public Vector2 BorderLR
	{
		get
		{
			return _003CBorderLR_003Ek__BackingField;
		}
		private set
		{
			_003CBorderLR_003Ek__BackingField = value;
		}
	}

	public Vector2 BorderTB
	{
		get
		{
			return _003CBorderTB_003Ek__BackingField;
		}
		private set
		{
			_003CBorderTB_003Ek__BackingField = value;
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

	public int Flip
	{
		get
		{
			return _003CFlip_003Ek__BackingField;
		}
		private set
		{
			_003CFlip_003Ek__BackingField = value;
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

	public UGCHudTextureRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

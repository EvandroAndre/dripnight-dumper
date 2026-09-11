using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHUDSocialButtonWidgetRepItem
{
	public const int PROP_ID_PLAYER = -402000;

	public const int PROP_ID_FUNCTIONTYPE = -402001;

	public const int PROP_ID_BUTTONSTYLE = -402002;

	public const int PROP_ID_ALPHA = -402003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnPlayerChangeEvent;

	public Action<int> OnFunctionTypeChangeEvent;

	public Action<int> OnButtonStyleChangeEvent;

	public Action<float> OnAlphaChangeEvent;

	private string _003CPlayer_003Ek__BackingField;

	private int _003CFunctionType_003Ek__BackingField;

	private int _003CButtonStyle_003Ek__BackingField;

	private float _003CAlpha_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Player
	{
		get
		{
			return _003CPlayer_003Ek__BackingField;
		}
		private set
		{
			_003CPlayer_003Ek__BackingField = value;
		}
	}

	public int FunctionType
	{
		get
		{
			return _003CFunctionType_003Ek__BackingField;
		}
		private set
		{
			_003CFunctionType_003Ek__BackingField = value;
		}
	}

	public int ButtonStyle
	{
		get
		{
			return _003CButtonStyle_003Ek__BackingField;
		}
		private set
		{
			_003CButtonStyle_003Ek__BackingField = value;
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

	public UGCHUDSocialButtonWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

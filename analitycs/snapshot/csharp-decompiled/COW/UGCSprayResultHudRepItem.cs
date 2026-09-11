using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSprayResultHudRepItem
{
	public const int PROP_ID_LEFTCOLOR = -252000;

	public const int PROP_ID_LEFTICON = -252001;

	public const int PROP_ID_LEFTTEXT = -252002;

	public const int PROP_ID_LEFTSCORETEXT = -252003;

	public const int PROP_ID_RIGHTCOLOR = -252004;

	public const int PROP_ID_RIGHTICON = -252005;

	public const int PROP_ID_RIGHTTEXT = -252006;

	public const int PROP_ID_RIGHTSCORETEXT = -252007;

	public const int PROP_ID_PROGRESS = -252008;

	public const int PROP_ID_LOCSWITCH = -252009;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLeftColorChangeEvent;

	public Action<string> OnLeftIconChangeEvent;

	public Action<string> OnLeftTextChangeEvent;

	public Action<string> OnLeftScoreTextChangeEvent;

	public Action<int> OnRightColorChangeEvent;

	public Action<string> OnRightIconChangeEvent;

	public Action<string> OnRightTextChangeEvent;

	public Action<string> OnRightScoreTextChangeEvent;

	public Action<float> OnProgressChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	private int _003CLeftColor_003Ek__BackingField;

	private string _003CLeftIcon_003Ek__BackingField;

	private string _003CLeftText_003Ek__BackingField;

	private string _003CLeftScoreText_003Ek__BackingField;

	private int _003CRightColor_003Ek__BackingField;

	private string _003CRightIcon_003Ek__BackingField;

	private string _003CRightText_003Ek__BackingField;

	private string _003CRightScoreText_003Ek__BackingField;

	private float _003CProgress_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LeftColor
	{
		get
		{
			return _003CLeftColor_003Ek__BackingField;
		}
		private set
		{
			_003CLeftColor_003Ek__BackingField = value;
		}
	}

	public string LeftIcon
	{
		get
		{
			return _003CLeftIcon_003Ek__BackingField;
		}
		private set
		{
			_003CLeftIcon_003Ek__BackingField = value;
		}
	}

	public string LeftText
	{
		get
		{
			return _003CLeftText_003Ek__BackingField;
		}
		private set
		{
			_003CLeftText_003Ek__BackingField = value;
		}
	}

	public string LeftScoreText
	{
		get
		{
			return _003CLeftScoreText_003Ek__BackingField;
		}
		private set
		{
			_003CLeftScoreText_003Ek__BackingField = value;
		}
	}

	public int RightColor
	{
		get
		{
			return _003CRightColor_003Ek__BackingField;
		}
		private set
		{
			_003CRightColor_003Ek__BackingField = value;
		}
	}

	public string RightIcon
	{
		get
		{
			return _003CRightIcon_003Ek__BackingField;
		}
		private set
		{
			_003CRightIcon_003Ek__BackingField = value;
		}
	}

	public string RightText
	{
		get
		{
			return _003CRightText_003Ek__BackingField;
		}
		private set
		{
			_003CRightText_003Ek__BackingField = value;
		}
	}

	public string RightScoreText
	{
		get
		{
			return _003CRightScoreText_003Ek__BackingField;
		}
		private set
		{
			_003CRightScoreText_003Ek__BackingField = value;
		}
	}

	public float Progress
	{
		get
		{
			return _003CProgress_003Ek__BackingField;
		}
		private set
		{
			_003CProgress_003Ek__BackingField = value;
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

	public UGCSprayResultHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

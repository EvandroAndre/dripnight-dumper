using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCRoundInfoHudRepItem
{
	public const int PROP_ID_TITLE = -370000;

	public const int PROP_ID_SUBTITLE = -370001;

	public const int PROP_ID_BACKGROUNDCOLOR1 = -370002;

	public const int PROP_ID_BACKGROUNDCOLOR2 = -370003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTitleChangeEvent;

	public Action<string> OnSubTitleChangeEvent;

	public Action<int> OnBackgroundColor1ChangeEvent;

	public Action<int> OnBackgroundColor2ChangeEvent;

	private string _003CTitle_003Ek__BackingField;

	private string _003CSubTitle_003Ek__BackingField;

	private int _003CBackgroundColor1_003Ek__BackingField;

	private int _003CBackgroundColor2_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		private set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	public string SubTitle
	{
		get
		{
			return _003CSubTitle_003Ek__BackingField;
		}
		private set
		{
			_003CSubTitle_003Ek__BackingField = value;
		}
	}

	public int BackgroundColor1
	{
		get
		{
			return _003CBackgroundColor1_003Ek__BackingField;
		}
		private set
		{
			_003CBackgroundColor1_003Ek__BackingField = value;
		}
	}

	public int BackgroundColor2
	{
		get
		{
			return _003CBackgroundColor2_003Ek__BackingField;
		}
		private set
		{
			_003CBackgroundColor2_003Ek__BackingField = value;
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

	public UGCRoundInfoHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

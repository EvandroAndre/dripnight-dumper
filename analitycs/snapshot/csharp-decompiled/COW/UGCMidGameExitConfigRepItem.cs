using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMidGameExitConfigRepItem
{
	public const int PROP_ID_TITLE = -396000;

	public const int PROP_ID_CONTENT = -396001;

	public const int PROP_ID_OPTIONS = -396002;

	public const int PROP_ID_SHOWBACKGROUND = -396003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTitleChangeEvent;

	public Action<string> OnContentChangeEvent;

	public Action<List<object>> OnOptionsChangeEvent;

	public Action<bool> OnShowBackgroundChangeEvent;

	private string _003CTitle_003Ek__BackingField;

	private string _003CContent_003Ek__BackingField;

	private List<object> _003COptions_003Ek__BackingField;

	private bool _003CShowBackground_003Ek__BackingField;

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

	public string Content
	{
		get
		{
			return _003CContent_003Ek__BackingField;
		}
		private set
		{
			_003CContent_003Ek__BackingField = value;
		}
	}

	public List<object> Options
	{
		get
		{
			return _003COptions_003Ek__BackingField;
		}
		private set
		{
			_003COptions_003Ek__BackingField = value;
		}
	}

	public bool ShowBackground
	{
		get
		{
			return _003CShowBackground_003Ek__BackingField;
		}
		private set
		{
			_003CShowBackground_003Ek__BackingField = value;
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

	public UGCMidGameExitConfigRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

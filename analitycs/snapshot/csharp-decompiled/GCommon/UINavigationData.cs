using System;
using System.Collections.Generic;
using COW;

namespace GCommon;

public class UINavigationData
{
	private string m_Title;

	private bool m_ReuseCache;

	private int m_NavIndex;

	private Type m_ContentControllerType;

	private bool m_HideTopBar;

	public bool ShowNameEffect;

	public BadgeInfoLobby BadgeInfo;

	private List<object> m_WindowParam;

	private bool m_ShowAvatarWindow;

	private bool m_ShowAvatarPose;

	private bool m_ShowChatBtn;

	private bool m_ShowClanBtn;

	private bool m_ShowLobbySwitchBtn;

	private bool m_ShowHelpBtn;

	private bool _003CShowSettingInNaviPage_003Ek__BackingField;

	private bool m_ShowOpenAnim;

	private bool m_CanShowPrimeTips;

	private bool _003CDelayCreate_003Ek__BackingField;

	public bool CleanUnusedAssetsOnDestroy;

	private bool m_OnlyShowTopRightBtnGroup;

	public Type PreNavigationType;

	public bool ShowLobby2DObjects;

	public bool IsShowOptionDownloader;

	public bool IsNewCreated;

	public string Title
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool ReuseCache
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int NavIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Type ContentControllerType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HideTopBar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<object> WindowParam
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool ShowAvatarWindow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowAvatarPose
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowChatBtn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowClanBtn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowLobbySwitchBtn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowHelpBtn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowSettingInNaviPage
	{
		get
		{
			return _003CShowSettingInNaviPage_003Ek__BackingField;
		}
		set
		{
			_003CShowSettingInNaviPage_003Ek__BackingField = value;
		}
	}

	public bool ShowOpenAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanShowPrimeTips
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DelayCreate
	{
		get
		{
			return _003CDelayCreate_003Ek__BackingField;
		}
		set
		{
			_003CDelayCreate_003Ek__BackingField = value;
		}
	}

	public bool OnlyShowTopRightBtnGroup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UINavigationData()
	{
	}

	public UINavigationData(string customizeTitle)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UINavigationTopbarViewData
{
	public enum PropertyChangeName
	{
		Show,
		ShowProfile,
		ShowCoin,
		ShowOptionalDownload,
		ShowButtonGroup,
		ShowChatBtn,
		ShowNaviPage,
		Title,
		Profile_HeadClick,
		ButtonGroup_Help,
		ButtonGroup_Token1,
		ButtonGroup_Token2,
		ButtonGroup_GachaCoupons,
		CloseButtonSprite,
		CloseButtonBGActive,
		ChangeProfile,
		ShowClan,
		ShowPrimeTips,
		ShowLobbySwitchBtn
	}

	public class GotoTokenData
	{
		public ResourceID id;

		public int num;

		public bool timeLimit;

		public uint itemId;
	}

	internal class GotoTokenDetailData
	{
		public EInventory.AwardType tokenType;

		public uint tokenID;

		public string locKey;

		public bool hideAmount;

		public bool hideAmountIfZero;

		public EventDelegate.Callback onGotoBtnClick;

		public EventDelegate.Callback onConvertBtnClick;

		public string customizedSprite;

		public UIUtils.SpriteScaleType scaleType;

		public bool makePixelPerfect;

		public UITopButtonGotoTokenController.GotoIconStyle gotoIconStyle;

		public string tokenDescColorStr;

		public string tokenGotoIconColorStr;

		public bool hideTokenSprite;

		public bool UseStandardTokenSize;
	}

	public delegate void AddTopBarPageEntry(string pageIcon, string pageLocKey, Action onTopBarEntryClick);

	public delegate void UpdateTokenByIndexDelegate(int index, ResourceID id, int num, bool timeLimit = false, uint itemID = 0u);

	public delegate void UpdateGachaCouponDelegate(uint chestID);

	public delegate void UpdateDrawShopCouponDelegate(uint chestID);

	private bool show;

	public bool Binding;

	public Action<PropertyChangeName> PropertyChanged;

	public Action NaviPageReposition;

	public Action<ResourceID, ResourceID, string> UpdateGotoBtnShow;

	internal Action<GotoTokenDetailData> AddGotoTokenWithDetail;

	internal AddTopBarPageEntry AddGotoPageEntry;

	internal Action<bool> CloseAllGotoToken;

	internal Action<int, bool, bool> SetGotoTokenState;

	internal Func<int, UITopButtonGotoTokenController> GetGotoTokenByIndex;

	internal Func<UIWidget> GetGachaCouponGuideWidget;

	internal Func<UIWidget> GetGachaCouponIconsWidget;

	internal Func<UIButton> GetGachaCouponButton;

	public UpdateTokenByIndexDelegate UpdateTokenByIndex;

	public UpdateGachaCouponDelegate UpdateGachaCoupon;

	public UpdateDrawShopCouponDelegate UpdateDrawShopCoupon;

	public Dictionary<int, GotoTokenData> GotoTokenDataMap;

	internal List<GotoTokenDetailData> GotoTokenDetailDataList;

	internal List<bool> GotoTokenStateList;

	public Func<Type, UIBaseController> AddCustomControl;

	public Action<bool> OnlyShowRightBtnGroupVisible;

	private bool showChatBtn;

	private bool showNaviPage;

	private string title;

	private bool title_effect;

	private BadgeInfoLobby badgeInfo;

	private bool showProfile;

	private bool showCoins;

	private bool showOptionalDownload;

	private bool showClanTopBar;

	private bool showLobbySwitchBtn;

	private bool showButtonGroup;

	private bool profileHeadClick;

	private bool buttonGroupHelp;

	public bool ButtonGroupViewStateRoot;

	public bool ButtonGroupSetting;

	private bool buttonGroupToken1;

	private bool buttonGroupToken2;

	private bool buttonGroupGachaCoupons;

	private ulong changeProfile;

	public bool ButtonGroupGoto;

	public ResourceID ButtonGroupGotoSpriteId;

	public ResourceID ButtonGroupGotoTagId;

	public string ButtonGroupGotoLabel;

	public bool OnlyShowButtonGroup;

	public EClanTopBarShowState ClanTopBarShowState;

	private ResourceID m_CloseButtonSpriteID;

	private bool m_CloseButtonBGActive;

	private bool m_CanShowPrimeTips;

	public bool Show
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

	public bool ShowNaviPage
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

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

	public bool TitleEffect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BadgeInfoLobby BadgeInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool ShowProfile
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowCoins
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowOptionalDownload
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowClanTopBar
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

	public bool ShowButtonGroup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ProfileHeadClick
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ButtonGroupHelp
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ButtonGroupToken1
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ButtonGroupToken2
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ButtonGroupGachaCoupons
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong ChangeProfile
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public ResourceID CloseButtonSpriteID
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public bool CloseButtonBGActive
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

	public void OnlyShowTopRightBtnGroup()
	{
	}

	public void ShowProfileAndRightBtnGroup(ulong account)
	{
	}
}

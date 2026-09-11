using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIHudMatchResultItemBaseController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public UIHudMatchResultItemBaseController _003C_003E4__this;

		public uint gameMode;

		public uint matchMode;

		public ulong matchId;

		internal void _003COnGetMatchBlackListCount_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass181_0
	{
		public TeammateStats player;

		internal bool _003CSetMatchResultPlayerInfoData_003Eb__0(GuildWarPointParamDesc x)
		{
			return false;
		}
	}

	protected List<int> m_InfoTypeList;

	protected int[] m_InfoTypeForUGC;

	protected TeammateStats m_TeammateStats;

	protected TeamTotalStats m_TeamTotalStats;

	protected MatchStats m_MatchStats;

	protected MatchIncome m_MatchIncome;

	private bool m_ShowVisitorToHideLike;

	protected List<uint> m_ShowAttributes;

	private Action<List<uint>> m_ShowAttributeAction;

	protected List<IngameFeedbackData> m_IngameFeedbackDataList;

	protected List<GameObject> m_BadgeGameObjects;

	private ulong _003CTargetAccountID_003Ek__BackingField;

	protected string LockRegion;

	private BHGGAEEHJCO m_TargetPlayerID;

	private string m_TargetName;

	private uint m_HeadPic;

	private ulong m_MatchID;

	private uint m_GroupMode;

	private uint m_GameMode;

	private uint m_MatchMode;

	protected EMatchResultPageType m_PageType;

	protected bool m_HasBanner;

	public Func<ulong, ExtraPlayerDataForMatchResult> GetExtraPlayerDataForMatchResultDelegate;

	public Func<ulong, string, ExtraPlayerDataForMatchResult> GetExtraPlayerDataIncludingBotForMatchResultDelegate;

	private ExtraPlayerDataForMatchResult _003CExtraPlayerData_003Ek__BackingField;

	protected bool AutoShowAddFriendAfterLike;

	protected bool IsMvp;

	protected bool IsWin;

	protected bool IsShowToxic;

	protected UIButton m_VisitorBtn;

	protected UIButton m_AddFriendBtn;

	protected UIButton m_ReportBtn;

	protected UIButton m_BlockBtn;

	protected UIButton m_InviteBtn;

	protected GameObject m_TryInviteIcon;

	protected GameObject m_FinishInviteIcon;

	protected UILabel m_LikeNum;

	private GameObject m_LikeIcon;

	private UIButton m_ProfileBtn;

	private GameObject m_NormalRoot;

	private GameObject m_DataRoot;

	private GameObject m_FakeBg;

	private UIEffectSprite m_BannerBg;

	protected UIButton m_LikeBtn;

	private GameObject m_LikeVFX;

	private UIButton m_AvatarAttributeEntryBtn;

	private GameObject m_AddFriendTips;

	private UIButton m_TipsButton;

	private string m_TargetClientVersion;

	private uint m_TargetClientType;

	protected GameObject SelfBG;

	protected GameObject WinMVPGrade;

	protected GameObject FailMVPGrade;

	protected UILabel NormalGrade;

	protected UISprite FailMVPSprite;

	protected GameObject ToxicChecked;

	private PresenceInfo m_CachedTargetPresence;

	private ulong m_PendingInviteTargetAccountID;

	public ulong TargetAccountID
	{
		get
		{
			return _003CTargetAccountID_003Ek__BackingField;
		}
		protected set
		{
			_003CTargetAccountID_003Ek__BackingField = value;
		}
	}

	public ExtraPlayerDataForMatchResult ExtraPlayerData
	{
		get
		{
			return _003CExtraPlayerData_003Ek__BackingField;
		}
		protected set
		{
			_003CExtraPlayerData_003Ek__BackingField = value;
		}
	}

	public bool HasLike => false;

	protected UIButton VisitorBtn
	{
		set
		{
		}
	}

	protected UIButton AddFriendBtn
	{
		set
		{
		}
	}

	protected UIButton ReportBtn
	{
		set
		{
		}
	}

	protected UIButton BlockBtn
	{
		set
		{
		}
	}

	protected UIButton InviteBtn
	{
		set
		{
		}
	}

	protected GameObject TryInviteIcon
	{
		set
		{
		}
	}

	protected GameObject FinishInviteIcon
	{
		set
		{
		}
	}

	protected UILabel LikeNum
	{
		set
		{
		}
	}

	protected GameObject LikeIcon
	{
		set
		{
		}
	}

	protected UIButton ProfileBtn
	{
		set
		{
		}
	}

	protected GameObject NormalRoot
	{
		set
		{
		}
	}

	protected GameObject DataRoot
	{
		set
		{
		}
	}

	protected GameObject FakeBg
	{
		set
		{
		}
	}

	protected UIEffectSprite BannerBg
	{
		set
		{
		}
	}

	protected UIButton LikeBtn
	{
		set
		{
		}
	}

	protected GameObject LikeVFX
	{
		set
		{
		}
	}

	protected UIButton AvatarAttributeEntryBtn
	{
		set
		{
		}
	}

	protected GameObject AddFriendTips
	{
		set
		{
		}
	}

	protected UIButton TipsButton
	{
		set
		{
		}
	}

	public string TargetName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string TargetClientVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint TargetClientType
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint HeadPic
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public BHGGAEEHJCO TargetPlayerID
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		set
		{
		}
	}

	public void SetTeamTotalStats(TeamTotalStats value)
	{
	}

	public void SetInfoTypeList(List<int> list)
	{
	}

	public void SetInfoTypeList(int[] arr)
	{
	}

	public virtual void SetPlayerData(TeammateStats stats, bool single)
	{
	}

	public virtual void SetPlayerData(UGCPlayerStats stats, bool single)
	{
	}

	public void SetPlayerLikedCount(uint count)
	{
	}

	public bool HideLikeIcon()
	{
		return false;
	}

	public void ShowLikeIcon(bool show)
	{
	}

	public virtual void ShowAddFriendButton(bool show)
	{
	}

	public virtual void ShowReportButton(bool show)
	{
	}

	public virtual void ShowReportOrBlockButton(bool show)
	{
	}

	public virtual void ShowBlockButton(bool show)
	{
	}

	public virtual void ShowInviteButton(bool show)
	{
	}

	private int SortSpectator(SpectatorInteractionInfo a, SpectatorInteractionInfo b)
	{
		return 0;
	}

	public void InitShowVisitorToHideLike(uint gameMode, uint matchMode)
	{
	}

	public virtual void ShowVisitorContainer(bool show)
	{
	}

	public virtual void ShowLikeContainer(bool show)
	{
	}

	public virtual void ShowLike(bool show)
	{
	}

	public void ShowAvatarAttributeEntry(uint[] showAttributesArray, Action<List<uint>> OnClickAction)
	{
	}

	protected virtual void OnClickShowAvatarAttribute()
	{
	}

	public virtual void SetGradeInfo(bool isMVP, bool win, string gradeTxt = "", bool hideScroe = false, bool isToxic = false)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	public virtual void OnSetMatchData(MatchStats stats)
	{
	}

	public virtual void OnSetMatchIncome(MatchIncome income)
	{
	}

	public virtual void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	public void TryResetInviteStateIfCDExpired()
	{
	}

	protected virtual void UpdateBannerVisbility()
	{
	}

	protected virtual void UpdateBannerInfo(uint bannerID)
	{
	}

	protected virtual void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	protected void UpdateInfoData(UIHudMatchResultItemProgressBar bar, TeammateStats player, int index)
	{
	}

	protected void UpdateIconData(UISprite sprite, int index)
	{
	}

	protected void UpdateInfoData(UILabel infoTxt, TeammateStats player, int index)
	{
	}

	protected void UpdateInfoDataForUGC(UILabel label, int index, UGCPlayerStats playerStats)
	{
	}

	protected virtual void OnClickVisitorBtn()
	{
	}

	protected virtual void OnClickAddFriendBtn()
	{
	}

	protected virtual void OnClickBlockBtn()
	{
	}

	protected virtual void OnClickInviteBtn()
	{
	}

	private void RequestTargetPresenceAndInvite()
	{
	}

	private ulong[] GetAllPlayerAccountIds()
	{
		return null;
	}

	private void OnMatchResultInvitePresenceNtf(object[] args)
	{
	}

	private void ProcessInviteWithGroupId(ulong targetGroupId)
	{
	}

	private void ClickJoinGroup(ulong targetGroupId)
	{
	}

	private void ClickInvite()
	{
	}

	private void CreateGroupAndInvite(UIModelGroup modelGroup)
	{
	}

	private void SendSettlementInviteLog(int opType)
	{
	}

	protected virtual void OnProfileBtnClicked()
	{
	}

	protected virtual void OnClickReportBtn()
	{
	}

	protected virtual void OnClickTipsBtn()
	{
	}

	public void DisableAddFriendTipsExternal()
	{
	}

	public void OnClickLikeBtn(MatchLikeSource likeSource)
	{
	}

	protected virtual void SetIsSelf(bool self)
	{
	}

	protected virtual void OnReportCheatSent(object[] param)
	{
	}

	private void OnAddFriendRecommendClick(object[] param)
	{
	}

	private void OnAddMatchBlackList(object[] param)
	{
	}

	private void OnGetMatchBlackListCount(object[] param)
	{
	}

	public void BeforeScreenShot()
	{
	}

	public void SetReportData(ulong matchId, uint groupId, uint gameMode, uint matchMode)
	{
	}

	private void OnIngameAddFriendConfirmed(ulong accountId)
	{
	}

	public void SetMatchResultPlayerInfoData(UIHudMatchResultItemProgressBar bar, TeammateStats player, EMatchResultPlayerInfoType type)
	{
	}

	protected void BadgeBtnClick()
	{
	}

	public static void SetMatchResultPlayerInfoData(UILabel label, TeammateStats player, EMatchResultPlayerInfoType type, MatchIncome income = null)
	{
	}

	public virtual void CloseReportAndBlock()
	{
	}

	protected virtual void OnCreditReportInfoGet()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003Cset_LikeBtn_003Eb__82_0()
	{
	}

	private bool _003COnMatchResultInvitePresenceNtf_003Eb__160_0(PresenceInfo p)
	{
		return false;
	}

	private void _003CClickJoinGroup_003Eb__162_0()
	{
	}

	private void _003CClickInvite_003Eb__163_0()
	{
	}

	private void _003CCreateGroupAndInvite_003Eb__164_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

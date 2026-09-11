using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudTeammateItem : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<int, float> _003C_003E9__239_0;

		internal float _003CStartRescurProgressSequencer_003Eb__239_0(int step)
		{
			return 0f;
		}
	}

	protected const int KNOCK_INFO_WEAPON_OFFSET = 20;

	private const float BE_RESCURED_PROGRESS_UPDATE_INTERVAL = 0.1f;

	public UIWidget ThisWidget;

	public UILabel Name;

	public GameObject HPBarGO;

	public UISprite HP;

	public UISprite SP;

	public UISprite Mark;

	private int HPBarLength;

	public Transform PlayerMarkPos;

	public GameObject KillerGO;

	public UILabel TeamIndex;

	public UISprite Knockdown;

	public UISprite Offline;

	public UISprite DisFlag;

	public UISprite Vehicle;

	public UISprite VaultKey;

	public GameObject VoiceGO;

	public UISprite VoiceGOSprite;

	public GameObject QuickMsgGO;

	public GameObject MutedGO;

	public UISprite TeamParachuteIcon;

	public UISprite TeamGatherIcon;

	public GameObject ModeRelatedContainer;

	public UISprite ModeIcon;

	public GameObject ModeIconEffect;

	public UILabel ModeTxt;

	public VFXCreateHelper ModeVFXEffect;

	public UIGrid m_CelebrityGrid;

	public UISprite TrainingZoneIcon;

	public UISprite HeadBGSprite;

	public Transform NameTextAnchor;

	public UIGrid IconGrid;

	public GameObject WantedIcon;

	public UILabel Level;

	public UISprite ZombieLevel;

	public GameObject HealGunLiveEffect;

	public VFXCreateHelper VFF_Rescue;

	public UIWidget GridLastPos;

	public GameObject KnockInfo;

	public Animation KnockInfoAnimation;

	public UILabel KillStackTxt;

	public UILabel KillStackTxtVFX;

	public GameObject KillIconBg;

	public UISprite KnockInfoResult;

	public VFXCreateHelper BuySelfReviveVfx;

	public GameObject PendingReviveRoot;

	public UILabel PnedingReviveCountDownLabel;

	public GameObject UsingRevivePointIcon;

	public GameObject AceTeam;

	public TweenAlpha AceTeamIconTweenAlp;

	public TweenScale AceTeamIconTweenScale;

	public TweenScale AceTeamBgTweenScale;

	public VFXCreateHelper PlayerAchieveTeamAce;

	public VFXCreateHelper PlayerAchieverTeamAceWithKnockDown;

	public GameObject KingClown;

	public GameObject FeedbackContent;

	public UISprite FeedbackIcon;

	public UILabel FeedbackLabel;

	public GameObject RequestReviveGo;

	public TweenAlpha RequestReviveTweenAlpha;

	public TweenAlpha RequestReviveBgTweenAlpha;

	public TweenScale RequestReviveBgTweenScale;

	public UISprite Strop;

	public UISprite Slide;

	public UISprite WeRunWin;

	public UISprite PrivilegeIcon;

	public UISprite SFRoleplayIcon;

	public UISprite IIVSkillIcon;

	public UISprite IIVFloatingLandIcon;

	public GameObject IIVFloatingLandEffectRoot;

	public GameObject PrivilegeCon;

	public UISprite EighthYearIconSprite;

	public GameObject EighthYearStripEffectRoot;

	public UISprite BeReaperIcon;

	public UISprite InGulagIcon;

	public UISprite OnWLGP25IsLandIcon;

	public GameObject LandingFightProtectionRoot;

	public UISprite LandingFightProtectionProgressIcon;

	public GameObject ReviveBoxInteractingProgressRoot;

	public UISprite ReviveBoxInteractingProgressFg;

	public Transform ReviveBoxInteractingUIFXContainer;

	public GameObject ReviveBoxWaitingProgressRoot;

	public Transform ReviveBoxWaitingUIFXContainer;

	public UILabel ReviveBoxLimitTimes;

	public int TeamIndexNum;

	public BHGGAEEHJCO pID;

	public BHGGAEEHJCO TargetPlayerId;

	public ulong AccountId;

	private ETeammateState m_CurrentState;

	private UITimeLabelHelper m_CountDownLabel;

	private BitArrayBoolean ModeRelatedContainerShow;

	private const uint ADS1v1CountDown = 1u;

	private const uint ADS1v1BonusCountDown = 2u;

	private uint m_QuickMsgDelayHideID;

	private uint m_KnockDownIconDelayID;

	private uint m_AceTeamIconDelayID;

	private uint m_PlayerAceVfxDelayID;

	private uint m_FeedbackDelayID;

	private ResourceID m_CurrentShowFeedback;

	private string m_CurrentShowFeedbackLabel;

	private bool m_IsMute;

	private Animation m_ModeAnimation;

	private uint m_DelayModeIconHide;

	private bool m_IsBombNeedAnim;

	private bool m_UsingRevivePoint;

	private bool m_LandingFightProtectionCountDown;

	private bool healHintEffectShow;

	private UITimeLabelHelper m_PendingReviveCountDownHelper;

	private readonly Color NAME_COLOR_NORMAL;

	private readonly Color NAME_COLOR_DEADIND;

	private readonly Color NAME_COLOR_DEAD;

	private readonly Color TEAMINDEX_COLOR_DEAD;

	private uint m_RequestReviveDelayHideID;

	private VisualInstanceHolder m_PrivilegeVFXHolder;

	private DelayCallSequencer m_RescureProgressSequencer;

	private EventDispatcher m_RegisteredEventDispatcher;

	public GameObject kncokDownDeadVfx;

	private uint m_deadMaskDelayID;

	public UIWidget IconWidget;

	public UISprite BeRescuredProgress;

	private UISprite SunMoon_SunIcon;

	private UISprite SunMoon_MoonIcon;

	private VisualInstanceHolder m_FloatingLandEffect;

	private UIHudPlayerMarkIcon _PlayerMark;

	private const float ReviveBoxHighlightUIFXDuration = 1f;

	private VisualInstanceHolder m_UIFXReviveBox;

	private VisualInstanceHolder m_UIFXReviveBoxWaiting;

	private VisualInstanceHolder m_UIFXReviveBoxHighlight;

	private uint m_UIFXReviveBoxHighlightDelayID;

	private Animator m_UIFXReviveBoxWaitingAnimator;

	private float m_ReviveBoxWaitingProgress;

	private uint m_HideEighthYearStripEffectTicket;

	private static readonly Color KNOCKDOWN_COLOR_NORMAL;

	private static readonly Color KNOCKDOWN_COLOR_BLEED;

	private UIWidget[] m_KnockdownWidgetsCache;

	private bool m_HasLastKnockdownTint;

	private Color m_LastKnockdownTint;

	public ETeammateState CurrentState => ETeammateState.eNone;

	public UIHudPlayerMarkIcon PlayerMark => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void RegisterEvents()
	{
	}

	public void UnRegisterEvents()
	{
	}

	private void DoUnRegisterEvents(EventDispatcher dispatcher)
	{
	}

	public void ShowPlayerAceVFX()
	{
	}

	private void HidePlayerAceVFX()
	{
	}

	public void HidePlayerAceVFXInterrupt()
	{
	}

	private void OnRecvQuickChat(object[] data)
	{
	}

	public void Show(bool v)
	{
	}

	public void OnGridReposition()
	{
	}

	private void UpdateCelebrity(BadgeInfoInGame badgeInfoInGame, ulong userID)
	{
	}

	public void UpdateKingClownAndCelebrity(Player player)
	{
	}

	protected void OnEnable()
	{
	}

	public void SetVehicleIcon(Player p)
	{
	}

	public virtual void InitInfo(Player p)
	{
	}

	private void SetPlayerIndexInfo(int playerIndex, bool isSelf, byte teamId, BHGGAEEHJCO playerId)
	{
	}

	public virtual void InitInfo(MatchTeam.KMGBNNHDOHF p)
	{
	}

	public void OnKnockDownStateChanged(bool isDown, float ratio)
	{
	}

	public virtual void InitWithPlayerInfo(KMGBNNHDOHF playerInfo)
	{
	}

	public void ShowQuickMsg()
	{
	}

	public void HideQuickMsg()
	{
	}

	public void SetVoiceVisible(bool flag)
	{
	}

	public void SetMuteVisible(bool is_mute)
	{
	}

	public virtual void SetReviveInfo()
	{
	}

	public virtual void SetSkyInfo()
	{
	}

	public void SetMarkShow(bool show)
	{
	}

	public void SetTeammateState(ETeammateState nextState)
	{
	}

	private void SetDownOrDeadEffectWithDelay(float showSeconds, bool showDeadMaskAfterDelay)
	{
	}

	public void SetDisconnected(bool disconnected)
	{
	}

	public bool IsDisconnected()
	{
		return false;
	}

	private ETeammateState AdjustTeammateState(ETeammateState next)
	{
		return ETeammateState.eNone;
	}

	public virtual void OnHPChanged(Player p)
	{
	}

	public virtual void OnRevivePointStateChanged(Player p)
	{
	}

	protected virtual void InitModeRelatedInfo(Player p)
	{
	}

	private void InitModeRelatedInfo(KMGBNNHDOHF p)
	{
	}

	private void InitModeRelatedInfo(MatchTeam.KMGBNNHDOHF p)
	{
	}

	public void UpdateModeRelatedInfo(byte num)
	{
	}

	public void UpdateTrainingZoneIcon(byte val)
	{
	}

	public void UpdateBombModeBomb()
	{
	}

	public void UpdateBombModeIcon(uint dataId, uint itemCount)
	{
	}

	private void HideModeIcon()
	{
	}

	private void OnShowBombIconEffect(object[] data)
	{
	}

	public void UpdateADSMode1v1Info(object[] data)
	{
	}

	public void ShowADS1v1Winner(bool show)
	{
	}

	public void ShowModeRelatedEffect(bool show)
	{
	}

	private void Update()
	{
	}

	protected void BaseUpdate()
	{
	}

	private void UpdateReviveBoxProgress()
	{
	}

	private LevelReviveBox GetReviveBox()
	{
		return null;
	}

	private void EnsureReviveBoxWaitingUIFX()
	{
	}

	private void OnReviveBoxWaitingUIFXAttached(GameObject instance)
	{
	}

	private void RefreshReviveBoxLimitTimes(LevelReviveBox reviveBox)
	{
	}

	public void PlayReviveBoxHighlightUIFX(ResourceID resID)
	{
	}

	private void ReleaseReviveBoxHighlightUIFXByDelay()
	{
	}

	private void ReleaseReviveBoxHighlightUIFX()
	{
	}

	private void ReleaseReviveBoxUIFX()
	{
	}

	private void OnWantedIconShow(object[] data)
	{
	}

	public void OnLocalPlayerChangeWeapon(bool isHealGun)
	{
	}

	private void StartHealHintEffect()
	{
	}

	private void StopHealHintEffect()
	{
	}

	private bool CheckHpNeedShowHealHint(Player p)
	{
		return false;
	}

	private void CheckHealHintOnHpChange(Player p)
	{
	}

	public virtual void OnLevelChanged(Player p)
	{
	}

	public void OnRescue()
	{
	}

	public void OnChangeToFootball(bool flag)
	{
	}

	public void CheckVaultKeyCount(object[] data = null)
	{
	}

	public void CheckCanBuyRevive(object[] data = null)
	{
	}

	public void OnQuitRevive(object[] data = null)
	{
	}

	private bool IsNeedShowPendingReviveCountDown()
	{
		return false;
	}

	private void ProcessReviveCountDown(object[] data)
	{
	}

	private void DelayHideAceTeamIcon()
	{
	}

	public void OnKnockDownAndKill(object[] data)
	{
	}

	private void CloseKnockInfo()
	{
	}

	private void OnTeammateFeedbackShow(object[] data)
	{
	}

	private void ShowTeammateFeedback()
	{
	}

	private void DelayHideFeedbackIcon()
	{
	}

	private void OnTeammateRequestRevive(object[] data)
	{
	}

	private void PlayReviveSound(bool isFemale)
	{
	}

	private void PlayRequestReviveEffectOnce()
	{
	}

	private void StopRequestReviveEffect()
	{
	}

	public void SetIIVFloatingLandIcon(bool isOnIIVFloatingLand)
	{
	}

	public void SetEighthIcon(EEJDHGAIKDN iconType)
	{
	}

	public void RefreshIIVSkillIcon(uint id)
	{
	}

	public virtual void RefreshTeamParachuteIcon(CCIPIBCIIDA targetMode)
	{
	}

	public void OnBeReaper()
	{
	}

	private void SetReaperIconActive(bool active)
	{
	}

	private void DelayCallHideEighthYearStripEffectRoot()
	{
	}

	private bool GetPlayerIsWanted(BHGGAEEHJCO playerID)
	{
		return false;
	}

	private void TryReleasePrivilegeVFXHolder()
	{
	}

	private void SetPrivilegeIcon(uint badgeType, uint subType)
	{
	}

	public void RefreshTeamgatherIcon()
	{
	}

	public void RefreshSFRoleplayIcon()
	{
	}

	public void RefreshInGulagIcon()
	{
	}

	private void SetPrivilegeVFX(uint badgeType, uint subType)
	{
	}

	public void ReviveClearUsingRevivePoint()
	{
	}

	public void ClearLandingFightProtection()
	{
	}

	public void OnPlayerOnOrOutIsland(bool isOnIsland)
	{
	}

	public void OnPlayerUnderWaterChanged(bool isUnderWater)
	{
	}

	protected void SetGameObjectsActive(GameObject go, bool flag)
	{
	}

	public void OnLandingFightProtectionStateChanged(bool isCountdownActive, int progressPercent)
	{
	}

	public void RestartRescuredProgressSequencer()
	{
	}

	private void StartRescurProgressSequencer(OLGNDPDIGLP status)
	{
	}

	private void StopRescuredProgressSequencer()
	{
	}

	private void RefreshBeRescured()
	{
	}

	private void _RefreshBeRescuredProgress(float fillAmount)
	{
	}

	private void RefreshKnockDown(bool show)
	{
	}

	private bool IsTargetPlayerBleedingOnKnockedDown()
	{
		return false;
	}

	private void InvalidateKnockdownWidgetCache()
	{
	}

	private void ApplyKnockdownTint(bool isBleed)
	{
	}

	private void _003CSetDownOrDeadEffectWithDelay_003Eb__157_0()
	{
	}

	private void _003COnKnockDownAndKill_003Eb__208_0()
	{
	}

	private void _003CDelayCallHideEighthYearStripEffectRoot_003Eb__224_0()
	{
	}

	private void _003CStartRescurProgressSequencer_003Eb__239_1(int step)
	{
	}
}

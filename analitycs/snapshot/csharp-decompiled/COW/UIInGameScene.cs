using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

internal class UIInGameScene : UICOWBaseScene
{
	public enum EMapStateType
	{
		MiniMap,
		BigMap,
		SideMap
	}

	public enum FightingEffectCategory
	{
		RevivePoint,
		Treasury,
		TechAirDrop,
		LockAirDrop,
		EnergyDevice
	}

	public enum EUIGroup : ulong
	{
		UIGroup_InGameNormal = 1uL,
		UIGroup_Inventory = 2uL,
		UIGroup_Driver = 4uL,
		UIGroup_Passenger = 8uL,
		UIGroup_Skydiving = 16uL,
		UIGroup_Sighting = 32uL,
		UIGroup_MatchEnd = 64uL,
		UIGroup_HideAll = 128uL,
		UIGroup_BIGMAP = 256uL,
		UIGroup_Observer = 512uL,
		UIGroup_KnockDown = 1024uL,
		UIGroup_SpectatorFixed = 2048uL,
		UIGroup_SpectatorFree = 4096uL,
		UIGroup_OnStrop = 8192uL,
		UIGroup_RoomObserver = 16384uL,
		UIGroup_InJetFly = 32768uL,
		UIGroup_ActiveSkill = 65536uL,
		UIGroup_ActiveSkillAllowAction = 131072uL,
		UIGroup_PendingRevive = 262144uL,
		UIGroup_OnSeat = 524288uL,
		UIGroup_OnCatapult = 1048576uL,
		UIGroup_CatapultFalling = 2097152uL,
		UIGroup_PendingReviveReborn = 4194304uL,
		UIGroup_InFoldWing = 8388608uL,
		UIGroup_Skateboarding = 16777216uL,
		UIGroup_SnowMan = 33554432uL,
		UIGroup_Cutscene = 67108864uL,
		UIGroup_ReaperMode = 134217728uL,
		UIGroup_ObserverMatchEndShow = 268435456uL,
		UIGroup_Photograph = 536870912uL,
		UIGroup_NewDeath = 1073741824uL,
		UIGroup_OnFerrisWheel = 2147483648uL,
		UIGroup_WereWolves = 4294967296uL,
		UIGroup_SceneEditFree = 8589934592uL,
		UIGroup_SceneEditLook = 17179869184uL,
		UIGroup_ScoutDriving = 34359738368uL,
		UIGroup_SceneEditLock = 68719476736uL,
		UIGroup_SceneEditPreviewLock = 137438953472uL,
		UIGroup_SceneEditPreviewFree = 274877906944uL,
		UIGroup_SnowSlide = 549755813888uL,
		UIGroup_ReplayObserver = 1099511627776uL,
		UIGroup_FlightRoam = 2199023255552uL,
		UIGroup_UGCPhotograph = 4398046511104uL,
		UIGroup_SceneEditFreeEntityGetter = 8796093022208uL,
		UIGroup_SceneEditLockEntityGetter = 17592186044416uL,
		UIGroup_GrapplingHookGunOnStrop = 35184372088832uL,
		UIGroup_InGamePlatform = 70368744177664uL,
		UIGroup_UGCPhotographFree = 140737488355328uL,
		UIGroup_Summoning = 281474976710656uL,
		UIGroup_NoOperation = 562949953421312uL,
		UIGroup_Helicopter = 1125899906842624uL,
		UIGroup_ExecuteSkill = 2251799813685248uL,
		UIGroup_OnCannon = 4503599627370496uL,
		UIGroup_TrainCharacterDialog = 9007199254740992uL,
		UIGroup_KillCamObserver = 18014398509481984uL,
		UIGroup_SuperEmote = 36028797018963968uL,
		UIGroup_SlideMove = 72057594037927936uL,
		UIGroup_SwitchStrop = 144115188075855872uL,
		UIGroup_Dead = 288230376151711744uL,
		UIGroup_UGCPhotographTemplate = 576460752303423488uL,
		UIGroup_Camera = 1152921504606846976uL,
		UIGroup_SceneEditFPV = 2305843009213693952uL,
		UIGroup_UGCTimeline = 4611686018427387904uL,
		UIGroup_UGCCustomMatchResult = 9223372036854775808uL
	}

	public enum EUIGroupHigh : ulong
	{
		UIGroup_CarniDance = 1uL,
		UIGroup_CUBICMAP = 2uL,
		UIGroup_FixedCharacterCameraMode = 4uL,
		UIGroup_OnHorse = 8uL,
		UIGroup_GBFootBall = 0x10uL,
		UIGroup_GB_GPGulagResult = 0x20uL,
		UIGroup_RoomObserverFree = 0x40uL
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__65_0;

		public static Predicate<string> _003C_003E9__564_0;

		public static Predicate<string> _003C_003E9__564_1;

		public static Predicate<string> _003C_003E9__601_0;

		public static Action _003C_003E9__633_1;

		public static Action _003C_003E9__633_2;

		public static Action _003C_003E9__639_0;

		public static Predicate<UIBaseController> _003C_003E9__671_0;

		public static Action _003C_003E9__677_0;

		public static Action _003C_003E9__684_0;

		public static Action _003C_003E9__943_0;

		public static Action _003C_003E9__948_1;

		public static Action _003C_003E9__948_2;

		public static Comparison<InGameCDNGuideItem> _003C_003E9__1538_0;

		internal void _003CShowIIV1v1ReadyLeaveMask_003Eb__65_0()
		{
		}

		internal bool _003COnLocalPlayerDead_003Eb__564_0(string x)
		{
			return false;
		}

		internal bool _003COnLocalPlayerDead_003Eb__564_1(string x)
		{
			return false;
		}

		internal bool _003CCheckCanQuitGame_003Eb__601_0(string x)
		{
			return false;
		}

		internal void _003CShowNoobPopup_003Eb__633_1()
		{
		}

		internal void _003CShowNoobPopup_003Eb__633_2()
		{
		}

		internal void _003CShowChickenShowTimeUI_003Eb__639_0()
		{
		}

		internal bool _003COnHudNormalSettingChanged_003Eb__671_0(UIBaseController c)
		{
			return false;
		}

		internal void _003CShowBackToLobbyDialog_003Eb__677_0()
		{
		}

		internal void _003CReplayQuitMatch_003Eb__684_0()
		{
		}

		internal void _003COnGameOpeningStart_003Eb__943_0()
		{
		}

		internal void _003COnGameOpeningEnd_003Eb__948_1()
		{
		}

		internal void _003COnGameOpeningEnd_003Eb__948_2()
		{
		}

		internal int _003CCacheCdnGuideInfo_003Eb__1538_0(InGameCDNGuideItem a, InGameCDNGuideItem b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1139_0
	{
		public GameObject mask;

		internal void _003COnHudCSSpecialRoundShowMask_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1140_0
	{
		public GameObject mask;

		internal void _003COnHudCSTrainRoundShowMask_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1238_0
	{
		public UIInGameScene _003C_003E4__this;

		public BHGGAEEHJCO playerID;

		public UIHudLeaderBoardTitleController leaderboardTitle;

		internal void _003CShow3PLeaderboardTitle_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1240_0
	{
		public bool isLeaderBoardTitle;

		public BaseProfileInfo showPlayerProfile;

		public UIHudLeaderBoardTitleController leaderboardTitle;

		public Player localPlayer;

		public UIInGameScene _003C_003E4__this;

		internal void _003CShowLocalPlayerLeaderboardTitle_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1263_0
	{
		public GroupInviteNtf inviteNtfData;

		internal void _003CShowInGameGroupInviteBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1264_0
	{
		public UIInGameScene _003C_003E4__this;

		public GroupInviteNtf inviteNtfData;

		internal void _003COnInGameAcceptGroupInvite_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1290_0
	{
		public UIUGCDebuggerOpen.DownloadInfoForLocalTest downloadInfoForLocalTest;

		internal void _003COnCraftLandShowDownloadPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1454_0
	{
		public ResourceID maskUIResID;

		public GameObject sapMask;

		public bool needHideAll;

		internal void _003CShowTeleportFullScreenMask_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1488_0
	{
		public UIInGameScene _003C_003E4__this;

		public BHGGAEEHJCO srcPlayerId;

		public uint expected;

		internal void _003CScheduleHudUAVRevealAutoClear_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass642_0
	{
		public UISecondConfirmContoller confirmWnd;

		internal void _003CShowFriendObserverQuitWnd_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass656_0
	{
		public UIInGameScene _003C_003E4__this;

		public bool needRequestMatchResult;

		internal void _003COnShowMatchResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass659_0
	{
		public UIModelCSLadderMatch csModel;

		internal void _003COpenMatchResultUI_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass659_1
	{
		public UIModelLadderMatch brModel;

		internal void _003COpenMatchResultUI_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass659_2
	{
		public UIModelCSPeakTournamentLadderMatch modelCsPeakTournament;

		internal void _003COpenMatchResultUI_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass679_0
	{
		public MatchGame game;

		internal void _003CRequestQuitMatch_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass679_1
	{
		public MNDHKHJINOG currentGame;

		internal void _003CRequestQuitMatch_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass682_0
	{
		public UIInGameScene _003C_003E4__this;

		public MatchGame game;

		internal void _003CFriendObserverRequestQuitMatch_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass683_0
	{
		public UIInGameScene _003C_003E4__this;

		public MatchGame game;

		internal void _003CRoomSpectatorRequestQuitMatch_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass686_0
	{
		public MatchGame game;

		public EQuitGameReason reason;

		public bool isCurrentGameDelayExitActivated;

		internal void _003CNormalPlayerRequestQuitMatch_003Eb__0()
		{
		}

		internal void _003CNormalPlayerRequestQuitMatch_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass711_0
	{
		public UIInGameScene _003C_003E4__this;

		public IIMKCGFHMKK target;

		public ResourceID effectResID;

		internal void _003CAttachCrosshairsAndFireBtnEffectToTarget_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass820_0
	{
		public UIInGameScene _003C_003E4__this;

		public BHGGAEEHJCO id;

		internal void _003CRemoveNameHud_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass891_0
	{
		public uint id;

		public NOJDBNBDKHF point;

		internal void _003COnShowLockAirDropInteract_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass952_0
	{
		public UIInGameScene _003C_003E4__this;

		public float scrollTime;

		public float autoCloseDelayTime;

		internal void _003COnGameGlobalMissionTutorialStart_003Eb__0()
		{
		}
	}

	private sealed class _003CForceSkipFCO_003Ed__546 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CForceSkipFCO_003Ed__546(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003COpenCommonHud_003Ed__566 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameScene _003C_003E4__this;

		private bool _003CisHighlight_003E5__2;

		private UIBaseController _003CobCountCtrl_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__566(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003COpenHud_003Ed__502 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameScene _003C_003E4__this;

		private bool _003CopenCsShopEntry_003E5__2;

		private UIModelCustomRoom _003CmodelRoom_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__502(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003COpenIIVHud_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenIIVHud_003Ed__60(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CReleaseMemoryAndOpenMatchResult_003Ed__661 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool keepScene;

		public bool createAvatar;

		public UIInGameScene _003C_003E4__this;

		public Type type;

		private EMKJHAJNPDH _003Cmatch_003E5__2;

		private bool _003CreleaseLocalPlayer_003E5__3;

		private AsyncOperation _003CcleanupState_003E5__4;

		private float _003CwaitEndTime_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReleaseMemoryAndOpenMatchResult_003Ed__661(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CShowCSItemGenerator_003Ed__880 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<LevelObjectItemGenerator> data;

		public UIInGameScene _003C_003E4__this;

		private List<LevelObjectItemGenerator>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowCSItemGenerator_003Ed__880(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIHUDStationBattleTipController m_StationBattleTipController;

	private UIHUDEighthOnBoardTipsController m_EighthOnBoardTips;

	private UIHUDEighthCabinTopTipController m_EighthOnCabinTopTip;

	private UIHUDEighthGeneralTipsController m_EighthGeneralTip;

	private HUDTipsParams m_CacheHUDTipsParams;

	private UIHUDEighthBottomTipController m_EighthBottomTip;

	private uint m_EighthDelayShowEffectID;

	private bool m_IsInLandWelcomeState;

	private UIHUDEighthGiftTransferController m_EighthGiftTransferUI;

	private UIHudEighthLandTopInfoController m_EighthTopHUD;

	private UIHudEighthItemRewardController m_EighthItemRewardController;

	private bool m_IsEighthLandWin;

	private uint m_EighthLandGetinfiniteItemID;

	protected UIHudIIVGPCursedEnergyEntranceController m_IIVGPEntranceCtrl;

	protected UIHudIIVGPCursedEnergyMainController m_IIVGPMainCtrl;

	protected UIHudIIVSkillDescTipController m_IIVGPSkillDescTipsCtrl;

	protected UIHudIIVTempleDamageInfoController m_IIVTempleDamageInfoCtrl;

	private UIHudIIVTempleDescTipController m_IIVTempleDescTipsCtrl;

	private UIHUDIIV1v1TipController m_IIV1v1TipHUD;

	private UIHudIIVFloatingLandTimerController m_IIVFloatingLandTimerCtrl;

	private uint m_DelayHideUIHudIIVTempleDamageInfoId;

	private GameObject m_IIV1v1ResultMask;

	private UIHudPopupController m_LastPopupController;

	private UIHudPopupController m_LastLowPopupController;

	private UIHudCreditBehaviorPopupController m_LastCreditBeahviorPopupController;

	protected UIHudTweenTipsController m_TweenTipsController;

	private UIHudReceiveRewardController m_ReceRewardController;

	protected UIHudHGTweenTipsController m_HGTweenTipsController;

	protected UIHudSnowSlideGrabRotateResultController m_SnowSlideRotateResultController;

	protected UIHudMapThrowerTipsWithTeamIndexController m_MapThrowerTipsWithTeamIndexCtrl;

	private UIHudBannerTweenTipsController m_BannerTweenTipsController;

	private UIHudSpecialPopupController m_LastSpecialPopupController;

	private UIHudDynamicInfoPopupController m_LastDynamicPopupController;

	protected UIHudTeammatesInfoController m_TeamInfoUI;

	protected UIHudFollowEmoteController m_FollowEmoteUI;

	protected UIHudLoginAge18Controller m_LoginAge18Ctrl;

	private UIHudSpeedRoyaleTeammatesInfoController m_SpeedRoyalTeamInfoUI;

	protected UIHudEmotionController m_EmotionCtrl;

	protected UIHudMessageController m_MessageCtrl;

	protected UIHudVoiceToTextController m_VoiceToTextCtrl;

	private UIHudRouletteChatController m_RouletteChatCtrl;

	private UIHudRouletteMedkitController m_RouletteMedkitCtrl;

	private UIHudRouletteMapThrowerController m_RouletteMapThrowerCtrl;

	private UIHudRouletteGrenadeController m_RouletteGrenadeCtrl;

	private UIHUDCenterUpTeammateTipsController m_CenterUpTeammateTipsController;

	private UINotificationQueueScheduler m_BannerNotificationScheduler;

	private List<UIHudActivityTweenTipsEntry> m_ActivityTweenTipsEntries;

	private List<UIHudActivityTweenTips2Entry> m_ActivityTweenTips2Entries;

	protected Dictionary<BHGGAEEHJCO, UIBaseController> m_PlayerNames;

	protected Dictionary<BHGGAEEHJCO, UIBaseController> m_RoomOBFreeNames;

	private Dictionary<BHGGAEEHJCO, UIBaseController> m_EnemyNames;

	private UIHudKillCamSelfController m_KillCamSelfCtrl;

	private Dictionary<BHGGAEEHJCO, UIHudChatBoxController> m_PlayerChats;

	private Dictionary<BHGGAEEHJCO, ChatBox3D> m_PlayerChat3DBoxes;

	private Dictionary<uint, UIBaseController> m_ObjectNames;

	private Dictionary<BHGGAEEHJCO, UIHudNameRedEnvelopeOwnerController> m_RedEnvelopeOwners;

	private Dictionary<BHGGAEEHJCO, UIHudEnermyPointController> m_BanActiveSkillPoints;

	private Dictionary<BHGGAEEHJCO, UIHudEnermyPointController> m_SantinoDummyBombMarkbyEnemyPoints;

	private Dictionary<BHGGAEEHJCO, UIHudRevengeInfoPointController> m_RevengeInfoPoints;

	private Dictionary<BHGGAEEHJCO, UIHudItemMarkShowController> m_AssistantPosItemMarks;

	private Dictionary<uint, UIHudRevivePointPosMarkController> m_RevivePointMarks;

	private UIHudLandingFightProtectProgressController m_LandingFightProtectProgress;

	private UIHudTutorialTaskInfoController m_TutorialTaskInfoCtrl;

	private Dictionary<uint, UIHud2NBGPBloodMoonAirdropPosMarkController> m_BloodMoonAirdropMarks;

	private Dictionary<uint, UIHudLockAirDropPosMarkController> m_AirDropMulPointMarks;

	private Dictionary<BHGGAEEHJCO, UIHudLeaderBoardTitleController> m_OthersLeaderBoardTitleDict;

	private FNJJOALKJOC m_ObserverAssistMgr;

	protected UIHudHurtHintController m_UIHurtHint;

	private Dictionary<BHGGAEEHJCO, UIHudLeaderBoardTitleController> m_LocalPlayerLeaderBoardTitleDict;

	private Dictionary<BHGGAEEHJCO, UIHudBuffPanelFollowPlayerController> m_HudBuffPanelFollowPlayerCtrls;

	private UIHudItemSearchMarkController m_HudItemSearchMark;

	private UIHudItemMarkShowController m_HudEasterEggTelescopeSearchMark;

	private Dictionary<BHGGAEEHJCO, List<UIHudItemMarkShowController>> m_HudUAVRevealMarks;

	private Dictionary<BHGGAEEHJCO, uint> m_HudUAVRevealDelayCalls;

	protected UIHudPVEAutoReviveController m_HudPVEReviveInfoCtrl;

	protected UIHUDPlayerGodBarController m_HUDPlayerGodInfoCtrl;

	private UIHudWhiteScreenController m_WhiteScreenCtrl;

	private UIHudEnemyHypeLevelController m_HudEnemyHypeLevel;

	protected UIHudMinimapController m_MiniMapCtrl;

	protected UIHudMatchEndShowTimeControllerBase m_MatchEndShowTimeController;

	protected UIHudHackerDetectedController m_HackerDetectedController;

	protected UIBaseController m_LeaderboardController;

	private UIHudGamePauseController m_GamePauseCtrl;

	protected GameObject m_UIHudUserIDObject;

	protected UIHudCSShopController m_CSShopController;

	private UIHudCSShopMysteryBoxOpenController m_MysteryBoxOpenController;

	protected UIHudBaseCSRoundResultController m_CSRoundResultController;

	protected UIHudRoundTransitionController m_RoundTransitionController;

	protected UIHudCSFactionController m_CSFactionController;

	protected UIHudCSShopEntryController m_CSShopEntryCtrl;

	protected UIHudCupMatchIntroController m_CupMatchEntryCtrl;

	protected UIHudFPPCSMatchIntroController m_FPPCSMatchIntroController;

	protected UIHudFPPPlayerEffectController m_FPPPlayerEffectController;

	protected UIHudPresetPickEntranceController m_PresetPickEntranceCtrl;

	protected UIHudPresetPickMainController m_PresetPickMainCtrl;

	protected UIBigMapController m_BigMapCtrl;

	protected UIHudCubicMapController m_CubicMapCtrl;

	protected UIHudKillNotificationController m_KillNotiCtrl;

	protected UIHudSafeZoneInfoController m_SafeZoneInfoCtrl;

	protected UIHudDirectionRulerController m_DirRulerCtrl;

	private UIHudActionController m_HudActionCtrl;

	private UIHudAceTeamController m_AceTeamCtrl;

	private UIHudSwitchStropController m_HudSwitchStropCtrl;

	private UIHudStropDashController m_HudStropDashCtrl;

	protected UIHudCrouchController m_CrounchCtrl;

	protected UIHudCreepController m_CreepCtrl;

	protected UIHudJumpController m_JumpBtnCtrl;

	protected UIHudUGCTakePhotoController m_TakePhotoCtrl;

	protected UIHudObEventEntryController m_ObEventEntryCtrl;

	protected UIHudObGlobalEventPollEntryController m_ObEventGlobalPollEntryCtrl;

	protected UIHudObGlobalEventPanelController m_ObEventGlobalPanelCtrl;

	protected UIHudObLocallEventPanelController m_ObEventLocalPanelCtrl;

	protected UIHudObGlobalEventPollController m_ObEventGlobalPollCtrl;

	protected UIHudObGlobalEventActiveController m_ObEventGlobalActiveCtrl;

	private UIHudTriggerDetailPopUpController m_EsportInfoCtrl;

	public UIHudQuitController m_TestHudQuitController;

	private UIHudEarnTokenPopController m_EarnTokenPopController;

	private UIhudBossOniPopupController m_BossOniPopupController;

	private UIHudBeachBallGoalVFXController m_BeachBallGoalVFXController;

	private UIHudAffixPopupController m_AffixPopController;

	private UIHudAuroraInteractPopupController m_AuroraInteractPopController;

	private UIHudCSCoinController m_CSCoinController;

	protected UIHudCDNGuideDetailController m_CDNGuideDetailCtrl;

	protected UIHudBRTutorialAgentPopWndController m_BRTutorialAgentGuideDetailCtrl;

	private UIHudGetOffSlideController m_GetOffSlideCtrl;

	private UIHudSlideSwitchMoveController m_SlideSwitchMoveCtrl;

	private UIHudGetBuffController m_BossOniGetBuffController;

	private Dictionary<UIBaseController, string> m_SpecialHudUsingOtherConfigDict;

	protected UIHudSignalController m_UIHudSignalController;

	protected UIHudItemRequsetBtnController m_UIHudItemRequsetBtnController;

	protected UIHudItemMarkPlayerDeadBtnController m_UIHudItemMarkPlayerDeadBtnController;

	protected UIHudObserverReviveMissionController m_UIHudObserverReviveMissionController;

	protected UIHudMissionMachineInfoController m_MissionMachineInfoController;

	protected UIHudRevivePointActionBtnController m_RevivePointActionBtnController;

	protected UIHypercrateDistanceInfoController m_HypercrateDistanceInfoController;

	protected UIHudLuckyDrawBoxController m_LuckyDrawBoxController;

	protected UIHudSeafoodLittleGirlGameController m_SeafoodLittleGirlController;

	protected UIInGameBattleBoardController m_BattleBoardController;

	private uint m_HideBattleBoardDelayCallID;

	private UIHudTokenController m_TokenCtrl;

	protected UIHudCombineWeaponController m_CombineWeaponController;

	protected UIHudSwitchWeaponCombineController m_SwitchWeaponCombineController;

	protected UIBaseController m_AbandonLifeCDController;

	protected UIHudSwimmingSurfController m_SwimmingSurfController;

	protected UIHudWLSnowSlidePlayerStatsController m_SnowSlidePlayerStatsController;

	protected UIBaseController m_CallForReviveController;

	private const int HighFreqPanelSelfIntervalFrame = 1;

	private InGameNotificationManager m_InGameNotificationManager;

	protected bool mLoadingMaskClosed;

	private Dictionary<string, UIBaseController> m_SpectatorTargetHudList;

	private bool _003CIsPlayingFlightOpeningAnim_003Ek__BackingField;

	private bool m_IngameShopVisble;

	private bool m_IngameAirDropShopVisble;

	private bool m_IngamePersonalShopVisble;

	private bool m_IngamePersonalShopUpgradeVisble;

	private GameObject m_VFXTeleportDoorBlackMask;

	private List<GameObject> m_staticTopRightObjList;

	protected bool m_IsKillCamReCreatedScene;

	protected UIHudWeaponInfoController m_HudWeaponInfoController;

	protected UIHudWeaponSwitchController m_HudWeaponSwitchController;

	protected UIHudWeaponInfoUpgradeController m_HudWeaponInfoUpgradeController;

	private UIHudAssistantTextController m_HudAssistantTextController;

	protected UIHudPickupListControllerV2 m_HudPickUpListControllerV2;

	protected UIEquipSetSelectionController m_UIEquipSetSelectionController;

	private UIHudItemMarkGridWndController m_HudItemMarkGridWndController;

	private UIHudRangeShopController m_HudRangeShopController;

	private UIHudCatagoryRangeShopController m_HudCatagoryRangeShopController;

	private UIHudPortalMaskController m_HudPortalMaskController;

	private UIHudFriendAddController m_HudFriendAddController;

	private BHGGAEEHJCO m_TeamFlightFriendAddHudPlayerId;

	private HashSet<BHGGAEEHJCO> m_TeamFlightFriendAddHudShownPlayerIds;

	private UIHudHighlightTargetPlayerController m_HighlightTargetPlayerController;

	private UIHudCommonChooseBoxController m_HudFriendInviteController;

	private UIHudDriftBottleAddFriendController m_HudDriftBottleAddFriend;

	private UIHudTrainingConfirmController m_TrainingConfirmCtrl;

	private UIHudAuxFireController m_AuxfireCtrl;

	private UIHudSwapWeaponQuickController m_SweapWeaponQuickController;

	protected UIHudReloadBtnController m_ReloadBtnController;

	protected UIHudTriggerGrenadeController m_TriggerGrenadeCtrl;

	protected UIHudGrenadeAndCancleParentController m_GrenadeAndCancleParentController;

	protected UIHudPreparationTimerController m_PrepareCtrl;

	protected UIHudRescureController m_RescureCtrl;

	protected UIHudCrosshairsController m_CrossHairCtrl;

	protected UIHudCrosshairsOBController m_CrosshairOBCtrl;

	protected UIHudExecuteController m_ExecuteCtrl;

	protected UIHudFireController m_FireController;

	protected UIHudPlayerRemainingInfoController m_PlayerRemainingInfoCtrl;

	protected UIHudTrainingScoreEntranceController m_TrainingScoreEntranceCtrl;

	protected UIHudSettingController m_HudSettingCtrl;

	protected UIHud2TeamsTimeScoreController m_UIHud2TeamsTimeScoreController;

	public bool HasOpenMatchResultUI;

	public InGameMutiTipsManager m_MutiTipsManager;

	protected UIHudInGameChatController m_UIHudInGameChatController;

	private UIHudCSMatchInfoController m_CSMatchInfoInfoCtrl;

	private UIKeyActionSettingController m_KeyActionSettingCtrl;

	private UIHudHardwareInputGuideController m_HardwareInputGuideController;

	protected UIBaseController m_InGameShopCtrl;

	protected UIBaseController m_InGameAirDropShopCtrl;

	protected UIBaseController m_InGamePersonalShopCtrl;

	protected UIBaseController m_InGamePersonalShopUpgradeCtrl;

	protected UIBaseController m_CurGameShopCtrl;

	protected UIHudReviveSelectController m_ReviveSelectController;

	protected UIHUDReviveSelectOnRevivePointController m_ReviveSelectOnRevivePointController;

	protected UIHudChatBtnController m_ChatBtnController;

	protected UIHudInGameBountyBoxShopController m_InGameBountyBoxShopCtrl;

	private UIHudCSRoundBonusInfoController m_CSRoundBonusInfoCtrl;

	private bool m_NeedShowCSRoundBonusInfo;

	private uint m_HideCSRoundBonusInfoDelayCall;

	private bool m_IsMatchEendShow;

	private UIHudUseRescureZoneProcessController m_UseRescureZoneProcess;

	private UIHudFullScreenEffectController m_FullScreenEffect;

	private UIHudBossHalloweenHpController m_HalloweenBossHp;

	private UIHudReconnectTipsController m_ReconnectTipsController;

	private UIHudLockAirDropInfoController m_LockAirDropInfo;

	private UIHudLvObjInteractAreaInfo m_LeveLobjInteractAreaInfo;

	private UIHudInfiniteAirDropInfoController m_InfiniteAirDropInfo;

	private UIHudBotAgentMaskController m_BotAgentMask;

	private UIHudAirdropWeaponMarkController m_AirdropWeaponMark;

	private int m_WeaponPowerDepth;

	private EMapStateType m_MapState;

	public readonly Vector3 fixedAuxFireButtonPox;

	protected Transform m_UiHudPanelDynamic;

	protected UIPanel m_UIHudPanelDynamicUIPanel;

	protected Transform m_UiHudPanelStatic;

	protected UIPanel m_UIHudPanelStaticUIPanel;

	private UIElitePassTopPlayerLeftWingController m_LeftWingCtrl;

	private UIElitePassTopPlayerRightWingController m_RightWingCtrl;

	private UIElitePassIngameHudRankingController m_EPHudRankingCtrl;

	private UIHudWaitingThumbUpController m_HudWaitingThumbUpCtrl;

	private UIHudJetFlyController m_JetFlyCtrl;

	private UIHudJetFlyUpController m_JetFlyUpCtrl;

	private UIHudJetFlyDownController m_JetFlyDownCtrl;

	protected UIHudSpeedupAreaController m_SpeedUpCtrl;

	protected UIHudSightController m_SightCtrl;

	private UIHudWeaponExpansionAbilityController m_WeaponExpansionAbilityCtrl;

	protected UIHudActiveSkillController m_ActiveSkillBtn1;

	protected UIHudActiveSkillController m_ActiveSkillBtn2;

	protected UIHudTechDeviceBtnController m_TechDeviceBtn;

	protected UIHudSnowSlideEnergyBarController m_SnowSlideEnergyBarCtrl;

	protected UIHudActiveSkillPerksChooseController m_ActiveSkillPerksChooseCtrl;

	protected UIHudSkillMightyUpgradeController m_SkillMightyUpgradeCtrl;

	private bool m_HasCachedSkillMightyChooseResources;

	protected UIHudGameVoiceController m_GameVoiceCtrl;

	protected UIHudMicroPhoneMuteController m_micMuteCtrl;

	protected UINewGroupMemberVoiceInfoController m_VoiceMicCtrl;

	private Coroutine m_OpenMatchResultCor;

	protected UIHudMovingJoystickController m_MoveJoyStickCtrl;

	private UIHudBeHintedController m_HintedCtrl;

	protected UIHudPlayerStatsController m_PlayerStatsCtrl;

	protected UIHudPlayerSkillBuffController m_PlayerSkillBuffCtrl;

	protected UIHudPlayerArmorStatsController m_PlayerArmorStatsCtrl;

	protected UIHUDPVEGameCountdownController m_TrainingEndCountDownCtrl;

	protected UIHudCommonPregameTimeTipController m_UIHudCommonPregameTimeTipController;

	protected UIHudGameMissionEffectController m_GameMissionEffectController;

	private UGCInfectionChangePanelController m_UGCInfectionChangePanelController;

	private UIHUDUGC_IdentityGuideController m_UGCInfectionStrongerGuideController;

	private const string InfectionStrongerToturial = "InfectionStronggerToturial_";

	private GameObject m_UGCInfectionZombieShowVFX;

	private uint m_InfectionVFXDelayCall;

	private GameObject m_HudNoobPopup;

	private bool m_HadBasicPopShow;

	private Func<Collider, bool> m_PhysicsCheckIgnoreWeaponShile;

	private bool m_LocalPlayerAdded;

	private bool m_PreloadLoaded;

	private ResourceID m_CurPlayingOpeningSound;

	private bool m_PauseUIOpened;

	private bool m_DisablePopTip;

	private BHNBKBANDDC m_BuffHUDDataManager;

	private bool _003CIsUsingStackKillNotification_003Ek__BackingField;

	private bool m_CanQuitGame;

	private UIHudAvatarAttributeBagController avatarBagCtrl;

	private UIHudInventoryController bagctrl;

	private UIHudHippoCrisisEquipmentContainerController m_HippoCrisisBagctrl;

	private UIHudAvatarAttributeBagTabController bagTab;

	public UIHudInventoryEntryController inventryctrl;

	protected readonly List<UIHudGrenadeBtnController> m_GrenadeBtnControllers;

	private Dictionary<int, uint> m_ItemBuffDict;

	private UIHudToxicBehaviorWarningWndController m_ToxicBehaviorWarningWndController;

	protected UIHudQuickUseMedkitController m_UIHudQuickUseMedkitController;

	public UIMatchMakingManager MatchMakingManager;

	protected UIHudEmotionEntryController m_UIEmotionBtnController;

	protected UIHudQuickChatContainerController m_UIHudQuickChatContainerController;

	protected UIHudQuickChatThumbNodeController m_UIHudQuickChatThumbNodeController;

	private UIHudCancelRemoteRescueController m_UIHudCancelRemoteRescueController;

	private UIHudCSDualActiveSkillPopWndController m_ChooseSkillCtrl;

	private UIHudClanWarMiniBoardController m_ClanWarMiniBoardCtrl;

	private GameGlobalMissionKingVFX m_GameGlobalMissionKingVFX;

	private uint m_GameGlobalMissionKingVFXHolder;

	protected UIHudInventoryExchangeController m_UIHudInventoryExchangeController;

	protected UIHudInventoryExchangeController m_UIHudInventoryExchangeInBagController;

	private UIHudBooyahBountyRankingStatueDeployedNotificationController m_RankingStatueDeployedNotificationCtrl;

	protected UIHudFPPInspectionController m_FPPInspectionController;

	protected UIHudReplayCtrlController m_UIHudReplayCtrlController;

	private List<UIHudCommonChooseBoxController> m_InGameGroupInviteOrJoinRequestBoxes;

	private const int MAX_NUM_INGAME_GROUPINVAITE_OR_GROUPJOINREQUEST = 3;

	private List<MessageInviteChooseBoxData> m_InGameGroupInviteOrJoinRequestDataList;

	private List<uint> m_InGameGroupInviteOrJoinRequestDataDelayCallId;

	private bool m_GroupInviteOrJoinRequestBlock;

	private bool m_IgnoreGroupInviteInGame;

	private bool m_IgnoreGroupJoinRequestInGame;

	public bool CurNewInviteIsFriendInvite;

	public bool CurHasNewFriendInvite;

	public bool ShowChatBtnTips;

	public bool SocialInviteRedDotShow;

	private GroupInviteNtf m_InGameGroupInviteNtf;

	private UIRematchInvitePopupController m_CurRematchInvitePopupController;

	private readonly EntityVisualEffectManager m_VisualEffectManager;

	private static int sEnterGameCount;

	private bool mEnterGameEventLogSent;

	protected Action m_ActionOnLoadingMaskClosed;

	private bool m_IsReconnect;

	private UIHudSFRoleplaySummonerActionController m_SFRoleplaySummonerActionCtrl;

	private UIHudTreasuryUpgradeBtnController m_TreasuryUpgradeBtnCtrl;

	private UIHudGB_GPKickBallBtnController m_GB_GPKickBallBtnCtrl;

	private UIHudGetOnVehicleAsDriverController m_VehicleGetOnAsDriverCtrl;

	private UIHudGetOnVehicleAsPassengerController m_VehicleGetOnAsPassengerCtrl;

	private UIHudVehicleHornController m_VehicleHornCtrl;

	private UIBaseController m_VehicleTurnLeftCtrl;

	private UIBaseController m_VehicleTurnRightCtrl;

	private UIBaseController m_VehicleAcceleratorCtrl;

	private UIBaseController m_VehicleBrakeCtrl;

	private UIBaseController m_VehicleStatsCtrl;

	private UIHudBRVehicleAutoDrive m_VehicleBRAutoDrive;

	private UIHudGetOffVehicleController m_VehicleGetOffCtrl;

	private UIHudVehicleBrakeController m_HorseBrakeCtrl;

	private UIHudVehicleOverdriveController m_VehicleOverdriveCtrl;

	private UIHudVehicleOverdriveSingleHandController m_VehicleOverdriveSingleHandCtrl;

	protected UIHudObserverProfileController m_ObserverProfileCtrl;

	private UIHUDAIChatParentController m_AIChatParentCtrl;

	public UIHudSwitchObserverController m_ObserverSwitchCtrl;

	private UIHudKillCamEntryController m_KillCamEntryCtrl;

	private UIHudReviveBubbleController m_ReviveCardBubbleCtrl;

	private UIHudItemInfosController m_HudItemInfosCtrl;

	private bool m_OpenObserverHudOnSceneLoaded;

	private IEnumerator m_ForceSkipCoroutine;

	private UIHudPOIMissionInfoController m_POIMissionInfoCtrl;

	private UIHudPOIMissionTips2Controller m_POIMissionTips2Ctrl;

	private UIHudPOIMissionProgressController m_POIMissionProgressCtrl;

	private UIHudLocalPlayerKilledController m_BeKilledCtrl;

	private UIHudDeadDetailController m_DeadDetailCtrl;

	private Vector3 m_OBCountLocalPos;

	private UIHudUGCSocialController m_UGCSocialCtrl;

	private UIHudUGCLobbyContainerController m_UGCLobbyContainerCtrl;

	protected UIHudTargetPlayerInfoBtnController m_TargetPlayerInfoBtn;

	private bool m_FictionDisclaimerPlayed;

	private UIHudLoadoutSupportController loadoutSupportCtrl;

	private UIHudReinforcedAnvilForBRController m_ReinforcedanvilCtrl;

	private bool m_DirverFireHudOpened;

	private bool m_PassengerSkillHudOpened;

	public static UIRoot UIRootStatic;

	public static UIRoot UIRootDynamic;

	private float mLastLagHintPopupTime;

	private UIHudMapThrowerUseBtnController m_MapThrowerUseBtnCtrl;

	private Dictionary<string, IIMKCGFHMKK> m_EffectTargets;

	private UIHudTechBuildOpenController m_TechBuildOpenCtrl;

	private UIHUDEighthCSTrainTipsController m_EighthCSTrainTipsCtrl;

	private UIHudCameraInGameController m_CameraInGameCtrl;

	private UIHudCameraEntryController m_CameraEntryCtrl;

	private UIPanel m_UIHudCameraInGamePanel;

	private float m_CameraModeSettingAlpha;

	private bool _003CBLastEnteredTriggerWithHud_003Ek__BackingField;

	private UIHudLoadoutFeedBackTipsController m_HudLoadoutFeedBackTipsCtrl;

	private Dictionary<Vehicle, UIHudVehiclePosController> m_VehiclePositions;

	private Dictionary<Entity, UIHudVehicleAsMissileTargetControllerBase> m_VehicleTargets;

	private UIHudLockedWarningController m_LockedWarningController;

	private Dictionary<BHGGAEEHJCO, UIBaseController> m_IdentityHud;

	private Dictionary<BHGGAEEHJCO, UIBaseController> m_InfectionHPHud;

	protected bool mJoinMatchFinished;

	private bool m_IsProcessedPreLoad;

	private uint m_ShowCSShopDelay;

	private uint m_HideCSShopDelayCallID;

	private HashSet<float> m_DelayShowCSShopTimes;

	private UIHud_QTE_UnFreezeController m_QTEUnFreezeCtrl;

	private bool IsHideAllUIByQTE;

	private float m_CSShopCloseTime;

	private CIJPLNEAIIH m_CSMatchPhase;

	private IEnumerator m_ShowCSItemGeneratorCO;

	private HashSet<long> m_FightingEffectPlayed;

	private bool m_IsShowLobbyContainer;

	private int m_CachedOpenBriefBoxTime;

	private uint delayCallId;

	private UIBaseController m_GlobalMissionAffixTutorialController;

	private Dictionary<Type, Queue<UIBaseController>> m_InGameUIPoolDic;

	private UIHUDCommonEquipSetSelectionController m_CommonEquipSetSelectionCtrl;

	private UIHUDEquipUnlockLevelController m_EquipUnlockLevelController;

	private UIHUDTeamKillController m_TeamKillController;

	public UIHUDPlayerAttributeUpController m_AttributeUpController;

	private bool m_HasOpenHudBeginFight;

	private EnterPhotographModeController m_EnterPhotographModeController;

	private PhotographModeController m_PhotographModeController;

	private UIHUDPhotographEmoteController m_PhotographEmoteController;

	public LevelPhotograph CurrentLevelPhoto;

	private UInt128 preEnterPhotographModeUIGroup;

	public bool m_TeamParachuteShowState;

	private UIHUDTeamParachuteActionController m_TeamParachuteController;

	private UIHudGetOffTeamFlightController m_TeamFlightOffController;

	private UIHUDCenterUpTitleController m_CenterUpTitleController;

	private UIHUDAirTransporterNameController m_TransporterNameController;

	private UIHudCommonBottomTipsController m_CommonBottomTipsCtrl;

	private UIHudSafezonePosMarkController m_SafezonePosMarkCtrl;

	private UIHudPresetController m_PresetCtrl;

	private UIHudPresetEntryController m_PresetEntryCtrl;

	public bool InBrOpeningCutScene;

	private GameObject m_BRChangePhaseCutSceneShowMaskIn;

	private UIHudSwingActionController swingCtrl;

	private UIHudTowActionController towCtrl;

	private UIHudReviveNotifyController m_HudReviveNotifyController;

	private uint m_RestrictedAreaScreenEffectId;

	private UIHudBattleLevelSelectBuildPopupWndController m_BattleLevelSelectBuildPopupCtrl;

	private UIHudBattleLevelDetailTipsPopupWndController m_BattleLevelDetailTipsAboveTeamScoreBoard;

	private UIHudDragonEnterController DragonEnterCtrl;

	private UIHudLoadingDragonController DragonLoadingCtrl;

	private UIHudTaskTimerController DragonTaskTimer;

	private UIHudDragonResultController DragonResultCtrl;

	private Dictionary<BHGGAEEHJCO, UIHUDHGEliteHPController> m_EliteHpMap;

	private Queue<UIHUDHGEliteHPController> m_UnusedEliteHPCtrls;

	private UIHudWL25GPCabinTopTipController m_WinterLand25CabinTopTip;

	private UIHUDVBadgeBroadcastCabinTopTipController m_VBadgeCabinBroadcast;

	private uint m_CommonCabinTopTipVisualEffectId;

	private HashSet<BHGGAEEHJCO> m_ForbidQuickChatMap;

	private UIHudElectricGirlAimTargetController m_ElectricGirlAimTargetController;

	private UIHudTeleportKnockDownResultController m_TeleportKnockDownScanResultUI;

	private UIHudAuroraBoySkillController m_AuroraBoySkillCtrl;

	private IMiniMapInZoneStateUI m_MiniMapInZoneStateUI;

	private uint m_LocalPlayerTeamGoalCurSelectId;

	private float m_TeamGoalClickTime;

	private const float m_TeamGoalClickCD = 0.7f;

	private bool m_IsShowSelectUIFX;

	private FHCKGNCNMCA m_CSRoundResultRes;

	private uint m_SelectId;

	private uint m_LastSelectId;

	private uint m_SelectItemDelayCallID;

	private const float m_SelectItemDelayCallTime = 2f;

	private uint m_NBSkyReviveVFXID;

	private Dictionary<uint, List<Vector3>> m_TeamGoalPathDict;

	private List<uint> m_TrArrowAttachedUniqueIDList;

	private UIHudCSEnemyMarkController m_LocalPlayerEnemyMarkCtrl;

	private UIHudCSRoundMVPController m_LocalPlayerCSRoundMVPCtrl;

	private UIHudSeafoodGlassBridgeBuffController m_LocalPlayerSeafoodGlassBridgeBuffCtrl;

	public bool ShowNewbieCSShopEntryGuide;

	public bool ShowNewbieCSShopDragUpGuide;

	public bool ShowNewbieCSShopPurchaseGuide;

	public string CS_VEST_GUIDE_SHOP_ENTRY;

	public string CS_VEST_GUIDE_SHOP_DRAG_UP;

	public string CS_VEST_GUIDE_SHOP_PURCHASE;

	private UIHudTechBuildPointSelectionPopupWndController m_TechBuildPointSelectionPopupCtrl;

	private UIHudSFRoleplaySelectPopupWndController m_SFRoleplaySelectPopupWnd;

	private UIHudSFRoleplaySelectPopupWndController m_SFRoleCabinRolePopupwnd;

	private UIHudSFRoleplayRoleEnergyController m_SFRoleplayRoleEnergyCtrl;

	private UIHudSFRoleplayRoleTitleController m_RoleTitleCtrl;

	private UIHudSFRoleplayNoRoleTipsController m_NoRoleTipsCtrl;

	private UIHUDTeamGatherInfoController m_TeamGatherInfoController;

	private UIHudPocketReviveSelectPopupWndController m_PocketReviveSelectPopupWndCtrl;

	private UIHudReviveCardBubbleTipsController m_ReviveCardBubbleTipsController;

	private UIHudGB_GPGulagTipsController m_GulagTipsCtrl;

	private UIHudGB_GPGulagTimeController m_GulagTimeCtrl;

	private UIHudGB_GPGulagResultController m_GulagResultCtrl;

	public float GulagCurPhaseEndTime;

	private UIPunishKillNotificationItemController m_PunishKillNotificationCtrl;

	private UIHudSuperEmoteController m_HudSuperEmoteCtrl;

	private UIHudSuperEmoteLikeController m_HudSuperEmoteLikeCtrl;

	private UIHudFollowEmoteCancelBtnController m_HudFollowEmoteCancelCtrl;

	private UIHudCommonTipsInRightPosController m_CommonTipsInRightPosCtrl;

	private Dictionary<uint, UIHudReviveBoxPosMarkController> m_HudReviveBoxPosMarkCtrls;

	private Dictionary<uint, UIHudDreamlandBoyPetHPController> m_HudDreamlandBoyPetHPCtrls;

	private Dictionary<uint, UIHudScout3PHPController> m_HudScout3PHPCtrls;

	private Dictionary<uint, UIHudFollowSpaceShieldForceDownHPController> m_HudFollowSpaceShieldForceDownHPCtrls;

	private Dictionary<uint, UIHudCommonDistanceController> m_HudFlightBubbleDistanceCtrls;

	private Dictionary<uint, UIBaseController> m_HudUAVHPCtrls;

	private UIHudSFRoleplayCabinRoleNotificationController m_HudSFRoleplayCabinRoleNotificationCtrl;

	private bool m_HasHudSFRoleplayCabinRoleNotificationShow;

	private List<UIHudAutoAbsorbAimTargetController> m_HudAutoAbsorbAimTargetCtrls;

	private Coroutine m_Play3DBooyahCoroutine;

	public const int UIGroup_Num = 71;

	protected Dictionary<Type, uint[]> GROUP_SETTING;

	protected static Dictionary<Type, string> IngameHudConfigMapping;

	public static HashSet<string> IngameVehicleHudConfigSet;

	private Dictionary<BHGGAEEHJCO, UIHudEnermyPointController> m_CommonMarkEnemyPoints;

	private UIHudLocalPlayerMarkPointController m_localPlayerBeMarkPoint;

	public bool IsDragonFight;

	public uint BossProgress;

	public byte DragonTaskTeamId;

	public LLEDPGIGCMO LastDragonDamageType;

	private List<string> CdnGuideList;

	private List<string> CdnGuideKeyList;

	private uint CdnGuideAutoCloseTime;

	private uint CdnGuideAutoOpenTimes;

	private uint CdnGuideVersionNumber;

	private uint CdnGuideLimitLevel;

	private bool IsCdnGuideWithSkill;

	private bool IsOpenedCdnGuide;

	private UIHudKnockDownQTEController m_KnockDownQTECtrl;

	private const string NewAvatarSkillGuideKey = "InGameNewAvatarCdnGuideKey";

	public List<InGameCDNGuideItem> CdnGuideItemList;

	public HUDTipsParams CacheHUDTipsParams => null;

	private bool IsInLandWelcomeState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIHudTeammatesInfoController TeamInfoUI => null;

	public Dictionary<BHGGAEEHJCO, UIHudLeaderBoardTitleController> OthersLeaderBoardTitleDict => null;

	public Dictionary<BHGGAEEHJCO, UIHudLeaderBoardTitleController> LocalPlayerLeaderBoardTitleDict => null;

	public UIHudMinimapController MiniMapCtrl => null;

	public UIHudKillNotificationController KillNotiCtrl => null;

	public UIHudActionController HudActionCtrl => null;

	public UIHudCrouchController CrounchCtrl => null;

	public UIHudCreepController CreepCtrl => null;

	public UIHudJumpController JumpBtnCtrl => null;

	public UIHudUGCTakePhotoController TakePhotoCtrl => null;

	public UIHudSignalController HudSignalController => null;

	public UIHudItemRequsetBtnController HudItemRequsetBtnController => null;

	public UIHudRevivePointActionBtnController RevivePointActionBtnController => null;

	public UIHudCombineWeaponController CombineWeaponController => null;

	public UIHudSwitchWeaponCombineController SwitchWeaponCombineController => null;

	public UIHudSwimmingSurfController SwimmingSurfController => null;

	public UIBaseController CallForReviveController => null;

	public InGameNotificationManager InGameNotificationManager => null;

	public UINotificationQueueScheduler BannerNotificationScheduler => null;

	public bool LoadingMaskClosed => false;

	public bool IsPlayingFlightOpeningAnim
	{
		get
		{
			return _003CIsPlayingFlightOpeningAnim_003Ek__BackingField;
		}
		set
		{
			_003CIsPlayingFlightOpeningAnim_003Ek__BackingField = value;
		}
	}

	public UIHudWeaponInfoController WeaponInfoController => null;

	public UIHudWeaponSwitchController HudWeaponSwitchController => null;

	public UIHudWeaponInfoUpgradeController HudWeaponInfoUpgradeController => null;

	public UIHudPickupListControllerV2 HudPickUpListControllerV2 => null;

	public UIHudAuxFireController AuxfireCtrl => null;

	public UIHudSwapWeaponQuickController SweapWeaponQuickController => null;

	public UIHudReloadBtnController ReloadBtnController => null;

	public UIHudGrenadeAndCancleParentController GrenadeAndCancleParentController => null;

	public UIHudRescureController RescureCtrl => null;

	public UIHudCrosshairsController CrossHairCtrl => null;

	public UIHudFireController FireController => null;

	public UIHudSettingController HudSettingCtrl => null;

	public UIHudChatBtnController ChatBtnController => null;

	public bool MatchEndShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EMapStateType MapState
	{
		get
		{
			return EMapStateType.MiniMap;
		}
		set
		{
		}
	}

	public Transform UiHudPanelDynamic => null;

	public UIPanel UIHudPanelDynamicUIPanel => null;

	public Transform UiHudPanelStatic => null;

	public UIPanel UIHudPanelStaticUIPanel => null;

	public UIHudSpeedupAreaController SpeedUpCtrl => null;

	public UIHudActiveSkillController ActiveSkillBtn1 => null;

	public UIHudActiveSkillController ActiveSkillBtn2 => null;

	public UIHudGameVoiceController GameVoiceCtrl => null;

	public UIHudMovingJoystickController MoveJoyStickCtrl => null;

	public UIHudPlayerStatsController PlayerStatsCtrl => null;

	public UIHudPlayerSkillBuffController PlayerSkillBuffCtrl => null;

	public UIHudPlayerArmorStatsController HudPlayerArmorStatsCtrl => null;

	public UIHudPlayerArmorStatsController PlayerArmorStatsCtrl => null;

	public BHNBKBANDDC BuffHUDDataManager => null;

	public bool IsUsingStackKillNotification
	{
		get
		{
			return _003CIsUsingStackKillNotification_003Ek__BackingField;
		}
		set
		{
			_003CIsUsingStackKillNotification_003Ek__BackingField = value;
		}
	}

	public bool CanQuitGame => false;

	public List<UIHudGrenadeBtnController> GrenadeBtnControllers => null;

	public UIHudQuickUseMedkitController HudQuickUseMedkitController => null;

	public UIHudEmotionEntryController HudEmotionEntryController => null;

	public UIHudQuickChatContainerController HudQuickChatContainerController => null;

	public UIHudQuickChatThumbNodeController HudQuickChatThumbNodeController => null;

	public UIHudFPPInspectionController FPPInspectionController => null;

	public List<MessageInviteChooseBoxData> InGameGroupInviteOrJoinRequestDataList => null;

	public bool GroupInviteOrJoinRequestBlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIHudUGCSocialController UGCSocialCtrl => null;

	public UIHudUGCLobbyContainerController UGCLobbyContainerCtrl => null;

	public UIHudCameraInGameController CameraInGameCtrl => null;

	public UIPanel UIHudCameraInGamePanel => null;

	public float CameraModeSettingAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool BLastEnteredTriggerWithHud
	{
		get
		{
			return _003CBLastEnteredTriggerWithHud_003Ek__BackingField;
		}
		set
		{
			_003CBLastEnteredTriggerWithHud_003Ek__BackingField = value;
		}
	}

	public uint LocalPlayerTeamGoalCurSelectId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool IsShowSelectUIFX
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FHCKGNCNMCA CSRoundResultRes => null;

	private void OnStationTeamStateCome(object[] data)
	{
	}

	private void ShowOrHideStationBattleTip(bool isShow, GFLGHBPCOLN msg = null)
	{
	}

	private void OnOpenEighthOnBoardTips()
	{
	}

	private void OnShowEighthCabinTopTip(bool isShow)
	{
	}

	public void ShowEighthGeneralTips(HUDTipsParams tipsParams)
	{
	}

	public void CloseCommonTweenTipsVisibelFlag(bool isClose, uint flag)
	{
	}

	public void ShowEighthBottomTips(HUDTipsParams tipsParams)
	{
	}

	private void DelayCloseEighthOnBoardTips()
	{
	}

	private void OnReadyGoEighthLand(object[] data)
	{
	}

	private void DelayShowEnterEighthLandUI()
	{
	}

	public void ShowEighthGiftTransfer(NJOGGDIEJNN msg)
	{
	}

	public void CloseEighthGiftTransferUI()
	{
	}

	private void OnEnterEighthSubGameState(object[] data)
	{
	}

	private void RefreshTopInfoUIInWelcomeStateShow()
	{
	}

	private void ShowOrHideEighthLandTopHUD(bool isShow, uint effectid = 0u, CMDBIPLGLGA groupmode = CMDBIPLGLGA.EGROUPMODE_SOLO)
	{
	}

	private void OnReadyLeaveEighthLand(object[] data)
	{
	}

	private void OnLeaveEighthSubGameState(object[] data)
	{
	}

	private void OnEighthSubGamePhaseChange(object[] data)
	{
	}

	public void ShowOrHideEighthInfiniteItemReward(bool isShow, bool isWin = false, uint itemID = 0u)
	{
	}

	public void ShowEighthLandResult(bool isWin, uint infiniteItemID = 0u)
	{
	}

	private void ShowEighthLandResultInternal()
	{
	}

	private void OnLeaveEighthSubGameReward(object[] data)
	{
	}

	public void EnterOrLeave1v1ProcessTip(bool isEnter)
	{
	}

	public void FirstOpenIIV1v1Tip()
	{
	}

	public void Play1v1EndTip()
	{
	}

	public void FirstOpenIIVTempleDesc()
	{
	}

	public void ShowIIVTempleDesc()
	{
	}

	public void ShowIIVDamageInfo()
	{
	}

	public void ShowIIVFloatingLandTimer()
	{
	}

	public void HideIIVFloatingLandTimer()
	{
	}

	public void DelayHideIIVDamageInfo()
	{
	}

	public void DelayHideIIVDamageInfoFinish()
	{
	}

	public void HideIIVDamageInfo()
	{
	}

	private void RefreshObserverIIVTempleDamageInfo(Player player)
	{
	}

	private IEnumerator OpenIIVHud()
	{
		return null;
	}

	public void EnterOrLeaveIIVFloatingLand(bool isEnter)
	{
	}

	public void OnIIV1v1ShowResult(OHJOHOHCBOJ result, bool isObserver)
	{
	}

	public void OnIIV1v1ReadyLeave(bool isObserver)
	{
	}

	public void ShowIIV1v1ReadyLeaveMask(bool isPlayeSound)
	{
	}

	public void RecycleIIV1v1ResultMask()
	{
	}

	public void HideWeaponInfo()
	{
	}

	public void OpenHudWeaponInfo()
	{
	}

	public void CloseHudWeaponInfo()
	{
	}

	public void OpenHudPlayerStats()
	{
	}

	private void TryOpenHudLoginAge18()
	{
	}

	private bool TryGetHudLoginAge18LogoCDNUrl(out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool MiniMapNeedShowOpenTip()
	{
		return false;
	}

	protected static void AttachHighFreqPanel(UIBaseController ctrl)
	{
	}

	public virtual void RegisterGameEventHandler()
	{
	}

	public override void Destory()
	{
	}

	public void CloseMask(bool removeFakeLoading)
	{
	}

	private void OnEnterOrLeaveTriggerDetail(object[] data)
	{
	}

	private void CloseMaskInternal(bool data)
	{
	}

	public void RegisterCloseLoadingMaskFunc(Action action)
	{
	}

	protected virtual void OnMaskClosed()
	{
	}

	public List<Transform> GetSpeicalRightAnchorUIList()
	{
		return null;
	}

	protected void SetAnchor(EUIAnchor anchor, Transform childTrans, Transform parentTrans)
	{
	}

	public void InitHud()
	{
	}

	private void OverrideStropUIGroupSetting()
	{
	}

	public void ShowOrHidePartyShoot(bool flag)
	{
	}

	public virtual IEnumerator OpenHud()
	{
		return null;
	}

	public void ChangeUIFromWaitingToBattle()
	{
	}

	protected virtual void ChangeUIFromWaitingToBattleInternal()
	{
	}

	private void OpenReplayMatchIDUI(bool isMobileReplay)
	{
	}

	private void InitUIState()
	{
	}

	private void OpenSFRoleplaySummonerAction(object[] data)
	{
	}

	public void OnTreasuryTriggerEnter(uint treasuryID)
	{
	}

	public void OnTreasuryTriggerExit()
	{
	}

	protected void OpenVehicleHudOnSceneLoaded()
	{
	}

	protected void OpenVehicleTriggerHud(object[] data)
	{
	}

	public void CacheVehicleDriverHud()
	{
	}

	protected void OpenVehicleDriverHud(object[] data)
	{
	}

	protected void OpenVehiclePassengerHud(object[] data)
	{
	}

	protected void OpenVehicleCommonHud(object[] data)
	{
	}

	protected void OpenObserverVehicleCommonHud(object[] data)
	{
	}

	public void ClearAIChatParent()
	{
	}

	public bool GetOpenObserverHudOnSceneLoaded()
	{
		return false;
	}

	protected void OpenObserverHudOnSceneLoaded()
	{
	}

	protected virtual void OnOpenUGCReviveUI(object[] data)
	{
	}

	private void ForceSkipUIPanel(object[] data)
	{
	}

	private IEnumerator ForceSkipFCO()
	{
		return null;
	}

	protected virtual void OpenObserverHud(object[] data)
	{
	}

	private void EnsureHudItemInfosCtrl()
	{
	}

	private void RefreshHudItemInfosVisible()
	{
	}

	private void OpenAIChatHud()
	{
	}

	protected virtual bool IsObserverEnabled()
	{
		return false;
	}

	public void HideHudObserver()
	{
	}

	public void ShowPOIMissionInfoCtrl()
	{
	}

	public void ShowPOIMissionTips2(string content, uint missionType, bool success, EILFEDGEAII reason)
	{
	}

	private void FirstOpenPOIMissionTips2()
	{
	}

	public void ShowPOIMissionProgressTip(string iconSpriteName, string desc)
	{
	}

	private void FirstOpenPOIMissionProgress()
	{
	}

	private void OnLocalPlayerKilled(object[] data)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	protected virtual IEnumerator OpenCommonHud()
	{
		return null;
	}

	private void OpenUIHudGameVoice()
	{
	}

	private void OpenUGCSocial()
	{
	}

	private void OnRecvUGCMessage(object[] data)
	{
	}

	private void TryPlayFictionDisclaimerCtrl(object[] data)
	{
	}

	private void OpenInventory(object[] data)
	{
	}

	private void OpenBag(object[] data)
	{
	}

	private void OpenLoadoutSupport(bool isOpen)
	{
	}

	private void OpenReinforceAnvil(bool isOpen)
	{
	}

	private void OpenAvatarAttribute(object[] data)
	{
	}

	public bool IsInventoryControllerOpen()
	{
		return false;
	}

	public void OpenSafeZoneInfoCtrl()
	{
	}

	public virtual void OpenGameTokenUI()
	{
	}

	public void OpenDriverFireHudInNeed()
	{
	}

	public void OpenPassengerSkillHudInNeed()
	{
	}

	public virtual UIBigMapController GetBigMap()
	{
		return null;
	}

	public virtual UIHudCubicMapController GetCubicMap()
	{
		return null;
	}

	public void OpenCubicMap()
	{
	}

	public void AddLocalPlayerHud()
	{
	}

	public bool CheckTriggerGrenadeShowed()
	{
		return false;
	}

	public bool CheckAuxFireShowed()
	{
		return false;
	}

	private UIBaseController OpenUI(Type uiBaseControllerType, Transform parent)
	{
		return null;
	}

	public void RefreshJetFlyHudVisibility(object[] data)
	{
	}

	private void CheckCanQuitGame()
	{
	}

	protected override void OnInit()
	{
	}

	public void InitUIHudPanel()
	{
	}

	private void TryEnableSmartAdjustRecorder()
	{
	}

	private void TryDisableSmartAdjustRecorder()
	{
	}

	public void CancelDelayCalls()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override Transform FindUIRoot()
	{
		return null;
	}

	protected Transform FindEPRoot()
	{
		return null;
	}

	private void OpenWaitingRoomEPRanking(Transform EPRoot)
	{
	}

	private void OpenMapOpenCountDown(Transform EPRoot)
	{
	}

	public void ShowDynamicPopupMessage(string message, float duration = 5f)
	{
	}

	public override void ShowPopupMessage(string message, float duration = 2f, bool forceShow = false)
	{
	}

	public void ShowCenterUpTeammateTips(string message, float duration = 2f)
	{
	}

	public void ShowLagHintPopupMessage()
	{
	}

	public void ShowPopupMessageByDepth(string message, int depth, float duration = 2f, bool force = false)
	{
	}

	public void ShowPopupMessageNoAnim(string message, float duration = 2f)
	{
	}

	public void ShowSpecialPopupMessage(GameBannerInfo info, NADDEMMBAJF z)
	{
	}

	public UIHudPopupController ShowPopupMessageWithoutAutoHide(string message)
	{
		return null;
	}

	public void ShowLowPopupMessage(string message, float duration = 2f)
	{
	}

	public void ShowCreditBehaviorPopupMessage(string message)
	{
	}

	public void ClosePopup()
	{
	}

	public void ClosePopupOnly()
	{
	}

	public bool CheckCanShowNoobPopup()
	{
		return false;
	}

	public bool IsNoobPopupBlockingPOIDisplay()
	{
		return false;
	}

	private bool ShouldUseRoomOBFreeNameHud()
	{
		return false;
	}

	private void TryAddRoomOBFreeNameHud(BHGGAEEHJCO pID, bool isLocalPlayer)
	{
	}

	private void TryRemoveRoomOBFreeNameHud(BHGGAEEHJCO pID)
	{
	}

	private void OnAddPlayer(GEvent data)
	{
	}

	public void ShowNoobPopup()
	{
	}

	private void PreloadBRTutorialCDN()
	{
	}

	public bool ShowTutorialFightWithTeammate()
	{
		return false;
	}

	public bool ShowTutorialTeammateScoreBoard()
	{
		return false;
	}

	public void ShowHackerDetectedUI(Action OnNormalMatchEnd = null, bool isHackerTeam = false)
	{
	}

	public void ShowType3VoidDrawUI(Action onConfirm = null)
	{
	}

	public void ShowChickenShowTimeUI(Action OnNormalMatchEnd = null, int rank = 0)
	{
	}

	private bool CanShowLoserAudio(int rank)
	{
		return false;
	}

	public void CloseChickenShowTimeUI()
	{
	}

	private void ShowFriendObserverQuitWnd(object[] data)
	{
	}

	private void localObserverRequestToQuit()
	{
	}

	private void OnSwitchObserver(object[] param)
	{
	}

	private void CheckStreamReady()
	{
	}

	protected virtual void CloseHUDMask()
	{
	}

	private void NotifyGsLoadingEnd()
	{
	}

	private void OnAddSpectator(object[] data)
	{
	}

	private void OnAddObserver(uint data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnRemovePlayer(uint data)
	{
	}

	private void OnUGCKickOutPlayer(object[] data)
	{
	}

	private void OnLocalPlayerDeadShowResult(object[] data)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	private bool IsCustomMatchResult()
	{
		return false;
	}

	private void OnShowMatchResult(object[] data)
	{
	}

	private bool NeedReleaseMemory(Type type)
	{
		return false;
	}

	protected virtual Type GetMatchResultType()
	{
		return null;
	}

	private void OpenMatchResultUI(bool closeAll, bool releaseMemory, Type type, bool keepScene, bool createAvatar)
	{
	}

	private void StopOpenMatchResultCorInNeed()
	{
	}

	private IEnumerator ReleaseMemoryAndOpenMatchResult(Type type, bool keepScene, bool createAvatar)
	{
		return null;
	}

	private void ReleaseResultPlayerAnim(EMKJHAJNPDH match)
	{
	}

	private static void PrintMemory(string label)
	{
	}

	protected virtual void CloseAllUIs()
	{
	}

	protected virtual void OnHudSettingChanged(object[] param)
	{
	}

	public void ChangeHudConfig(UIBaseController ctrl, string configName)
	{
	}

	public void ChangeInGamePhotoVerticalHud(UIBaseController ctrl, string configName)
	{
	}

	private void AdjustHudApperance(Type t, Transform parent, bool isDefaultConfig = false)
	{
	}

	private void AdjustSpectatorTargetHudView(UIBaseController hudCtrl, HudConfigItem refConf, float notchSize = 0f)
	{
	}

	public void ShowSpeedCtrl(bool flag)
	{
	}

	private void OnHudNormalSettingChanged(object[] param)
	{
	}

	private void OnReportCheatClick(object[] param)
	{
	}

	public UIHudReportNewController ShowHudReport(ulong userId, string name, BHGGAEEHJCO playerID, bool InGame, bool closeOnHit, UIModelReport.EReportMethod reportMethod, Action onReportConfirmed = null)
	{
		return null;
	}

	private bool SendQuickReport(ulong userId, BHGGAEEHJCO playerID)
	{
		return false;
	}

	private void OnReportFeedback(object[] param)
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void ShowBackToLobbyDialog()
	{
	}

	private void OnUIQuitGameRequest(object[] param)
	{
	}

	public void RequestQuitMatch(bool playerRequestQuit = false, bool skipConfirm = false)
	{
	}

	private void SpectaoQuitMatch(MatchGame game)
	{
	}

	private void FriendObserverQuitMatch(MatchGame game)
	{
	}

	private void FriendObserverRequestQuitMatch(MatchGame game, bool skipConfirm)
	{
	}

	private void RoomSpectatorRequestQuitMatch(MatchGame game, bool skipConfirm = false)
	{
	}

	private void ReplayQuitMatch(bool skipConfirm = false)
	{
	}

	private bool IsCurrentGameDelayExitActivated()
	{
		return false;
	}

	private void NormalPlayerRequestQuitMatch(MatchGame game, bool playerRequestQuit = false, bool skipConfirm = false)
	{
	}

	private void OnAddDetector(object[] data)
	{
	}

	public void OnOpenHGTweenTips(object[] data)
	{
	}

	private void OnOpenReceiveRewardCtrl(object[] data)
	{
	}

	public void OnOpenTweenTips(object[] data)
	{
	}

	public UIHudTweenTipsController GetTweenTipsController()
	{
		return null;
	}

	public void OnMutiTweenTips(object[] data)
	{
	}

	public void OnOpenBannerTweenTips(object[] data)
	{
	}

	private void OnOpenTweenTipsWithIcon(object[] data)
	{
	}

	private void ShowTweenTipsIcon(string message, float duration, ResourceID iconRes, int yOffset = 0, Color color = default(Color))
	{
	}

	public void HideTweenTipsWithIcon()
	{
	}

	private void OnOpenTweenTipsWithIconAndBG(object[] data)
	{
	}

	private void OnOpenTweenTipsWithIconUseEvent(GEvent data)
	{
	}

	public uint PlayExcutionEffect(ResourceID inResID, float inAutoDestroyTime, bool onTopper = true)
	{
		return 0u;
	}

	private void OnTechAirdropCreate(uint skinType)
	{
	}

	private void OnTechAirdropUnlock(object[] args)
	{
	}

	public void ShowSnowSlideGrabRotateResult(uint level)
	{
	}

	private void ShowMapThrowerTipsWithTeamIndexTips(ResourceID iconResId, int teammateIndex, string str)
	{
	}

	private void ShowMapThrowerSuccessTips(uint itemId)
	{
	}

	public void OnUseMapThrowerSuccess(BHGGAEEHJCO playerID, uint itemId, ulong uniqueID, Vector3 pos, uint objectId, OPICPDCLKAG levelObjectType)
	{
	}

	private void TryShowMapThrowerBtn()
	{
	}

	private void OnMapThrowerCountChange(object[] param)
	{
	}

	private void OnShowCrosshairsAndFireBtnEffect(GEvent gEvent)
	{
	}

	private void AttachCrosshairsAndFireBtnEffectToTarget(string targetName, ResourceID effectResID, float delayTime)
	{
	}

	private void ClearCrosshairsAndFireBtnEffect(bool needClear)
	{
	}

	private void OnTechBuildOpen()
	{
	}

	public void OpenEightsCSTrainTips(string titleString, string descString, ResourceID iconRes)
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void RefreshHUDAlphaByCameraMode()
	{
	}

	private void OnVedioRecordBeforeStartEnd(bool isSuccess)
	{
	}

	private void OnCameraModeStateChanged(int state)
	{
	}

	public void SetCameraEntryPos(bool isSkyDiving)
	{
	}

	private void OnOpenLuckyDrawBox(object[] datas)
	{
	}

	public bool CheckLuckyDrawBoxOpen()
	{
		return false;
	}

	private void OnSeafoodAddLittleGirl(object[] datas)
	{
	}

	private void OnShowItemMarkPlayerDeadBtn(object[] datas)
	{
	}

	private void OnAIChatInGameChanged(object[] data)
	{
	}

	private void OnEnterTriggerWithHud(int param1, int param2)
	{
	}

	private void OnHudLoadoutFeedbackTips(object[] data)
	{
	}

	private void ShowMissionEffect(GEvent data)
	{
	}

	private void ShowMissionEffect(ResourceID effectRes, string texRes, int customID, float duration, bool upShow = false, bool useNewEffect = false, float uvx = 0f, float uvy = 0f)
	{
	}

	public void OnLocalTeamFinishGame(object[] data)
	{
	}

	protected virtual void SetEmotionPanelVisible(object[] param)
	{
	}

	private void CloseEmotionPanel(object[] param)
	{
	}

	private void SetMessagePanelVisible(object[] param)
	{
	}

	private void SetVoiceToTextPanelVisible(object[] param)
	{
	}

	private void CloseMessagePanel(object[] param)
	{
	}

	private void SetRouletteChatPanelVisible(object[] param)
	{
	}

	private void SetRouletteMedkitPanelVisible(object[] param)
	{
	}

	private void SetRouletteMapThrowerPanelVisible(GEvent param)
	{
	}

	private void SetRouletteGrenadePanelVisible(GEvent param)
	{
	}

	private UIHudVehicleAsMissileTargetControllerBase OpenVehicleTargetUIInNeed(Entity e)
	{
		return null;
	}

	private T OpenVehicleUIInNeed<TKEY, T>(TKEY v, ref Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
	{
		return null;
	}

	private TB OpenVehicleUIInNeed<TKEY, T, TB>(TKEY v, ref Dictionary<TKEY, TB> uis) where TKEY : Entity where T : TB where TB : UIHudVehiclePosControllerBase
	{
		return null;
	}

	private T GetVehicleUI<TKEY, T>(TKEY v, Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
	{
		return null;
	}

	private void RecycleVehicleUI<TKEY, T>(TKEY v, T ui, Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	private void CheckAndAddVehiclePosUIForPlayer(Player player)
	{
	}

	public void RecycleVehiclePosUI(Vehicle v, UIHudVehiclePosController ui)
	{
	}

	private void OnMissileTargetChange(object[] data)
	{
	}

	private void OnMissileAimingTargetChange(object[] data)
	{
	}

	public void RecycleMissileTargetUI(Entity v, UIHudVehicleAsMissileTargetControllerBase ui)
	{
	}

	public void ShowInGameMovingStick(bool flag)
	{
	}

	public void SetVisibleInGameMovingStick(uint flag, bool value)
	{
	}

	private void ShowReconnectTip(bool show)
	{
	}

	public void OnMatchResultScreenshotRequest(object[] data)
	{
	}

	private void OnLocalPlayerHitOthers(GEvent data)
	{
	}

	protected virtual void OnHandleLocalPlayerHitOther(BHGGAEEHJCO damager, BHGGAEEHJCO target)
	{
	}

	private void OnLocalPlayerHitObjects(object[] data)
	{
	}

	private void OnLocalPlayerHitPosition(object[] data)
	{
	}

	public void RecycleEnemyHudName(BHGGAEEHJCO id)
	{
	}

	protected virtual void AddTeammateHud(BHGGAEEHJCO id)
	{
	}

	public UIHudNameController GetTeamHudByPlayerID(BHGGAEEHJCO id)
	{
		return null;
	}

	private void RefreshTeammateHud(Dictionary<BHGGAEEHJCO, Player> teammates)
	{
	}

	public void RecycleTeammateHudName(BHGGAEEHJCO id)
	{
	}

	public void SetTeamMateHudNameWeaponPowerVisibility(bool flag)
	{
	}

	public void DestroyTeamMateHudNameWeaponPower()
	{
	}

	protected virtual void OnPlayerFactionChanged(object[] param)
	{
	}

	private void OnPlayerIdentityChanged(object[] param)
	{
	}

	public void RefreshIdentityHud(BHGGAEEHJCO id)
	{
	}

	private void BindIdentityHud(BHGGAEEHJCO id)
	{
	}

	public void RecycleIdentiyHud(BHGGAEEHJCO id)
	{
	}

	public void BindLocalPlayerWeaponPowerIconHud(BHGGAEEHJCO id)
	{
	}

	public void RecycleWeaponPowerIconHud(BHGGAEEHJCO id)
	{
	}

	public void RefreshInfectionHPHud(BHGGAEEHJCO id)
	{
	}

	private void BindInfectionHPHud(BHGGAEEHJCO id)
	{
	}

	public void RecycleInfectionHPHud(BHGGAEEHJCO id)
	{
	}

	private void RefreshEnermyPoint(object[] data)
	{
	}

	private void ClearSelfBeMarkIceWallPoint()
	{
	}

	private void CancelClearBeMarkIceWallPointDelayCall()
	{
	}

	private void RefreshSantinoDummyBombMarkEnemyPoint(object[] data)
	{
	}

	private void RefreshCuringEnemyPoint(object[] data)
	{
	}

	public void RefreshBanAvtiveSkillPoint(object[] data)
	{
	}

	public void RecycleBanAvtiveSkillPoint(BHGGAEEHJCO id)
	{
	}

	public void ClearAllMarkIceWallNearbyEnemyPoint(object[] data)
	{
	}

	public void ShowScannerMarkerEnemyPoint(BHGGAEEHJCO playerID, int endTime)
	{
	}

	public void RefreshDeliverySkillMarkEnemyPoint(object[] data)
	{
	}

	public void ShowDeliveryMarkEnemyPoint(object[] data)
	{
	}

	public void RecycleDeliveryMarkEnemyPoint(BHGGAEEHJCO id)
	{
	}

	public void RecycleScannerMarkerEnemyPoint(BHGGAEEHJCO id)
	{
	}

	public void RecycleIceWallNearbyEnemyPoint(BHGGAEEHJCO id)
	{
	}

	public void RecycleSantinoDummyBombMarkbyEnemyPoint(BHGGAEEHJCO id)
	{
	}

	public void RecycleEnermyPoint(BHGGAEEHJCO id)
	{
	}

	public void RecycleCuringEnemyPoint(BHGGAEEHJCO id)
	{
	}

	public void RefreshRevengeInfoPoint(BHGGAEEHJCO playerID, bool visible)
	{
	}

	public void RecycleRevengeInfoPoint(BHGGAEEHJCO id)
	{
	}

	private void RecycleSlowdownMarkEnemyPoint(BHGGAEEHJCO id)
	{
	}

	private void OnSlowDownMarkShow(object[] data)
	{
	}

	private void ShowSlowDownMarkEnemyPoint(uint playerId, int endTime)
	{
	}

	internal void RemoveNameHud(BHGGAEEHJCO id)
	{
	}

	private void ShowAirEPTopPlayer(object[] param)
	{
	}

	private void HideMiniRank(object[] param)
	{
	}

	private void ShowHudElitePass(object[] param)
	{
	}

	protected virtual void OnJoinMatchFinished()
	{
	}

	public void OnRedEnvelopeUsed(object[] param)
	{
	}

	public bool GetRedEnvelopeOwner(BHGGAEEHJCO pid, out UIHudNameRedEnvelopeOwnerController ctrl)
	{
		ctrl = null;
		return false;
	}

	public void OnRedEnvelopeReceived(object[] param)
	{
	}

	public void OnRedEnvelopeReceiveHudDismiss(object[] param)
	{
	}

	private void OnRedEnvelopeClose()
	{
	}

	public void OnHypeRelatedPlayerHit(BHGGAEEHJCO pID, int level)
	{
	}

	private void OnAddPet(object[] data)
	{
	}

	public void OnPreloadLoaded(object[] data)
	{
	}

	private void CheckToCloseHUDMask()
	{
	}

	private void OnJoinedVoiceRoom(object[] data)
	{
	}

	private void OnNotifyBeHinted(object[] data)
	{
	}

	private void OnPVEBuyReviveSuccess(object[] param)
	{
	}

	private void OnPlayerLanding(object[] param)
	{
	}

	private void HidePVEReviveUI(object[] param)
	{
	}

	protected virtual void OnPlayerGodBegin(object[] param)
	{
	}

	public void DisableMask()
	{
	}

	private void ShowBlackMaskAnim(object[] param)
	{
	}

	protected void ShowObserverLeaderboard(object[] data)
	{
	}

	protected void ShowLeaderboard(object[] data)
	{
	}

	public void SetDelayShowCSShopTime(float time)
	{
	}

	public float GetDelayShowCSShopTime()
	{
		return 0f;
	}

	protected virtual void ShowCSShop(object[] data)
	{
	}

	protected virtual void ShowCSShopProcess()
	{
	}

	protected virtual void ShowCSShopEntryProgress()
	{
	}

	private void OnMysteryBoxOpen(object[] data)
	{
	}

	private void OnQTEUnFreeze(object[] param)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	protected virtual void OnInGameShopItemsReady()
	{
	}

	protected virtual void OnInGameBountyBoxShopItemsReady(object[] data)
	{
	}

	private void OnInGameAidDropShopItemsReady(object[] data)
	{
	}

	private void OnInGamePersonalShopItemsReady()
	{
	}

	private void OnInGameMapThrowerOpen(bool show)
	{
	}

	private void OnInGameBomberMakerOpen(bool show)
	{
	}

	private void OnRangeShopShowed(object[] data)
	{
	}

	protected void OnCatagoryRangeShopShowed(object[] data)
	{
	}

	private void OnCatagoryRangeShopHided()
	{
	}

	public bool TryOpenCacheShop(uint ShopID)
	{
		return false;
	}

	protected void OnShowPortalMask(object[] data)
	{
	}

	private void OnShowWarningZone(object[] data)
	{
	}

	private void OnResetInGameShopUI(object[] data)
	{
	}

	private void OnShowReviveSelect(object[] data)
	{
	}

	private void OnShowRevivePoint(object[] param)
	{
	}

	private void OnShowCSAirdropGenerator(object[] param)
	{
	}

	private void OnHideCSAirdropGenerator(object[] param)
	{
	}

	private void OnShowCSItemGenerator(object[] param)
	{
	}

	private IEnumerator ShowCSItemGenerator(List<LevelObjectItemGenerator> data)
	{
		return null;
	}

	private void OnDestroyCSItemGenerator(object[] param)
	{
	}

	private void OnUsedCSItemGenerator(object[] param)
	{
	}

	private void OnShowAffixPop(object[] param)
	{
	}

	private void OnShowAuroroInteractPop(uint param)
	{
	}

	private void OnShowCSRoundDragon(object[] param)
	{
	}

	private void OnDestroyCSRoundDragon(object[] param)
	{
	}

	private void OnShowLevelObjInteractArea(object[] param)
	{
	}

	public void BatchShow2NBGPBloodMoonAirdropPosMarks(List<MBCMIEOCLKK> spawnedNearbyAirdrops)
	{
	}

	public void RemoveAll2NBGPBloodMoonAirdropPosMarks()
	{
	}

	private void OnShowEnergyDeviceInteract(object[] param)
	{
	}

	private void OnShowLockAirDropInteract(object[] param)
	{
	}

	public void RemoveAirdropMulPointMark(uint id)
	{
	}

	public void RemoveRevivePointMark(uint id)
	{
	}

	public bool TryPlayFightingEffect(FightingEffectCategory category, uint objectId, Transform attachNode)
	{
		return false;
	}

	private void PlayFightingStartEffect(Transform attachNode)
	{
	}

	private void OnInteractAreaStateChanged(GEvent param)
	{
	}

	private void OnInteractAreaTimeChanged(GEvent param)
	{
	}

	private void OnAirDropIntStateChanged(object[] param)
	{
	}

	private void OnAirDropIntStepChanged(object[] param)
	{
	}

	private void OnAirDropIntTimeChanged(object[] param)
	{
	}

	private void OnRevivePointStateChanged(object[] param)
	{
	}

	private void OnRevivePointTimeChanged(object[] param)
	{
	}

	private void OnRevivePointAdvancedChanged(object[] param)
	{
	}

	public bool SendInGameSticker(uint itemID, uint stickerID)
	{
		return false;
	}

	private void OnShowInGameChat(object[] data)
	{
	}

	private void OnRecvGiveMeFiveStickerResult(object[] data)
	{
	}

	private void HandleGiveMeFiveStickerFailed(BHGGAEEHJCO playerID)
	{
	}

	private void HandleGiveMeFiveStickerSuccess(MBEOKFCJHAH msg)
	{
	}

	private bool IsLocalPlayerInGiveMeFiveStickerResult(MBEOKFCJHAH msg)
	{
		return false;
	}

	public void HighlightTeammatesPendingReviveBoxes()
	{
	}

	public bool TryHighlightPlayerReviveBox(BHGGAEEHJCO playerID, bool addBigMapMark)
	{
		return false;
	}

	private bool TryGetPlayerReviveBox(NAHFMFGGCDN levelObjectMgr, BHGGAEEHJCO playerID, out LevelReviveBox reviveBox)
	{
		reviveBox = null;
		return false;
	}

	private ResourceID GetReviveBoxIconHighlightResID()
	{
		return default(ResourceID);
	}

	private void PlayReviveBoxMapIconHighlight(uint reviveBoxID, ResourceID highlightResID)
	{
	}

	private void AddReviveBoxBigMapMark(LevelReviveBox reviveBox)
	{
	}

	private void OnShowCabinWaitingChat(object[] data)
	{
	}

	private bool CanShowCabinWaitingChat(IFMLBFHBFCM quickChatRes, out bool isTeamFlightChat)
	{
		isTeamFlightChat = default(bool);
		return false;
	}

	private void SetLobbyContainerState(bool state)
	{
	}

	private void OnShowAddFriendInfo(object[] data)
	{
	}

	private void HideHighlightTargetPlayer()
	{
	}

	public void OnHandleFriendAddInGame()
	{
	}

	public void OpenInGameAddFriendInviteTipsBox(AccountBriefInfo info)
	{
	}

	public void ShowInviteFriendInfo(ulong user_id)
	{
	}

	public void ShowInviteFriendInfoInBattle(ulong user_id)
	{
	}

	private void OnAddFriendAcceptInvite(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnAddFriendDisAgreeInvite(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnAddFriendToggleChange(UIHudCommonChooseBoxController ctrl)
	{
	}

	public void OnShowDriftBottleAddFriend(object[] param)
	{
	}

	private void OnTrainingZoneChanged(object[] data)
	{
	}

	private void RefreshTeammateNameVisible(Player lp)
	{
	}

	private void RefreshPlayerRemainingVisble(NADDEMMBAJF z)
	{
	}

	private void ShowEnterTrainingZoneTip(NADDEMMBAJF z)
	{
	}

	private void OnOniBossComing(object[] datas)
	{
	}

	private void ShowBeachBallGoalVFX()
	{
	}

	private void OnGetOniCoinBuff(object[] datas)
	{
	}

	private void OnEarnMoneyOniQuestPop(uint data)
	{
	}

	private void OnTrainingShopBuySucess(object[] data)
	{
	}

	private void OnBountyBoxShopItemGet(object[] data)
	{
	}

	private void OnGameOpeningStart(object[] data)
	{
	}

	public void UpdateInteractionCD()
	{
	}

	private void OnShowScenesForCabinePhase(object[] data)
	{
	}

	private void ShowAssistantPosMarks(bool show)
	{
	}

	public void RefreshTeamParachuteActionBtn()
	{
	}

	private void OnGameOpeningEnd(object[] data)
	{
	}

	public bool IsGlobalMissionTutorialDataReady(out uint tutorialAffixID, out uint[] pickSourceAffixIDs)
	{
		tutorialAffixID = default(uint);
		pickSourceAffixIDs = null;
		return false;
	}

	private void OnGameGlobalMissionTutorialStart(object[] data)
	{
	}

	private void ProcessGlobalMissionTutorial(float scrollTime, float autoCloseDelayTime)
	{
	}

	private void OnGlobalMissionTutorialClose(object[] param)
	{
	}

	private bool DisableGameOpenSound()
	{
		return false;
	}

	private void OnGameOpeningPlaySound(object[] data)
	{
	}

	private void OnUnloadUnusedAudios(bool data)
	{
	}

	public void ShowEventTriggerUIWithPlayer(BHGGAEEHJCO id, InGameTriggerMaskData data)
	{
	}

	public void ClearEventTriggerUIWithPlayer(BHGGAEEHJCO id, InGameTriggerMaskData data)
	{
	}

	public void FlashEventTriggerUIWithPlayer(BHGGAEEHJCO id)
	{
	}

	public bool CheckPrepareIsIng()
	{
		return false;
	}

	public EPreparationTimerType GetPrepareContextType()
	{
		return EPreparationTimerType.None;
	}

	private Dictionary<BHGGAEEHJCO, UIHudItemMarkShowController> GetMarkDic(EMEFBBBEPDG itemMarkType)
	{
		return null;
	}

	public void ShowMarkItemUIWithWorldPosition(BHGGAEEHJCO id, EMEFBBBEPDG itemMarkType, string markName, uint itemMarkId, uint levelObjectId, Vector3 itemPosition, bool playMarkSound = true)
	{
	}

	public void RemoveMarkItemShow(BHGGAEEHJCO id, EMEFBBBEPDG itemMarkType, uint itemMarkId, uint levelObjectId)
	{
	}

	public void TryRemoveMarkItemShow(EMEFBBBEPDG itemMarkType, uint levelObjectId)
	{
	}

	public void ForceRemoveMarkItemShow(BHGGAEEHJCO id, bool dontHideTeammateMapMark = false)
	{
	}

	public void ShowMarkItemChooseListWindow(LevelContainerBase container)
	{
	}

	public void ShowMarkItemChooseListWindow(FHMPPFHPBND lcontainer)
	{
	}

	public void ShowAssistantText(string playerName, string line)
	{
	}

	public void ShowEventTriggerUIWithWorldPosition(Vector3 followObjectPosition, InGameTriggerMaskData data)
	{
	}

	public GameObject GetSpeedUpCollider()
	{
		return null;
	}

	public virtual void HideCSShop()
	{
	}

	public bool IsCSShopEntryVisible()
	{
		return false;
	}

	private void HideCSShopAfterPrepare()
	{
	}

	private void HideBattleBoardAfterPrepare()
	{
	}

	private bool NeedUseNewRoundTransition()
	{
		return false;
	}

	protected void ShowCSRoundResult(object[] data)
	{
	}

	private void OnCommonCoinsGotForBonusInfo(int cnt, int reason)
	{
	}

	public bool NeedShowBattleBoard()
	{
		return false;
	}

	protected void ShowCSRoundSpectatorResult(object[] data)
	{
	}

	private void OnSpectatorPlayerFlashed(object[] data)
	{
	}

	private void OnRefreshKokPlayer(object[] data)
	{
	}

	private void OnShowKokPlayer(object[] data)
	{
	}

	private void OnShowHalloweenBossHp(object[] data)
	{
	}

	private void OnHitHalloweenBossHp(object[] data)
	{
	}

	private void OnShowWhiteScreen(object[] ps)
	{
	}

	public T GetUIControllerFromPool<T>(EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
	{
		return null;
	}

	public T GetUIControllerFromPoolAsChild<T>(Transform parent, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
	{
		return null;
	}

	public T GetUIControllerFromPoolNoCreate<T>() where T : UIBaseController
	{
		return null;
	}

	public void RecycleUIController<T>(T uicontroller) where T : UIBaseController
	{
	}

	private void PrePoolUIController<T>(int count = 1) where T : UIBaseController
	{
	}

	public virtual void ClearNoNeedUIInUIPoolWhenCabinWaitingEnd()
	{
	}

	private void CleanupInGameUIPoolOnDestroy()
	{
	}

	protected void ShowEquipSetSelection(object[] param)
	{
	}

	protected void ShowEquipSetSelectionBtn(bool param)
	{
	}

	protected void OnSelectEquipSet(object[] param)
	{
	}

	private void ShowOrHideAllUI(object[] param)
	{
	}

	private void OnSecondConfirmShowed(object[] param)
	{
	}

	public void CheckPreloadRescureZoneSkillHud(BHGGAEEHJCO playerID)
	{
	}

	private void CreateUseRescureZoneProcess(bool hide)
	{
	}

	private void OnShowUseRescureZoneProcess(object[] data)
	{
	}

	private void OnShowHealingGunScreenEffect(object[] data)
	{
	}

	private void OnShowInfectionChangePanel(object[] data)
	{
	}

	private void OnCloseInfectionChangePanel(object[] data)
	{
	}

	private void OnShowInfectionStrongerToturial(object[] data)
	{
	}

	private void OnSelfIdentityChanged(object[] data)
	{
	}

	private void OpenLocalEventPanel(object[] data)
	{
	}

	private void OpenGlobalEventPanel(bool data)
	{
	}

	private void ShowPollEntry(object[] data)
	{
	}

	private void OpenGlobalEventPoll(object[] data)
	{
	}

	public ResourceID GetDamageNumResId()
	{
		return default(ResourceID);
	}

	public ResourceID GetDamageNumResId(int damageType)
	{
		return default(ResourceID);
	}

	public GameObject GetDamageNumObject(Transform root = null)
	{
		return null;
	}

	public void RecycleDamageNumObject(GameObject numObject, bool useRecycleResID = false, int damageType = 0)
	{
	}

	private void PreLoadDamageNumObject()
	{
	}

	private void PreInstantHudName()
	{
	}

	public bool GetPickUpInScroll()
	{
		return false;
	}

	public int GetPickUpListGridDepth()
	{
		return 0;
	}

	protected virtual UIHudWeaponInfoController OpenCommonWeaponPanel()
	{
		return null;
	}

	protected virtual UIHudWeaponSwitchController OpenCommonWeaponSwitchPanel()
	{
		return null;
	}

	protected virtual UIHudWeaponInfoUpgradeController OpenCommonWeaponUpgradePanel()
	{
		return null;
	}

	public UIHudHippoCrisisEquipmentContainerController GetHCBagCtrl()
	{
		return null;
	}

	protected virtual bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected virtual bool IsNeedQuickSwitchHUD()
	{
		return false;
	}

	protected virtual bool IsNeedMedkitController()
	{
		return false;
	}

	protected virtual bool IsNeedSideWeapon()
	{
		return false;
	}

	protected virtual bool IsNeedPlayerStats()
	{
		return false;
	}

	protected virtual bool IsNeedSafeZoneInfoController()
	{
		return false;
	}

	protected virtual bool IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	public virtual void ShowCommonEquipSelectionController(bool show, int defaultSelectIndex, float showTime)
	{
	}

	public virtual void ShowEquipUnlockLevelController(bool show, float showTime)
	{
	}

	public virtual void ShowTeamKill(float showTime)
	{
	}

	public virtual float GetMatchEndDelay()
	{
		return 0f;
	}

	public void ShowPlayerAttributeUP(string msg)
	{
	}

	public void GamePhaseChange(uint curPhase, float leftTime, bool isExitPregame)
	{
	}

	protected virtual void OnGamePhaseChange(uint curPhase, float leftTime)
	{
	}

	private void OpenHudInPregame()
	{
	}

	private void CloseHudInPregame()
	{
	}

	protected virtual void OnOpenHudInPregame()
	{
	}

	protected virtual void OnClosePregameHud()
	{
	}

	protected virtual void OnOpenHudBeginFight()
	{
	}

	protected virtual Type GetMatchEndShowHUD()
	{
		return null;
	}

	protected bool NeedUseNewVictory()
	{
		return false;
	}

	public void AdjustChatHudByCustomRoomSetting(bool show)
	{
	}

	protected virtual bool ShowChatBtn()
	{
		return false;
	}

	protected virtual bool ShowItemMarkBtn()
	{
		return false;
	}

	public void AdjustHudByCustomRoomSetting(bool visibility)
	{
	}

	private void UpdateActionHudPos()
	{
	}

	private void UpdateCSRoundBonusHudPos()
	{
	}

	public void ShowOrHideEnterPhotographModeController(bool isShow)
	{
	}

	private void UpdateEnterPhotographModeControllerPosition()
	{
	}

	public void ShowOrHidePhotographModeController(bool isShow)
	{
	}

	public void RefreshCurActiveGroup(bool immediate = false)
	{
	}

	public void SetActiveGroup(EUIGroup groupName, bool immediate = false, bool isForceRefresh = false)
	{
	}

	public void SetActiveGroup(EUIGroupHigh groupName, bool immediate = false, bool isForceRefresh = false)
	{
	}

	public override void SetActiveGroup(ulong InActiveGroup, bool immediate = false, bool isForceRefresh = false, byte groupSort = 0)
	{
	}

	public void ShowOrHidePhotographEmotePanel(bool isShow)
	{
	}

	public virtual ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	private void OnTeamParachuteStateChange(object[] param)
	{
	}

	public void ShowTeamFlightTip(bool isOwner)
	{
	}

	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	private void OnTutorialCSGamePaused(object[] param)
	{
	}

	protected virtual void OnGamePaused(object[] param)
	{
	}

	private void AddHudForSpectator()
	{
	}

	private void UpdateSpectatorHudVisible(UIBaseController ctrl)
	{
	}

	private void OnSpectatorShowTargerPlayerHud(object[] param)
	{
	}

	private void OnSpectatorCameraTypeSwitch(object[] param)
	{
	}

	public void UpdateSpectatorTargerHudPos()
	{
	}

	private void UpdateSpectatorTargerHudFromConfig(Dictionary<string, HudConfigItem> defaultHudDic, Dictionary<string, HudConfigItem> changedHudDic, float notchSize = 0f)
	{
	}

	private void ResetSpectatorTargetPosWhenCabinEnd()
	{
	}

	public void OnSightingStateChanged(object[] data)
	{
	}

	private void OnShowCommonBottomTips(GEvent evt)
	{
	}

	private void OnRequestGameResumeConfirm(object[] param)
	{
	}

	private void OnSnowSlideItemPickup(object[] data)
	{
	}

	private void OnSafezoneCheckDamageChanged(object[] data)
	{
	}

	private void OnShowSafezonePosMark(bool show)
	{
	}

	private void OnShowPreset(bool data)
	{
	}

	private void OnShowPresetMsg(object[] data)
	{
	}

	private void OnShowPresetEntry(bool data)
	{
	}

	private void ShowKeyActionSetting()
	{
	}

	private void ShowHardwareInputGuide(object[] data)
	{
	}

	protected virtual bool ShowTeammateInfo()
	{
		return false;
	}

	protected virtual void OnGameVoiceHudCreated()
	{
	}

	public virtual string GetDefeatEndShowKey()
	{
		return null;
	}

	public virtual void TryCloseBigMap()
	{
	}

	public virtual void SetBigMapActive(bool b)
	{
	}

	public virtual void SetBigMapTips(string key = "")
	{
	}

	public void OnMuteVoiceChange(bool mute)
	{
	}

	public void OnMuteQuickChatChange(bool mute)
	{
	}

	public void OnAddScanEnemyCircle(MFGNCIMCEAD msg)
	{
	}

	public void OnAddScanEnemyCircle(HIPBDDBPLEB msg)
	{
	}

	public void OnAttackStatusChange(Player.AALGCBFJHJM value)
	{
	}

	public void DestroyEnemyAndMyselfLeaderboardTitle()
	{
	}

	public void UnbindEnemyAndMyselfLeaderboardTitle()
	{
	}

	public void DeactiveTeammatesLeaderboardTitle()
	{
	}

	public void OnJumpStatusChange(Player.AALGCBFJHJM value)
	{
	}

	public void OnDriveStatusChange(Player.AALGCBFJHJM value)
	{
	}

	public void OnGetOnDriveStatusChange(Player.AALGCBFJHJM value)
	{
	}

	public void OnGetOffDriveStatusChange(Player.AALGCBFJHJM value)
	{
	}

	public void OnOpeDriveStatusChange(Player.AALGCBFJHJM value)
	{
	}

	public void OnUGCFactionChanged(object[] data)
	{
	}

	public void OnUGCTeamChanged(object[] data)
	{
	}

	public void OnLocalTeamChanged(object[] data)
	{
	}

	private void RefreshLobbyGroupTeammate()
	{
	}

	private void RefreshLocalPlayerTeammateNameVisible()
	{
	}

	public void SetControlBtnBlock(object[] data)
	{
	}

	private static void OnScreenShot(object[] data)
	{
	}

	public virtual Transform GetDynamicAnchor(EUIAnchor anchor)
	{
		return null;
	}

	public virtual bool UsePlayerUpMiniMap()
	{
		return false;
	}

	public void SyncRoundShopBuff(DMEHKOLOGME msg)
	{
	}

	public Dictionary<int, uint> GetRoundShopBuffMap()
	{
		return null;
	}

	public virtual void OnAddPlayer(Player playerID)
	{
	}

	private void OnHudSearchMarkShow(GEvent data)
	{
	}

	private void OnHudEasterEggTelescopeShow(GEvent data)
	{
	}

	private void OnHudFloatingLandEnter(object[] data)
	{
	}

	private void OnHudFloatingLandWait(object[] data)
	{
	}

	private void OnHudFloatingLandIcon(object[] data)
	{
	}

	private void OnHudCSSpecialRoundShowMask(object[] data)
	{
	}

	private void OnHudCSTrainRoundShowMask(object[] data)
	{
	}

	public void PlayBRCutSceneSound()
	{
	}

	public ResourceID GetBRChangePhaseCutSceneShowMaskResourceID()
	{
		return default(ResourceID);
	}

	public GameObject OpenBRChangePhaseCutSceneShowMask()
	{
		return null;
	}

	public void CloseBRChangePhaseCutSceneShowMask(GameObject mask)
	{
	}

	public ResourceID GetBRChangePhaseCutSceneShowMaskResourceIDIn()
	{
		return default(ResourceID);
	}

	public void OpenBRChangePhaseCutSceneShowMaskIn()
	{
	}

	public void CloseBRChangePhaseCutSceneShowMaskIn()
	{
	}

	private void OnShowMedkitHighLight()
	{
	}

	protected virtual Type BRScoreBoardType()
	{
		return null;
	}

	public static void UpdateScoreBoardInfoTitle(UILabel infoTxt, EMatchResultPlayerInfoType infoType)
	{
	}

	private void ShowAirTransporterNameHud(object[] data)
	{
	}

	private void OnStartMatchendShow(object[] data)
	{
	}

	protected virtual bool IsGameModeVehicleExist()
	{
		return false;
	}

	protected virtual bool IsGameModeNeedSkySurfing()
	{
		return false;
	}

	protected virtual bool IsGameModeNeedCannon()
	{
		return false;
	}

	protected virtual void OnPreOpenMatchResult()
	{
	}

	public FNJJOALKJOC GetObserverAssistantManager()
	{
		return null;
	}

	private void ShowMicInfo(object[] data)
	{
	}

	private void ShowSpeakerInfo(object[] data)
	{
	}

	private void OnUGCCameraChanged(int ugcType)
	{
	}

	private void OnHudSwingVisible(bool flag)
	{
	}

	private void OnHudTowVisible(bool flag)
	{
	}

	public void OpenReviveNotify(int reviveCardID, string useRevivePlayerName, string customKey = "")
	{
	}

	public void CheckAndOpenReviveNotify(int reviveCardID, string useRevivePlayerName, string customKey = "")
	{
	}

	public UIHudLeaderBoardTitleController GetUIHudWeaponPowerIconController()
	{
		return null;
	}

	public void ResetWeaponPowerDepth()
	{
	}

	private void OnRestrictedAreaScreenVFXChanged(bool visible)
	{
	}

	private void RefreshRestrictedAreaScreenEffect(bool playerIsInRestrictedArea)
	{
	}

	private void CleanRestrictedAreaScreenEffect()
	{
	}

	public void ShowBattleLevelSelectBuildPopup(int selectBuildPhaseEndTime)
	{
	}

	public void CloseBattleLevelSelectBuildPopup()
	{
	}

	public UIHudBattleLevelDetailTipsPopupWndController ShowBattleLevelDetailTipsTeamScoreBoard()
	{
		return null;
	}

	public void TryHideBattleLevelDetailTipsTeamScoreBoard()
	{
	}

	private void CleanBattleLevelRelatedUnderScene()
	{
	}

	public void ShowDragonTaskEndResult()
	{
	}

	private void CloseDragonLoading()
	{
	}

	private void OnDragonBossSpawn(object[] data)
	{
	}

	private void OnDragonTaskStateChanged(object[] data)
	{
	}

	private void ClearUIForDragonTask()
	{
	}

	private void OnDragonTaskShowResult()
	{
	}

	private void CloseUIBeforeShowMatchResult()
	{
	}

	public bool IsGameplayModifierVisibleOnMinimap()
	{
		return false;
	}

	public UIHudGameplayModifierCarouselItemViewData.Source GetGameplayModifierCarouselStateOnMinimap()
	{
		return UIHudGameplayModifierCarouselItemViewData.Source.None;
	}

	public void ShowUIHudKillNotificationByType(EUIHudKillNotification type, BHGGAEEHJCO killerID, BHGGAEEHJCO beKilledID, bool isAceTeam, bool isCounterAttack = false, uint skinID = 0u)
	{
	}

	public EUIHudKillNotification GetUIHudKillNotificationType(BHGGAEEHJCO victimPlayerID)
	{
		return EUIHudKillNotification.EUIHudKillNotification_Normal;
	}

	private bool IsDefaultKillNotificationNeedByOverride(int killStack, bool isTargetPlayerKill, BHGGAEEHJCO victimPlayerID)
	{
		return false;
	}

	public bool IsDefaultKillNotificationTakeCharge(byte killFlags, int killStack, bool isTargetPlayerKill, BHGGAEEHJCO victimPlayerID, uint inWeaponSkinID = 0u)
	{
		return false;
	}

	public void TryShowToxicBehaviorWarningWnd()
	{
	}

	public void TryShowFriendlyReminderWarningWnd(MNHOFPLNPBN msg)
	{
	}

	public void TryShowVoiceReportWnd(EWarningWndType wndType, string nickname = "")
	{
	}

	public void ForceCloseToxicBehaviorWarningWnd()
	{
	}

	private void OnEliteHpInfoChange(object[] data)
	{
	}

	private void OnEliteDead(uint playerID)
	{
	}

	private void OnOpenHypercrateDistanceInfo(GEvent data)
	{
	}

	private void OnOpenTreasuryInfo(object[] data)
	{
	}

	private void OnShowGameGlobalMissionKingVfx()
	{
	}

	private void OnGameGlobalMissionKingVfxCallBack(uint uniqueid, ResourceID vfxresid, GameObject go)
	{
	}

	private void CloseUIWhenMatchEnd()
	{
	}

	private void ShowCancelRemoteRescueBtn(bool value)
	{
	}

	private void OnOpenRegionRankList()
	{
	}

	public void RegisterShopAndCloseConflicted(UIBaseController currentDisplayedShopCtrl)
	{
	}

	private void OnReviveMissionStart(object[] data)
	{
	}

	private void OnReviveMissionEnd(object[] data)
	{
	}

	private void OnShowChooseSkill(object[] data)
	{
	}

	public void OpenBotAgentMask()
	{
	}

	public void CloseBotAgentMask()
	{
	}

	private void OnShowWinterLand25CabinTopTip(bool isShow)
	{
	}

	private void OnShowVBadgeCabinBroadcast(bool isShow)
	{
	}

	private void OnShowCommonCabinTopTip(object[] param)
	{
	}

	private void DetachCommonCabinTopTip()
	{
	}

	private void RefreshReviveMissionWhenObserverChange(Player player)
	{
	}

	public void AddForbidPlayer(BHGGAEEHJCO playerID)
	{
	}

	public void RemoveForbidPlayer(BHGGAEEHJCO playerID)
	{
	}

	public bool IsContainsForbidedPlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	private void OnPlayerKnockdownStateChange(uint param)
	{
	}

	private void OnPlayerDead(object[] param)
	{
	}

	private void ClearPlayerChatBox(BHGGAEEHJCO playerID)
	{
	}

	public void RemovePlayerChatBox(BHGGAEEHJCO playerID, UIHudChatBoxController ctrl)
	{
	}

	private void ClearPlayerChatBox3D(BHGGAEEHJCO playerID)
	{
	}

	public void Show3PLeaderboardTitle(BHGGAEEHJCO playerID, bool isLeaderboardTitle)
	{
	}

	private static bool PhysicsCheckIgnoreWeaponShile(Collider col)
	{
		return false;
	}

	public void ShowLocalPlayerLeaderboardTitle(bool isLeaderBoardTitle)
	{
	}

	public void ShowElectricGirlAimTargetUI(CBLDEJMDIFE skill)
	{
	}

	public void HideElectricGirlAimTargetUI()
	{
	}

	public void ShowTeleportKnockDownScanResultUI(GIDJFFAEINE skill, List<uint> scanResult)
	{
	}

	public void HideTeleportKnockDownScanResultUI()
	{
	}

	public void ShowAuroraBoySkillUI(LGONIIMINHO skill)
	{
	}

	public void HideAuroraBoySkillUI()
	{
	}

	protected virtual Type GetMiniMapInZoneStateUIType()
	{
		return null;
	}

	protected void OnInZoneStateCome(uint inZoneType)
	{
	}

	protected override bool OnCheckGroupNtf()
	{
		return false;
	}

	private bool TryProcessInGameResultInvite(object[] data)
	{
		return false;
	}

	private void OpenInGameResultInviteTipsBox(object ntfData, bool isReceivedInMatchResult)
	{
	}

	public void OpenRematchInvitePopup()
	{
	}

	public void CloseRematchInvitePopup()
	{
	}

	public void SaveRematchInviteIgnoreTodayIfChecked()
	{
	}

	private void ShowPendingMixGroupMessagesAsInvitationTipsBox()
	{
	}

	private bool IsMatchResultOrSpectatorInviteJoinRequest(object[] data)
	{
		return false;
	}

	protected override void ProcessInviteTipImmediately(object[] data)
	{
	}

	public void TryShowInGameGroupInviteOrJoinRequestBox(object[] data)
	{
	}

	private void ShowInGameGroupInviteBox(GroupInviteNtf inviteNtfData)
	{
	}

	private void OnInGameAcceptGroupInvite(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnInGameAcceptGroupInviteRequestPresenceNtfCallBack()
	{
	}

	public void OnInGameAcceptGroupInvite(GroupInviteNtf groupInviteNtf)
	{
	}

	private void OnInGameRejectGroupInvite(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnInGameGroupInviteTimeOut(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnInGameGroupInviteToggleChange(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void ShowInGameGroupJoinRequestBox(GroupJoinRequestNtf joinRequestNtfData)
	{
	}

	private void OnInGameAcceptGroupRequestJoin(UIHudCommonChooseBoxController ctrl)
	{
	}

	public void HandleByGroupMemberInviteType(UIModelGroup.GroupMemberInviteType groupInviteType)
	{
	}

	private void OnInGameRejectGroupRequestJoin(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnInGameGroupRequestJoinTimeOut(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void OnInGameGroupRequestJoinToggleChange(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void ExitAndCloseInGameInviteBox(UIHudCommonChooseBoxController ctrl)
	{
	}

	private void CancelInGameGroupInviteOrJoinRequestDataDelayCall()
	{
	}

	public void ShowFeedback(PLMGJPDLHHE msg)
	{
	}

	public void CloseWaitingThumbUp()
	{
	}

	public void OnCabinWaitingEnd()
	{
	}

	private void UpdateWeatherPresetSetting()
	{
	}

	private void OnCSShowRound(object[] data)
	{
	}

	public void OnOpenPopMenu(object[] data)
	{
	}

	private void ShowBuffECACustomContentLabelOnDamageTarget(GEvent data)
	{
	}

	public void OpenFPPModeUI()
	{
	}

	public void CloseFPPModeUI()
	{
	}

	public void CreateCabinMapIcon(PHEPNBFBLBG info)
	{
	}

	private void ShowInventoryExchange(GEvent data)
	{
	}

	private void ShowInventoryExchangeInBag(GEvent data)
	{
	}

	private void OnCraftLandShowDownloadPopup(object[] data)
	{
	}

	public UIHudEighthCSLevelPlayerStatsController OpenEighthCSInfiniteLevelUI()
	{
		return null;
	}

	private void ShowMissionMachineInfoUI(GEvent data)
	{
	}

	private void EnsureRankingStatueDeployedNotificationCreated()
	{
	}

	public UIHudBigHeadHypeSliderController OpenBigHeadHypeSliderCtrl()
	{
		return null;
	}

	public void OpenGetOffSlideBtn()
	{
	}

	public void OpenSlideSwitchMoveBtn()
	{
	}

	private void OnBooyahBountyRankingStatueSingleCreated(uint statueID)
	{
	}

	public void TryRefreshTeamGoalTeammatesSelectItemView(CKAHCENCNKD msg)
	{
	}

	private void TryRefreshTeamGoalSelectItemView(uint id, uint lastId, int teamIndex)
	{
	}

	public void TryClickTeamGoal(uint id, bool canClickItem)
	{
	}

	private void TrySendQuickChat(uint id)
	{
	}

	private void TryPinMark(uint id)
	{
	}

	private void TryRecoverPinMark()
	{
	}

	private void TrySelectItem(uint id, uint lastId)
	{
	}

	private void CancelSelectItemDelayCall()
	{
	}

	private void OnKillCamEntryShow()
	{
	}

	public bool IsKillCamEntryShowing()
	{
		return false;
	}

	private void OnNBSkyReviveVFXShow(bool show)
	{
	}

	private void TryShowPath(uint id)
	{
	}

	public void RecyclePath()
	{
	}

	private void InstantArrow(Vector3 pos, Vector3 lookAt)
	{
	}

	public UIHudLockAirDropPosMarkController GetAirDropPointMarkCtrl(uint id)
	{
		return null;
	}

	private void ClearTeamGoal()
	{
	}

	private void TryShowEnemyMark()
	{
	}

	private UIHudBuffPanelFollowPlayerController GetHudBuffPanelFollowPlayer(Player player)
	{
		return null;
	}

	private void RecycleHudBuffPanelFollowPlayer(UIHudBuffPanelFollowPlayerController ctrl)
	{
	}

	public void CloseHudBuffPanelFollowPlayer(BHGGAEEHJCO playerID)
	{
	}

	public void ShowUIFXFollowPlayer(BHGGAEEHJCO sourcePlayerID, BHGGAEEHJCO targetPlayerID, AEIFBHDIIMA displayType)
	{
	}

	public void ShowCustomUIFXFollowPlayer(BHGGAEEHJCO targetPlayerID, ResourceID resourceID, float lifeTime, ResourceID buffIconResID)
	{
	}

	private void CloseAllHudBuffPanelFollowPlayer()
	{
	}

	private void TryShowCSRoundMVP()
	{
	}

	public void TryShowSeafoodGlassBridgeBuff()
	{
	}

	public void TryHideSeafoodGlassBridgeBuff()
	{
	}

	public bool CheckShowNewbieCSShopGuide()
	{
		return false;
	}

	public void TryShowNewbieCSShopEntryGuide()
	{
	}

	public bool CheckShowNewbieCSShopDragUpGuide()
	{
		return false;
	}

	public bool CheckShowNewbieCSShopPurchaseGuide()
	{
		return false;
	}

	public void SetNewbieCSShopPurchaseGuide()
	{
	}

	private UIBaseController CreateInGameShopController()
	{
		return null;
	}

	private UIBaseController CreateInGameAirDropShopController()
	{
		return null;
	}

	private UIBaseController CreateInGamePersonalShopController()
	{
		return null;
	}

	private UIHudTechBuildPointSelectionPopupWndController EnsureTechBuildPointSelectionPopupCreated()
	{
		return null;
	}

	public void ShowTechBuildPointSelectionPopup(uint pointObjectID, UIHudTechBuildPointSelectionItemViewData[] viewDataArr)
	{
	}

	public void HideTechBuildPointSelectionPopup()
	{
	}

	private void OnTechBuildConstructionAvailableChange(uint changedPointObjectID)
	{
	}

	private void OnOpenSFRoleplaySelectWnd(object[] data)
	{
	}

	public void OpenSFRoleCabinRolePopupWnd()
	{
	}

	private void OnSFRoleplayRefreshRoleEnergy(bool showGuide)
	{
	}

	public void PlayUseGhostUIFX()
	{
	}

	public void ShowSFRoleplayRoleTitle(BHGGAEEHJCO playerID)
	{
	}

	public void ShowSFRoleplayNoRoleTips(bool needClickMask = false)
	{
	}

	private void SetupActivityTweenTipsEntries()
	{
	}

	public void ShowActivityPopupMessage(string style, string message, ResourceID iconId, int depth, float duration = 2f, int yOffset = 0)
	{
	}

	public void ShowActivityPopupMessage(ResourceID styleRes, string message, ResourceID iconId, int depth, float duration = 2f, int yOffset = 0)
	{
	}

	public void ShowActivityPopupMessage(ResourceID styleRes, string message, string iconResName, int depth, float duration = 2f, int yOffset = 0)
	{
	}

	private void ShowActivityPopupMessageInternal(UIHudActivityTweenTipsEntry matchedEntry, string message, ResourceID iconId, int depth, float duration = 2f, int yOffset = 0)
	{
	}

	private void CleanupActivityTweenTipsEntries()
	{
	}

	private void SetupActivityTweenTips2Entries()
	{
	}

	public void ShowActivityPopup2Message(string style, ResourceID iconId, int depth, float duration = 2f, int yOffset = 0)
	{
	}

	public bool CheckShowActivityPopup2Style(string style)
	{
		return false;
	}

	private void CleanupActivityTweenTips2Entries()
	{
	}

	public void OnTeamGatherRequestInfoUpdate(IMLOLOBENMH msg)
	{
	}

	public void OnTeamGatherResponseInfoUpdate(ONKDJHGPHLK msg)
	{
	}

	public void OnLocalTeamGatherPointUsingEnd()
	{
	}

	private UIHudPocketReviveSelectPopupWndController EnsurePocketReviveSelectPopupCreated()
	{
		return null;
	}

	public void ShowPocketReviveSelectPopup(UIHudPocketReviveSelectPopupWndViewData viewData)
	{
	}

	public void HidePocketReviveSelectPopup()
	{
	}

	public void ShowReviveCardBubbleTips(IEHIFJNIKNK msg)
	{
	}

	private void OpenReviveCardBubbleHud()
	{
	}

	public void EnterOrLeaveGulagProcessTip(bool isEnter)
	{
	}

	public void ShowGB_GPGulagTips(float time)
	{
	}

	public void ReSetGB_GPGulagTips()
	{
	}

	public void ShowGB_GPGulagPhaseTime(float time)
	{
	}

	public void ReSetGB_GPGulagPhaseTime()
	{
	}

	public void OnGB_GPGulagShowResult(KEEBLFHBMNP result)
	{
	}

	private void OnRefreshPunishKillUI(object[] datas)
	{
	}

	public void OnLeaveGroup()
	{
	}

	private void OpenSuperEmoteHud()
	{
	}

	public void CloseSuperEmoteHud()
	{
	}

	public void OpenFollowEmoteCancelHud()
	{
	}

	public void CloseFollowEmoteCancelHud()
	{
	}

	public void OpenSuperEmoteFriendAddHud(BHGGAEEHJCO playerId)
	{
	}

	public void CloseSuperEmoteFriendAddHud()
	{
	}

	public void OpenSuperEmoteLike()
	{
	}

	public void OpenTeamFlightFriendAddHud(BHGGAEEHJCO playerId)
	{
	}

	public void CloseTeamFlightFriendAddHud()
	{
	}

	public void CloseTeamFlightFriendAddHudIfInvalid()
	{
	}

	private bool CanKeepTeamFlightFriendAddHud(BHGGAEEHJCO playerId, Player localPlayer)
	{
		return false;
	}

	private void OnShowCommonTipsInRightPos(GEvent gEvent)
	{
	}

	public void ShowHudReviveBoxPosMark(uint reviveBoxUID)
	{
	}

	public void HideHudReviveBoxPosMark(uint reviveBoxUID)
	{
	}

	public void ShowHudDreamlandBoyPetHP(uint petUID)
	{
	}

	public void HideHudDreamlandBoyPetHP(uint petUID)
	{
	}

	public void ShowHudScout3PHP(uint scoutUID)
	{
	}

	public void HideHudScout3PHP(uint scoutUID)
	{
	}

	public void ShowHudFollowSpaceShieldForceDownHP(uint spaceShieldUID, float forceDownHPThreshold)
	{
	}

	public void HideHudFollowSpaceShieldForceDownHP(uint spaceShieldUID)
	{
	}

	public void ShowHudFlightBubbleDistance(uint flightBubbleUID, float scale = 1f)
	{
	}

	public void HideHudFlightBubbleDistance(uint flightBubbleUID)
	{
	}

	private void SetHudPresetPickMainVisibile(object[] data)
	{
	}

	private void SetHudPresetPickMainUIView(bool show)
	{
	}

	public void ClosePresetPickUI()
	{
	}

	public void ProcessPresetUIWhenCSShopHide()
	{
	}

	public bool CheckCanCSPresetPick()
	{
		return false;
	}

	public void OnGameModeSettingOverwriteFinish()
	{
	}

	public void ShowHudUAVHP(uint id)
	{
	}

	private void ClearAllHudUAVHP()
	{
	}

	public void RecycleHudUAVHP(uint id)
	{
	}

	public void ShowMicPermissionDenialTip()
	{
	}

	protected void OnHippoCrisisLobbySplitWndShow(object[] data)
	{
	}

	public GameObject ShowTeleportFullScreenMask(ResourceID maskUIResID, ResourceID soundResID, float duration = 2.1f, bool needHideAll = false)
	{
		return null;
	}

	public void SetForbidCrouchEndTime(MNENJMEGAEG msg)
	{
	}

	public void OnHudSFRoleplayCabinRoleNotification()
	{
	}

	public void CloseHudSFRoleplayCabinRoleNotification()
	{
	}

	public void OnHudAutoAbsorbAimTarget()
	{
	}

	private void Clear3DBooyahCoroutine()
	{
	}

	public Vector3 GetMiniMapRightBottomWorldPos()
	{
		return default(Vector3);
	}

	public void CreateAirdropWeaponMark()
	{
	}

	public void CreateRevivePointActionBtn()
	{
	}

	public void ShowSkillPerksController(bool show, uint skillId = 0u, uint skillCardDataId = 0u)
	{
	}

	public void ShowSkillPowerUpChooseController(bool show, GKGGOIJHDBO skillPowerUpItem = null)
	{
	}

	private void OnSkillMightyEnergyChangedForCache(object[] data)
	{
	}

	private void TryCacheSkillMightyChooseResourcesIfActive()
	{
	}

	private void CacheSkillMightyChooseResources()
	{
	}

	private void DoCacheSkillMightyChooseResource(ResourceID resId, int instCount)
	{
	}

	private void OnLandingFightProtectionInfoChanged(GEvent evt)
	{
	}

	public void OpenInventoryCommon()
	{
	}

	public void OnRemainingInfoRatingShow()
	{
	}

	public bool GetIsShowRatingInPlayerRemainInfo()
	{
		return false;
	}

	protected void OnGroupRemindeeInGameNtf()
	{
	}

	private void OnGroupJoinNtf(object[] data)
	{
	}

	private void TryShowGroupWaitingViewForFriendObserver()
	{
	}

	private void ShowGroupWaitingViewIfNeeded()
	{
	}

	private void PreCreateInOpenHud()
	{
	}

	private UIHudTutorialTaskInfoController EnsureTutorialTaskInfoHud()
	{
		return null;
	}

	private void TryStartBRTutorialTaskFeature()
	{
	}

	private void OnPlayerSkillChanged(object[] data)
	{
	}

	private void OnUAVRevealMarks(object[] data)
	{
	}

	private bool TryParseUAVRevealEvent(object[] data, out BHGGAEEHJCO srcPlayerId, out List<Vector3> positions, out uint endTimeMS)
	{
		srcPlayerId = default(BHGGAEEHJCO);
		positions = null;
		endTimeMS = default(uint);
		return false;
	}

	private void RefreshHudUAVRevealMarks(BHGGAEEHJCO srcPlayerId, List<Vector3> positions)
	{
	}

	private void ScheduleHudUAVRevealAutoClear(BHGGAEEHJCO srcPlayerId, float delaySec)
	{
	}

	private void CancelHudUAVRevealDelayCall(BHGGAEEHJCO srcPlayerId)
	{
	}

	private void ClearHudUAVRevealMarks(BHGGAEEHJCO srcPlayerId)
	{
	}

	private void ClearAllHudUAVRevealMarks()
	{
	}

	private List<UIHudItemMarkShowController> GetOrCreateHudUAVRevealList(BHGGAEEHJCO srcPlayerId)
	{
		return null;
	}

	private void RecycleHudUAVRevealControllers(List<UIHudItemMarkShowController> controllers)
	{
	}

	private void TrimHudUAVRevealControllers(List<UIHudItemMarkShowController> controllers, int targetCount)
	{
	}

	public UIBaseController OpenUIInternal(Type type, Transform parent, Vector3 localPosition, EUIAnchor anchor)
	{
		return null;
	}

	public T OpenUIInternal<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor) where T : UIBaseController
	{
		return null;
	}

	protected UIBaseController OpenUIFromConfig(Type type, Transform parent, bool isUseDefaultConfig = false)
	{
		return null;
	}

	protected T OpenUIFromConfig<T>(Transform parent, bool isUseDefaultConfig = false) where T : UIBaseController
	{
		return null;
	}

	protected Vector3 GetPositionFromConfig<T>() where T : UIBaseController
	{
		return default(Vector3);
	}

	protected Vector3 GetScaleFromConfig<T>() where T : UIBaseController
	{
		return default(Vector3);
	}

	public double GetAlphaFromConfig<T>() where T : UIBaseController
	{
		return 0.0;
	}

	public string GetHudNameByType(Type t)
	{
		return null;
	}

	protected void ChangeGroupSettingHigh(Type type, bool isAdd, ulong[] settings)
	{
	}

	protected void ChangeGroupSetting(Type type, bool isAdd, ulong[] settings)
	{
	}

	private bool isPowerOfTwo(ulong x)
	{
		return false;
	}

	private int GetPowerOfTwo(ulong x)
	{
		return 0;
	}

	protected void OverrideGroupSettings<T>(uint[] bs)
	{
	}

	public void ClearMark()
	{
	}

	public void OnSyncCommonBeMarkInfo(DEIINJIGKAC msg)
	{
	}

	public void OnSyncCommonMarkInfo(DCNGPGPCDHG msg)
	{
	}

	private void OnSyncCommonMarkInfo(DCNGPGPCDHG msg, bool isFromObserverSwitch)
	{
	}

	private MarkEnemyType GetMarkType(BEAFJIDDDMB markType)
	{
		return MarkEnemyType.Hint;
	}

	public void SetDragonTaskInfo(uint bossProgress, bool isDragon)
	{
	}

	public void ShowDragonProgressTip()
	{
	}

	public void CacheCdnGuideInfo(EMKJOPOGILH res)
	{
	}

	private bool CheckIsNeedShowNewAvatarSkillGuide(uint skillID)
	{
		return false;
	}

	public bool ShouldShowHCCdnGuideEntry()
	{
		return false;
	}

	public void OnEntryShowHippoCrisisCdnGuide()
	{
	}

	public void ShowAllCDNGuide()
	{
	}

	public void ShowTutorialBRAgentGuide()
	{
	}

	public void ShowCDNList(List<string> resUrl, List<string> keys, uint closeTime, bool needAutoClose)
	{
	}

	public void ShowNewPlayerUnlockFeatureCDN(ref List<string> finalCDNList, ref List<string> finalGuideKeyList, ref uint finalAutoCloseTime)
	{
	}

	public void ShowCDNGuide(ref List<string> finalCDNList, ref List<string> finalGuideKeyList, ref uint finalAutoCloseTime, ref bool needAutoClose)
	{
	}

	private void OnChangeKnockDownQTE(object[] param)
	{
	}

	public bool IsTeammateDisconnected(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void _003CDelayShowEnterEighthLandUI_003Eb__22_0()
	{
	}

	private void _003CShowEighthGiftTransfer_003Eb__24_0()
	{
	}

	private void _003CShowEighthLandResultInternal_003Eb__38_0()
	{
	}

	private void _003CShowEighthLandResultInternal_003Eb__38_1()
	{
	}

	private void _003CChangeUIFromWaitingToBattleInternal_003Eb__504_0()
	{
	}

	private void _003CChangeUIFromWaitingToBattleInternal_003Eb__504_1()
	{
	}

	private void _003COpenCommonHud_003Eb__566_0()
	{
	}

	private void _003COpenCommonHud_003Eb__566_1()
	{
	}

	private void _003COpenCommonHud_003Eb__566_2()
	{
	}

	private void _003COpenCommonHud_003Eb__566_3()
	{
	}

	private void _003CShowNoobPopup_003Eb__633_0()
	{
	}

	private void _003CCheckStreamReady_003Eb__645_0()
	{
	}

	private void _003CIsCustomMatchResult_003Eb__655_0()
	{
	}

	private void _003CShowCSShop_003Eb__851_0()
	{
	}

	private void _003COnGameOpeningEnd_003Eb__948_0()
	{
	}

	private void _003COnGameOpeningEnd_003Eb__948_3()
	{
	}

	private void _003COnCommonCoinsGotForBonusInfo_003Eb__979_0()
	{
	}

	private void _003COnSelfIdentityChanged_003Eb__1008_0()
	{
	}

	private void _003COnRequestGameResumeConfirm_003Eb__1091_0()
	{
	}

	private void _003COnRequestGameResumeConfirm_003Eb__1091_1()
	{
	}

	private void _003COnRequestGameResumeConfirm_003Eb__1091_2()
	{
	}

	private bool _003COnInGameAcceptGroupInviteRequestPresenceNtfCallBack_003Eb__1265_0(FriendAccountInfo x)
	{
		return false;
	}

	private void _003COnCSShowRound_003Eb__1282_0()
	{
	}

	private void _003COnBooyahBountyRankingStatueSingleCreated_003Eb__1297_0()
	{
	}

	private void _003CTrySelectItem_003Eb__1321_0()
	{
	}

	public void _003C_003EiFixBaseProxy_Destory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public Transform _003C_003EiFixBaseProxy_FindUIRoot()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ShowPopupMessage(string P0, float P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetActiveGroup(ulong P0, bool P1, bool P2, byte P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheckGroupNtf()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ProcessInviteTipImmediately(object[] P0)
	{
	}
}

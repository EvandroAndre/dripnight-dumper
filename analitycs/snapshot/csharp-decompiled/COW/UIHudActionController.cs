using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudActionController : UIHudButtonBaseController
{
	public class ActionRes
	{
		public string Icon;

		public string LocKey;
	}

	private const string BountPriceDefaultIcon = "UI_icon_shop_Exchange";

	private UIHudActionView m_View;

	public static readonly string ACTIONICON_DEFAULT;

	public static readonly string ACTIONICON_MUSHROOM;

	public static readonly string ACTIONICON_GET_ON_STROP;

	public static readonly string ACTIONICON_GET_OFF_STROP;

	public static readonly string ACTIONICON_QUIT;

	public static readonly string ACTIONICON_USE;

	public static readonly string ACTIONICON_ENTER;

	public static readonly string ACTIONICON_BUY;

	public static readonly string ACTIONICON_BT_PORTAL;

	public static readonly string ACTIONICON_PORTAL;

	public static readonly string ACTIONICON_CANDY;

	public static readonly string ACTIONICON_DEPOSIT;

	public static readonly string ACTIONICON_PRAYER;

	public static readonly string ACTIONICONBG_DEFAULT;

	public static readonly string ACTIONICONBG_STROP;

	public static readonly string ACTIONICONBG_OPEN;

	public static readonly string ACTIONICONBG_OPEN_FLIGHT;

	public static readonly string ACTIONICONBG_FALL;

	public static readonly string ACTIONICONBG_REVIVE;

	public static readonly string ACTIONICONBG_DRIFTBOTTLE;

	public static readonly string ACTIONICONBG_FOLLOWEMOTE;

	public static readonly string ACTIONICONBG_FOLLOWMOVEMOTE;

	public static readonly string ACTIONICONBG_BOXING;

	public static readonly string ACTIONICONBG_QUEUE;

	public static readonly string ACTIONICONBG_FOURSYMBOLSCHANGECLOTH;

	public static readonly string ACTIONICONBG_CHEER_PET;

	public static readonly string ACTIONICONBG_CHATNPC;

	public static readonly string ACTIONICON_MUSIC_DANCE;

	public static readonly string ACTIONICON_PARTY_SHOOT;

	public static readonly string ACTIONICON_SNOWBALLBOX;

	public static readonly string ACTIONICON_TREASURY_KEY;

	public static readonly string ACTIONICON_TREASURY_UPGRADE;

	public static readonly string ACTIONICON_FAITHJUMP;

	public static readonly string ACTIONICON_FLAGBATTLECHOKEPOINT;

	public static readonly string ACTIONICON_FLAGBATTLEENERGYSTONEBOX;

	public static readonly string ACTIONICON_LEVELSNOWMAN;

	public static readonly string ACTIONICON_LEVELINSTRUMENT;

	public static readonly string ACTIONICON_METROPOLIS_ARREST;

	public static readonly string ACTIONICON_METROPOLIS_USEPOINT;

	public static readonly string ACTIONICON_METROPOLIS_GYM;

	public static readonly string ACTIONICON_ONIZONE;

	public static readonly string ACTIONICON_HGEventTrigger;

	public static readonly string ACTIONICON_CABININTERACTION;

	public static readonly string ACTIONICON_UNLOCKBOUNTYVEHICLE;

	public static readonly string ACTIONICON_USETEAMGATHERPOINT;

	public static readonly string ACTIONICON_SquareDance;

	public static readonly string ACTIONICON_NBScroll;

	public static readonly string ACTIONICON_GetOnSlide;

	public static readonly string ACTIONICON_2NBGP_TREEHOLE_TELEPORT;

	public static readonly string ACTIONICON_UseTechBuildPoint;

	public static readonly string ACTIONICON_UseSFRoleplayNotebook;

	public static readonly string ACTIONICON_OpenTreasureHuntFrontDoor;

	public static readonly string ACTIONICON_OpenTreasureHuntBackDoor;

	public static readonly string ACTIONICON_USE_POCKET_REVIVE_POINT;

	public static readonly string ACTIONICON_OpenTreasureHuntNormalTreasure;

	public static readonly string ACTIONICON_ASTROLGATE;

	public static readonly string ACTIONICON_REVIVEBOX;

	public static readonly string ACTIONICON_BTFISHINGPOOL;

	public static readonly string ACTIONICON_BTBUBBLE;

	public static Dictionary<int, ActionRes> ActionResMap;

	public static readonly Color ACTIONICONBG_COLOR_STROP;

	public static readonly Vector3 LOCALPOSITION_DEFAULT;

	public static readonly Vector3 DefaultLabelPos;

	public static readonly Vector3 SpecialLabelPos;

	public static readonly Vector3 BountyPostLabelPos;

	public static readonly Vector3 ExtraLabelPos;

	private EHudActionType m_ActType;

	private int m_Param;

	private EHudActionType m_ActTypeWithNoTrigger;

	private BHGGAEEHJCO m_TargetAimPalyerID;

	private float m_ActionNoTriggerEndTime;

	private Color SpeicalBgColor;

	private Color DefaultBgColor;

	private Color DefaultBountPriceIconColor;

	private BoxCollider m_Coiilder;

	private float m_ActionCD;

	private float m_ActionCDEndTime;

	private Vector3 m_DefaultPos;

	public bool IsNormalViewHud;

	private uint m_CurrentPrice;

	private bool m_TutOpenParachuteShowed;

	private UIHudDetectorController m_HudDetectorCtrl;

	private bool m_ShowState;

	private bool m_ExtraFlag;

	private HashSet<uint> m_OverCsShopSet;

	private HashSet<uint> m_TogetherCsShopSet;

	private float m_TogetherXPosOffset;

	private bool m_CsShopIsVisible;

	private bool m_SpeicalCD;

	private HashSet<uint> m_ActiveSkillAllowGroupSet;

	private float m_JumpEndTime;

	private GameObject m_FalconIcon;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void SetIcon(EHudActionType actType, bool actionChanged, int param)
	{
	}

	private void ShowTutorial(EHudActionType actType)
	{
	}

	private void OnTutorialJumpGuideShow()
	{
	}

	private void OnActionUpdateIcon(int param, int param2)
	{
	}

	private bool NeedRestoreBlockBtn(EHudActionType hudActionType)
	{
		return false;
	}

	private static bool IsEmoteJoinHudAction(EHudActionType actType)
	{
		return false;
	}

	private bool CanShowEmoteJoinHudAction(EHudActionType incomingActType)
	{
		return false;
	}

	private void OnFollowEmoteStateChanged()
	{
	}

	private void OnActionEnter(int param, int param2)
	{
	}

	public void OverrideHudPosition()
	{
	}

	public void SetDefaultPos(Vector3 v)
	{
	}

	private void OnActionEnd()
	{
	}

	public override void Hide()
	{
	}

	private void Update()
	{
	}

	private void ClearActionCD()
	{
	}

	protected void OnShow(bool param)
	{
	}

	private void OnConflictShowChange(object[] param)
	{
	}

	private void OnActiveSkillStart(object[] param)
	{
	}

	private void OnActiveSkillStop(object[] param)
	{
	}

	private void RefreshActiveSkillAllowFlagVisibility()
	{
	}

	public void SetActiveSkillAllowFlagVisibility(bool v)
	{
	}

	private void OnCameraZoneCameraModeChanged(bool isCameraMode)
	{
	}

	private void RefreshCameraZoneFlagVisibility()
	{
	}

	public void SetCameraZoneFlagVisibility(bool v)
	{
	}

	private void SetToDefault()
	{
	}

	private void SetBtnIcon(string spriteName)
	{
	}

	private void OnTrainingQueueInfoChange(object[] param)
	{
	}

	private void ShowTutorialForOpenParachute()
	{
	}

	private void OnLocalPlayerParachuteReadyTime(object[] param)
	{
	}

	private void UpdateJumpCD()
	{
	}

	private void UpdateSuggestJump()
	{
	}

	public void SetCanJumpState()
	{
	}

	private void OnAddDetector(object[] param)
	{
	}

	private void UpdateTeamGatherCDState()
	{
	}

	private void UpdateBTBubbleCDState()
	{
	}

	private void ApplyBloodmoonGPTotemMissionCD(int actionParam)
	{
	}

	private void ClearBloodmoonGPTotemMissionCDPresentation()
	{
	}

	private void OnBTBubbleInteactShow(bool show)
	{
	}

	private void UpdateBTFishingPoolState()
	{
	}

	private void UpdateBountyVehicleUnlockState()
	{
	}

	private void UpdateBountyBoxAvailable()
	{
	}

	private uint GetCurTriggeredEntityID()
	{
		return 0u;
	}

	private void OnUpdateBountyPostPrice(uint inUniqueID)
	{
	}

	private void OnUpdateWishPoolPrice()
	{
	}

	private bool IsTriggerWishPool()
	{
		return false;
	}

	private int GetPlayerWishingCoinCount()
	{
		return 0;
	}

	private int GetPlayerInGameToeknCount()
	{
		return 0;
	}

	private void OnPlayerInGameTokenChanged(int playerToken)
	{
	}

	private void OnPlayerCurCoinChanged(int curCoin)
	{
	}

	private int GetReviveBoxTokenValue()
	{
		return 0;
	}

	private void RefreshReviveBoxPrice(int tokenValue)
	{
	}

	private LevelReviveBox GetCurTriggeredReviveBox()
	{
		return null;
	}

	private void RefreshReviveBoxTeamUsedTimes()
	{
	}

	private void OnReviveBoxUsedTimesChanged(uint reviveBoxObjectID)
	{
	}

	private void RefreshBountyPostPrice(int playerToken)
	{
	}

	private void OnVaultKeyStateChanged(object[] data)
	{
	}

	private void TryCancelFollowEmoteBeforeHudActionClick()
	{
	}

	protected override void OnBtnClick()
	{
	}

	private void OnHackBtnClick()
	{
	}

	protected void OnHackBtnRelease()
	{
	}

	protected override void OnBtnDown()
	{
	}

	private void OnActionBlock(object[] param)
	{
	}

	private void OnCDUpdate(object[] param)
	{
	}

	private void OnBooyahBountyCoinChange(uint bountyType, uint deltaCoin)
	{
	}

	private void RefreshWishPoolCoin()
	{
	}

	private void OnWishingCoinChanged()
	{
	}

	private void OnGetBountyBoxShopItem(object[] param)
	{
	}

	private void OnBlockBtnClick()
	{
	}

	private void OnCoolDownBtnClick()
	{
	}

	private void SetFalconIconVisible(bool visible)
	{
	}

	public void RefreshLeaveVehicleState()
	{
	}

	private void OnActionStartWithNoTrigger(int param1, int param2)
	{
	}

	private void OnActionEndWithNoTrigger(float delayHideTime)
	{
	}

	private void ActionWithNoTriggerHide()
	{
	}

	private void ResetActionWithNoTriggerData()
	{
	}

	private void OnHippoCrisisMissionStart(GEvent data)
	{
	}

	private void OnHippoCrisisMissionEnd()
	{
	}

	private void OnVerticalCameraModeChanged(bool isVertical)
	{
	}

	private void RefreshWishPoolPrice()
	{
	}

	private int GetWishPoolCost()
	{
		return 0;
	}

	private void OnAstrolGateReachFirstTime(int astrolGateID)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}
}

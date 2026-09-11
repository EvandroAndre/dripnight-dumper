using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW.HUD;

internal class UIHudNameController : UIHudNameDamageController, IHudNameController
{
	public enum EArrowDirection
	{
		NONE,
		UP,
		DOWN,
		LEFT,
		RIGHT
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public UIHudNameController _003C_003E4__this;

		public BaseProfileInfo profile;

		internal void _003CShowTeammateLeaderboardTitle_003Eb__1()
		{
		}

		internal void _003CShowTeammateLeaderboardTitle_003Eb__0()
		{
		}
	}

	private sealed class _003CPlayDamageEffect_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public GameObject effectGO;

		public UIHudNameController _003C_003E4__this;

		public uint UniqueID;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayDamageEffect_003Ed__122(int _003C_003E1__state)
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

	private sealed class _003CRemoveNameInfo_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudNameController _003C_003E4__this;

		public float delayTime;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRemoveNameInfo_003Ed__121(int _003C_003E1__state)
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

	public const uint VISIBILITY_NAMELABEL_NORMAL = 1u;

	public const uint VISIBILITY_NAMELABEL_SETTING = 2u;

	private readonly float HELP_PURCHASE_MARK_TIME;

	private readonly Vector3 EFFECF_GLOW_POS;

	private const float OVERLOOK_Y_OFFSET = 20f;

	private const string TEAM_RALLY_ANIM_ENLARGE = "UIFX_UIHudName_TeamRallyIcon_Enlarge";

	private const string TEAM_RALLY_ANIM_ZOOMOUT = "UIFX_UIHudName_TeamRallyIcon_ZoomOut";

	private UIHudNameView m_View;

	public Transform CachedTransform;

	private BHGGAEEHJCO m_BindPlayer;

	private bool m_NeedShowName;

	private Camera m_FollowCamera;

	private FollowCamera m_FollowCameraComponent;

	private Camera m_UICamera;

	private bool m_IsHit;

	private Vector2 m_CachedDamageOffset;

	private StringBuilder m_Distance;

	private int m_PrevDistance;

	private int m_LastDistancePrintLength;

	private UIHudTriggerEventMarkController m_triggerController;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCtrl;

	private Vector3 m_IconOffset;

	private bool m_FirstShowLeaderBoardTitle;

	private float viewPortBoundary;

	private bool m_ContainerActive;

	private bool m_ShowElectricGirlSkillFirst;

	private bool m_IsFriend;

	private bool m_IsShowFaction;

	private string PumpkinIcon;

	private string BombIcon;

	private bool healHintEffectShow;

	private bool m_NameClassicEnable;

	private bool m_ShowTeammateName;

	private uint m_DelayCall;

	private uint m_TeamRallyDelayCallID;

	private uint m_TeamRallyZoomOutDelayCallID;

	private PHLHIEGPMMK.BBDFBHFPBJO m_ObserverMode;

	private float m_LastHPAmount;

	private Vector3 m_LastNamePos;

	private EArrowDirection m_ArrowDirection;

	private Action<bool> m_OnTeammateDistanceActiveChanged;

	private uint m_ShowLeaderboardTitleDelayCallID;

	private UIModelGroup m_ModelGroup;

	private BitArrayBoolean m_NameLabelBit;

	private bool m_NameLabelFirstSet;

	private UIRect.AnchorPoint m_LeftAnchorForMark;

	private UIRect.AnchorPoint m_RightAnchorForMark;

	private UIRect.AnchorPoint m_BottomAnchorForMark;

	private UIRect.AnchorPoint m_TopAnchorForMark;

	private UIRect.AnchorPoint m_LeftAnchorForHideNameMark;

	private UIRect.AnchorPoint m_RightAnchorForHideNameMark;

	private UIRect.AnchorPoint m_BottomAnchorForHideNameMark;

	private UIRect.AnchorPoint m_TopAnchorForHideNameMark;

	private int m_LobbyGroupIndex;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private const float ARROW_ICON_HALF_SIZE = 21f;

	private int m_CurPumpkinNum;

	private UIHudNameIdentityController m_IdentityCtrl;

	private UIHudNameElectricGirlSkillController m_ElectricGirlCtrl;

	private uint m_AttachedVFXUniqueID;

	private CIJPLNEAIIH m_LastPhase;

	private uint m_DelayCallHideMVPVFXID;

	private const float m_DelayCallHideMVPVFXTime = 5f;

	private const float m_MVPContainerPosOffset = -14f;

	private const float m_PrivilegeContainerPosOffset = -15f;

	private Coroutine m_RemoveCor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public Transform GetChatBoxFollowNode()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnRoomOBIsCamTypeFree(bool isFree)
	{
	}

	private void OnReplayObserverModeChange(object[] data)
	{
	}

	private void UpdateReplayNameByObserverMode()
	{
	}

	private void UpdateHP()
	{
	}

	private void UpdateEventMark()
	{
	}

	private void OnHelpPurchaseSuccess(object[] data)
	{
	}

	private void ResetNameLabel()
	{
	}

	private void ResetAnchors()
	{
	}

	private void InitModeSpecialInfo()
	{
	}

	private bool NeedShowPlayerIndex()
	{
		return false;
	}

	private void InitCamera()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private bool CheckLeaderBoardTitleCanAutoShow()
	{
		return false;
	}

	private void ApplyRoomSpectatorTeamTintForPlayerId(BHGGAEEHJCO playerId, ref Color color)
	{
	}

	private void UpdateTeamIndex(Player player)
	{
	}

	private void UpdateArrowDownColor(Player player)
	{
	}

	public bool DebugIsWatingRoom()
	{
		return false;
	}

	public void UnbindPlayer()
	{
	}

	private void SetNameSpriteTextureActive(bool isActive)
	{
	}

	private void SetContainerActive(bool e)
	{
	}

	public void OnSetContainerActive(bool containerVisible)
	{
	}

	public void DestoryTeamMateHudNameWeaponPower()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateWeaponPowerIconScale(bool outOfSceen, Vector3 targetPos)
	{
	}

	private float GetIconScaleFactorDefault()
	{
		return 0f;
	}

	private float GetScaleFactorDeltaChangeByMeter()
	{
		return 0f;
	}

	private void UpdateNameAlpha()
	{
	}

	private void UpdataViewByPlayerState(Player p)
	{
	}

	private void UpdateContainerActive(Player p)
	{
	}

	private void UpdateContainerActiveDynamic(Player p)
	{
	}

	private void UpdateSpeedModeContainerActive(Player p)
	{
	}

	private bool NeedShowName(BHGGAEEHJCO player_id)
	{
		return false;
	}

	private void UpdateNamePosition(Player p, bool updateInterval = true)
	{
	}

	private void UpdateHealRobotMark(bool outOfScreen, Player p)
	{
	}

	private void UpdateNameAndDistanceShowByDistance(bool outOfScreen, bool updateInterval, bool needShowDistance)
	{
	}

	public void SetLeaderBoardTitleVisibility(bool isVisible)
	{
	}

	private void ResetPlayerIndexAndDistanceDirection(bool isRight)
	{
	}

	private void ResetPlayerIndexTable(bool obj = false)
	{
	}

	private int SortPlayerIndexAndDistance(Transform x, Transform y)
	{
		return 0;
	}

	private int SortPlayerIndexAndDistanceReverse(Transform x, Transform y)
	{
		return 0;
	}

	private void SetDistance(int distance)
	{
	}

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	private Vector3 GetRefPosInPlane(Player p, AirTransporter plane)
	{
		return default(Vector3);
	}

	private void SetViewActive(GameObject obj, bool active)
	{
	}

	public void ShowEventTriggerIcon(InGameTriggerMaskData data)
	{
	}

	public void HideEventTriggerIcon(InGameTriggerMaskData data)
	{
	}

	public void FlashEventTriggerIcon()
	{
	}

	private void ShowArrow(EArrowDirection direction)
	{
	}

	private bool NeedShowDamageLabel(Player.DDFCIJDHODF playerHitEvt)
	{
		return false;
	}

	private void OnGotHit(GEvent data)
	{
	}

	private void ShowDamage(int damage, LLEDPGIGCMO colliderT, Player p, int shieldDamage, int weaponID, float delay)
	{
	}

	private GameObject InstantDamageLabel(int damage, LLEDPGIGCMO colliderT, AttackableEntity p, int shieldDamage, int weaponDataID)
	{
		return null;
	}

	private void SetPVPHitLabel(GameObject cloneLabelGO, LLEDPGIGCMO colliderT, int damage, int shieldDamage, int weaponDataID, ref int xOff, ref int yOff)
	{
	}

	private void SetPVEHitLabel(GameObject cloneLabelGO, AttackableEntity p, LLEDPGIGCMO colliderT, int damage, int shieldDamage, int weaponDataID)
	{
	}

	private void OnPumpkinNumChange(object[] data)
	{
	}

	private void UpdatePumpkinNum(int num)
	{
	}

	private void UpdateBombIconVisibility(BHGGAEEHJCO pId)
	{
	}

	private IEnumerator RemoveNameInfo(float delayTime)
	{
		return null;
	}

	private IEnumerator PlayDamageEffect(GameObject effectGO, float delay, uint UniqueID)
	{
		return null;
	}

	private void OnShowEnemy(object[] data)
	{
	}

	private void OnTrainingZoneChanged(uint param0, uint param1)
	{
	}

	private void OnBombCarrierChange(object[] param)
	{
	}

	private void OnNewPhaseStarted(object[] data)
	{
	}

	private void OnSettingNoHudNotify(object[] data)
	{
	}

	private void OnPlayerHpChanged(GEvent data)
	{
	}

	private void OnLocalPlayerOnHandWeaponChange(object[] data)
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

	private bool NeedShowHealHintWhenBindPlayer(Player p)
	{
		return false;
	}

	public void ShowTutorialCSGameGuide()
	{
	}

	public void ShowTeammateLeaderboardTitle(bool isLeaderboardTitle)
	{
	}

	private void OnShowNameIdentity(object[] data)
	{
	}

	private void UpdateNameIdenityScaleByDistance(Player p)
	{
	}

	private void SetPlayerName(Player player)
	{
	}

	private void OnKingChanged(object[] data)
	{
	}

	private void OnHealRobotLockPlayer(object[] data)
	{
	}

	public void SetNameLabelVisible(uint flag, bool v)
	{
	}

	private void OnElectricGirlSkillNameIconStatusChange()
	{
	}

	private void ReBindElectricGirlNameCtrl()
	{
	}

	private void RefreshElectricGirlNameCtrl()
	{
	}

	private void ShowPlayerMVP()
	{
	}

	private void AdjustMVPTransformPos()
	{
	}

	private void DetachMVPVFX()
	{
	}

	private void HideMVPContainer()
	{
	}

	private void RefreshLobbyGroupIndex()
	{
	}

	private void HandleAccumulatedDamage(int damage, LLEDPGIGCMO colliderT, Player p, int shieldDamage, int weaponID, float delay)
	{
	}

	protected override GameObject GetDamageGameObject(Player player = null, bool IsGSDamage = false)
	{
		return null;
	}

	protected override void SetupHitLabel(GameObject cloneLabelGO, AttackableEntity attackTarget, AccumulatedDamageInfo info, bool isDamageLabelType1, ref int xOff, ref int yOff)
	{
	}

	protected override void StartDamageCoroutine(GameObject cloneLabelGO, float delay, uint uniqueID)
	{
	}

	protected override Coroutine RemoveDamageEffectCoroutine(float delay, uint uniqueID)
	{
		return null;
	}

	protected override void AfterShowDamage()
	{
	}

	protected void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void HidePrivilegeContainer()
	{
	}

	private void OnTeamRallyCooldownSync(uint requesterPlayerID)
	{
	}

	private void HideTeamRallyIconWithAnim()
	{
	}

	private void DeactivateTeamRallyIcon()
	{
	}

	private void HideTeamRallyIcon()
	{
	}

	private void CancelTeamRallyDelayCall()
	{
	}

	private void CancelTeamRallyZoomOutDelayCall()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public GameObject _003C_003EiFixBaseProxy_GetDamageGameObject(Player P0, bool P1)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetupHitLabel(GameObject P0, AttackableEntity P1, AccumulatedDamageInfo P2, bool P3, ref int P4, ref int P5)
	{
	}

	public void _003C_003EiFixBaseProxy_StartDamageCoroutine(GameObject P0, float P1, uint P2)
	{
	}

	public Coroutine _003C_003EiFixBaseProxy_RemoveDamageEffectCoroutine(float P0, uint P1)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_AfterShowDamage()
	{
	}
}

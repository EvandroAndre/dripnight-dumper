using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCrosshairsController : UIBaseController
{
	private class ScaleTweenSeq
	{
		public float startScale;

		public float endScale;

		public float duration;

		public bool start;

		public bool end;

		public float time;

		public GameObject target;

		public ScaleTweenSeq(GameObject target, float startScale, float endScale, float duration)
		{
		}
	}

	private class PositionTweenSeq
	{
		public Vector3 startPosition;

		public Vector3 endPosition;

		public float duration;

		public bool start;

		public bool end;

		public float time;

		public GameObject target;

		public PositionTweenSeq(GameObject target, Vector3 startPosition, Vector3 endPosition, float duration)
		{
		}
	}

	private class RotationTweenSeq
	{
		public Vector3 startRotation;

		public Vector3 endRotation;

		public float duration;

		public bool start;

		public bool end;

		public float tiem;

		public GameObject target;

		public RotationTweenSeq(GameObject target, Vector3 startRotation, Vector3 endRotation, float duration)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__215_2;

		public static Action _003C_003E9__216_1;

		internal void _003COnArmorBroken_003Eb__215_2()
		{
		}

		internal void _003COnShieldBroken_003Eb__216_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass213_0
	{
		public UISprite curIcon;

		internal void _003COnHitArmor_003Eb__0()
		{
		}
	}

	private sealed class _003CPlayHitEffect_003Ed__184 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCrosshairsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayHitEffect_003Ed__184(int _003C_003E1__state)
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

	private sealed class _003CShieldGunShieldBrokenHide_003Ed__203 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCrosshairsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShieldGunShieldBrokenHide_003Ed__203(int _003C_003E1__state)
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

	private const uint VISIBILITY_STATE_NORMAL = 1u;

	private const uint VISIBILITY_STATE_HIT = 2u;

	private static readonly Color AIM_COLOR_NO_TARGET;

	private static readonly Color AIM_COLOR_HAS_TARGET;

	private static readonly Color AIM_COLOR_AIM_OBJECT;

	private static readonly Color AIM_COLOR_AIM_HEAL;

	private static readonly Color AIM_COLOR_BR_SHOP_TOKEN_FRIEND;

	private static readonly Color AIM_COLOR_HAS_TARGET_NOBLOOD;

	private static readonly Color AIM_COLOR_AIM_OBJECT_NOBLOOD;

	private static readonly Color CHARGE_COLOR_NO_TARGET;

	private static readonly Color CHARGE_COLOR_HAS_TARGET;

	private static readonly Color GUNSIGHTCENTER_COLOR_NO_TARGET;

	private static readonly Color GUNSIGHTCENTER_COLOR_HAS_TARGET;

	private static readonly Color GUNSIGHTCENTER_COLOR_THERMAL_HAS_TARGET;

	private static readonly Color AIM_COLOR_BLOOD_POOL;

	private static readonly Color TECH_GUNSIGHTCENTER_COLOR;

	private static readonly Color CHANGE_RELOAD_SPEED_NORMAL_COLOR;

	private static readonly Color RELOAD_NORMAL_COLOR;

	private static readonly Color CHANGE_RELOAD_SPEED_FAIL;

	private UIHudCrosshairsView m_View;

	private BitArrayBoolean m_CrosshairVisibility;

	private bool m_LastSightingState;

	private Vector3 defaultSize;

	private GameObject m_BuildingCrossHair;

	private BoxCollider[] m_BuildingCrossHairColliders;

	private VisualInstanceHolder m_BuildingCrossHairHolder;

	private float m_ShieldBrokenAnimTime;

	private SpawnObjectCrossHairTrigger m_BuildingCrossHairTrigger;

	private IceWallCrossHairTrigger[] m_IcewallTriggers;

	private float m_OriginAngle;

	private Vector3 m_OriginPos;

	private ResourceID m_BuildingCrossHairID;

	private bool m_StartCharge;

	private float m_ChargDuration;

	private float m_WeaponMaxChargeTime;

	private bool m_LastInSight;

	private EJNFNOJNCPE m_CurSightAttachmentData;

	private bool m_HitHintIsHeadShot;

	private uint m_HitHintDelayId;

	private uint m_HitHintKeepDelayId;

	private uint m_HitHintHeadshotDelayId;

	private uint m_KillHintDelayId;

	private uint m_KillHintHeadshotDelayId;

	private uint m_KillHintNoneHeadshotDelayId;

	private uint m_FlashHintDelayId;

	private uint m_ProtectHintDelayId;

	private uint m_ArmorBrokenDelayId;

	private float m_LastHitTime;

	private float m_LastOverlapPlayerCheckTime;

	private PHLHIEGPMMK.BBDFBHFPBJO m_ObserverMode;

	private int m_CurAimType;

	private bool m_IsReloading;

	private float m_ReloadTime;

	private float m_ReloadTotalTime;

	private float m_SegmentReloadTotalTime;

	private float m_SegmentReloadTime;

	private float m_ReloadAccelerateStart;

	private float m_ReloadAccelerateEnd;

	private float m_ReloadAccelerateSpan;

	private bool m_CanReloadAccelerate;

	private float m_ReloadAccelerateSpeed;

	private bool m_IsSegmentReload;

	private bool m_IsGrenadeGunFiring;

	private bool m_IsFiring;

	private Dictionary<int, UISprite> m_AimCenterMap;

	private Dictionary<int, GameObject> m_AimMap;

	private Dictionary<int, Transform> m_AimScaleMap;

	private Dictionary<int, UISprite[]> m_AimColorMap;

	private float m_HitHintScale;

	private float m_HitHintTimeSpeed;

	private float m_KillHintScale;

	private float m_KillHintTimeSpeed;

	private int m_ContinuousHitHint;

	private float m_ContinuousHitHintScale;

	private float m_ContinuousHitHintTime;

	private bool m_IsKeepShooting;

	private uint m_DelayShowArmorAnim;

	private uint m_DelayPlayBrokenSound;

	private Dictionary<int, UISprite> m_HelmetIconDic;

	private Dictionary<int, UISprite> m_VestIconDic;

	private float m_OriginAlpha;

	private UIHudCrosshairsFireBoyTrait m_FireBoyTrait;

	private UIHudCrosshairsAutoPathBombTrait m_AutoPathBombTrait;

	private Skill2NBGPShadowTrait m_2NBGPShadowTrait;

	private UIHudCrosshairsUAVPathIndicator m_UAVPathIndicator;

	private BHGGAEEHJCO m_LastAimTargetPlayerID;

	private float heightScale;

	private int m_PenetrableViewOriginWidth;

	private int m_PenetrableViewOriginHeight;

	private GameObject m_DynamicCrosshair;

	private ResourceID m_CurrentDynamicCrosshairResID;

	private Transform m_DynamicCrosshairScaleTransform;

	private UISprite[] m_DynamicCrosshairSprites;

	private UIHudWeaponProgressBarController m_ProgressBar;

	private UIHudCrosshairsMountGrenadeProgress1xController m_MountGrenadeProgress1x;

	private UIHudCrosshairsMountGrenadeProgress2xController m_MountGrenadeProgress2x;

	private UIHudCrosshairsMountGrenadeProgress4xController m_MountGrenadeProgress4x;

	private UIHudCrosshairsMountGrenadeProgressHipController m_MountGrenadeProgressHip;

	private UIHudCrosshairReloadAcclerate m_ReloadAcclerate;

	private MutableString m_ReloadTimeSb;

	private Queue<ScaleTweenSeq> m_QueueScaleTween;

	private Queue<PositionTweenSeq> m_QueuePositionTween;

	private Queue<RotationTweenSeq> m_QueueRotationTween;

	public ResourceID m_ScopeOpeningVFXResID;

	public GameObject m_ScopeOpeningVFX;

	public ResourceID m_ScopeVFXResID;

	public GameObject m_ScopeVFX;

	private uint m_AsyncLoadReskinSightUITicket;

	private Dictionary<int, uint> m_AsyncLoadTicks;

	private const int KEYGunShieldLeft = 1;

	private const int KEYGunShieldRight = 2;

	private const int KEYSightUICenter = 3;

	private const int KEYSightUICenterHeal = 4;

	private bool isIceWall;

	private Material m_ColorMaterial;

	private int _Color;

	private Color alertcolor;

	private Color normalcolor;

	private List<Renderer> renderers;

	private List<Renderer> m_MeshRenderers;

	private bool m_showAlert;

	private const float PENETRATE_STEP_LENGTH = 0.015f;

	private float m_LastUpdateAnimingTargetTime;

	private bool m_IsLastPenetratable;

	private FDAEPHMIEPC m_WeaponMountGrenadeHip;

	private VisualInstanceHolder m_KisameEnableUI;

	private float m_LastIceWallChangedTime;

	private const int MAXPELLET = 15;

	private AccumulateDamageEvent m_AccumulateDamage;

	private uint m_DelayID;

	private List<UISprite> m_Pellets;

	private float m_LastShowTime;

	private int m_LastShowCount;

	private bool m_IsShowEffecting;

	public GameObject BuildingCrossHair => null;

	public BoxCollider[] BuildingCrossHairColliders => null;

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

	public override void OnUIReInit()
	{
	}

	private void InitArmorUI()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void FrameTick()
	{
	}

	private void RefreshLaserSightCrosshair(FDAEPHMIEPC weaponOnHand, Player localPlayer)
	{
	}

	private void OnReplayJumpFinished()
	{
	}

	private void OnReloadSpeedChangeAvailable(object[] data)
	{
	}

	private int GetOldTypeCrosshair(bool isNormalUseSniper, int newTypeCrosshair)
	{
		return 0;
	}

	private bool IsObTargetInChargeState()
	{
		return false;
	}

	private bool NeedChangeForHealingGunTarget(bool heuristicTargetIsFriend, OKEAMEELLBB aimTarget, FOCGJHJOBFE player)
	{
		return false;
	}

	private void ChangeColor(bool showAlert)
	{
	}

	private bool CheckIsWallPenetratable()
	{
		return false;
	}

	private Vector3 GetTraceDirection(Vector3 normalDir, Vector3 flyDir)
	{
		return default(Vector3);
	}

	private void FindMaterial()
	{
	}

	private void ResetColor()
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateScaleTween()
	{
	}

	private void UpdatePositionTween()
	{
	}

	private void UpdateRotationTween()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void RefreshMountGrenadeHip(FDAEPHMIEPC weapon)
	{
	}

	private void RefreshMountGrenadeProgress()
	{
	}

	private void OnChargeStateChangeParam(object[] data)
	{
	}

	private void OnChargeStateChange(bool data)
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnSightingFired(object[] data)
	{
	}

	private void StartScaleTween(GameObject InObject, float InStartScale1, float InEndScale1, float InDuration1, float InEndScale2, float InDuration2)
	{
	}

	private void StartScaleTween(GameObject target, float startScale, float endScale, float duration)
	{
	}

	private void TurnOffSighting()
	{
	}

	private void OnInventoryOpened(object[] data)
	{
	}

	private void OnInventoryTryUseMedkit(object[] data)
	{
	}

	private void OnInventoryTryUseRepairKit(object[] data)
	{
	}

	private void OnLeaderboardOpened(object[] data)
	{
	}

	private void OnFastRunningActivated()
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void OnScreenshot(object[] data)
	{
	}

	private void UpdateKisameShark()
	{
	}

	private void OnLocalPlayerAutoFlightHit(object[] data)
	{
	}

	private void LocalPlayerHitEffect(bool isHeadShot)
	{
	}

	private void LocalPlayerHitEffect()
	{
	}

	private void OnLocalPlayerHitOthersSimple()
	{
	}

	private void OnLocalPlayerHitOthers(GEvent data)
	{
	}

	private void OnFlashHitEnemy(object[] data)
	{
	}

	private void ShowFlashHint()
	{
	}

	private void OnLocalPlayerKillOthers(object[] data)
	{
	}

	private void OnLocalPlayerKnockDownOthers(object[] data)
	{
	}

	private IEnumerator PlayHitEffect()
	{
		return null;
	}

	private void OnUpdateAimTraceClosePos(GEvent data)
	{
	}

	private void OnIceWallCrossHairChange(object[] data)
	{
	}

	private void OnCustomCrossHairChange(object[] data)
	{
	}

	private void ReleaseBuildingCrossHair()
	{
	}

	private void OnBuildingCrossHairLoaded(GameObject obj)
	{
	}

	private void OnRedEnvelopeCrossHairChange(object[] data)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	private void OnShowFireBanned(object[] data)
	{
	}

	private void OnShowHitTotal(GEvent gevent)
	{
	}

	private void DelayShowHitMaker()
	{
	}

	private void OnShieldGunShieldHide(object[] data)
	{
	}

	private IEnumerator ShieldGunShieldBrokenHide()
	{
		return null;
	}

	private void OnReplayObserverModeChange(object[] data)
	{
	}

	private void SetIceWallOnZoneTips(GameObject iceWall)
	{
	}

	private void OnWeaponReload(object[] data)
	{
	}

	private void OnWeaponReloadChangeSpeedFail(object[] data)
	{
	}

	private void OnWeaponReloadSpeedChanged(object[] data)
	{
	}

	private void OnWeaponReloadEnd(object[] data)
	{
	}

	private void SetAimColor(int aimType, bool isAimingEnemy, bool isAimmingRed, bool isAimingInvalid, bool isPenetrateGrande, bool forHealingBullet, bool isAimColorAlwaysNormal, bool useBRShopTokenFriendColor)
	{
	}

	private void SetAnimaitonState(GameObject go, Animation anim, float scale, float timeSpeed)
	{
	}

	private void OnHitArmor(GEvent data)
	{
	}

	private void ShowIcon(UISprite targetIcon)
	{
	}

	private void OnArmorBroken(object[] data)
	{
	}

	private void OnShieldBroken(GEvent evt)
	{
	}

	private void ClearScopeVFX()
	{
	}

	private void ClearScopeOpeningVFX()
	{
	}

	private void ClearAsyncLoadReskinSightUITicket()
	{
	}

	private bool LoadDynamicCrosshair(ResourceID crosshairResID)
	{
		return false;
	}

	private void ClearDynamicCrosshair()
	{
	}

	private bool ShouldUseDynamicCrosshair(FDAEPHMIEPC weaponOnHand)
	{
		return false;
	}

	private int GetDynamicCrosshairType()
	{
		return 0;
	}

	private void BindAtlasSprite(ResourceID InResID, UISprite InSprite, int loadKey, Action<UISprite> action = null)
	{
	}

	private void MakePixelPerfect(UISprite InSprite)
	{
	}

	private void SetPenetrableViewScale(float scale)
	{
	}

	private void ClearAsyncLoadTick(int value)
	{
	}

	private void ClearAllAsyncLoadTicks()
	{
	}

	private void _003CLocalPlayerHitEffect_003Eb__176_0()
	{
	}

	private void _003CLocalPlayerHitEffect_003Eb__177_0()
	{
	}

	private void _003CLocalPlayerHitEffect_003Eb__177_1()
	{
	}

	private void _003COnLocalPlayerHitOthers_003Eb__179_0()
	{
	}

	private void _003CShowFlashHint_003Eb__181_0()
	{
	}

	private void _003COnLocalPlayerKillOthers_003Eb__182_0()
	{
	}

	private void _003COnLocalPlayerKillOthers_003Eb__182_1()
	{
	}

	private void _003COnLocalPlayerKillOthers_003Eb__182_2()
	{
	}

	private void _003COnShowHitTotal_003Eb__200_0()
	{
	}

	private void _003COnArmorBroken_003Eb__215_0()
	{
	}

	private void _003COnArmorBroken_003Eb__215_1()
	{
	}

	private void _003COnShieldBroken_003Eb__216_0()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}

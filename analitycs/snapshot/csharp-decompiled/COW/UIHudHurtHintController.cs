using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudHurtHintController : UIBaseController
{
	private enum PriorityWaringType
	{
		EWaringType_Invalid,
		EWaringType_FootStep,
		EWaringType_Fire,
		EWaringType_ElectricZone,
		EWaringType_StropAndSlide,
		EWaringType_StealthDetect,
		EWaringType_HealRobot,
		EWaringType_GBFootball,
		EWaringType_SnowSlide
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public UIHudHurtHintController _003C_003E4__this;

		public ResourceID hitRes;

		public int damageValue;

		public AttackableEntity enemy;

		internal void _003CShowBeHitHint_003Eb__0(uint ticket, bool succees, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public UIHudHurtHintController _003C_003E4__this;

		public ResourceID hitRes;

		public BHGGAEEHJCO damagerID;

		public InGameHint3DManager.EHint3DType hint3DType;

		public Player enemy;

		public Player localPlayer;

		internal void _003CShowBeHit3DHint_003Eb__0(uint ticket, bool succees, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003CRemoveHurtHint_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UIHudHurtHintController _003C_003E4__this;

		public ResourceID resourceID;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRemoveHurtHint_003Ed__78(int _003C_003E1__state)
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

	private const float m_HurtHintDisplayDuration = 0.4f;

	private const float m_IgnoreShotgunHitInterval = 0.1f;

	private UIHudHurtHintView m_View;

	private Dictionary<ResourceID, Queue<UIHudSelfHurtHint>> m_HurtHintsMap;

	private Dictionary<UIHudSelfHurtHint, AttackableEntity> m_HintsDict;

	private List<UIHud3DHint> m_3DHintsList;

	private Dictionary<BHGGAEEHJCO, float> m_ChargeShotGunInfo;

	private List<UIEnemyChargeHintObjectController> m_ChargeShotGunControllers;

	private Dictionary<BHGGAEEHJCO, float> m_ChargeShotGun3DInfo;

	private List<UIHud3DHint> m_ChargeShotGun3DList;

	private List<UIHudWarningHint> m_PriorityHintsList;

	private List<UIHud3DHint> m_PriorityFireHints3DList;

	private int m_CurrentPriority;

	private Dictionary<int, ResourceID> m_PriorityHintResDict;

	private bool hasRegisterFootStepAndFireHint;

	private bool m_IsEnemyFireHintEnabled;

	public static readonly Color HINT_HURT_COLOR_NOBLOOD;

	private float m_CheckElectricZoneHintTime;

	private float m_CheckHealRobotHintTime;

	private bool m_CacheIsInElectricZoneHintArea;

	private WarningHintData m_ElectricZoneHintData;

	private uint m_FullScreenVfxId;

	private uint m_nDelayCallHideEffect;

	private const int MAXCHARGESHOTINFO = 2;

	private float m_ChargeShotHintSqrDistance;

	private float m_CheckStropAndSlideHintTime;

	private float m_CheckGBFootballHintTime;

	private float m_CheckSnowSlideHintTime;

	private Dictionary<BHGGAEEHJCO, float> m_SnowSlideVibrateTimeMap;

	private Dictionary<BHGGAEEHJCO, float> m_ShotGunHitPlayers;

	private float m_NextCheckStealthTime;

	private float CHECK_STEALTH_INTERVAL;

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

	private void UpdateFootStepAndFireHint(bool register)
	{
	}

	private void RegisterFootStepAndFireHint()
	{
	}

	private void UnRegisterFootStepAndFireHint()
	{
	}

	private void UnRegisterFootStepAndFireHintEvents()
	{
	}

	private void OnUIChangeFromWaitingToBattle()
	{
	}

	private void OnSomeOneTriggerGrenade(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateCheckElectricZone()
	{
	}

	private void UpdateCheckPlayerOnStropAndSlide()
	{
	}

	private void UpdateCheckPlayerInSnowSlide()
	{
	}

	private bool CanHandleSnowSlideWarningTarget(Player localPlayer, Player target, float maxSqrDistance)
	{
		return false;
	}

	private bool CanKeepSnowSlideWarningTarget(Player localPlayer, Player target)
	{
		return false;
	}

	private void TryPlaySnowSlideVibrate(Player target)
	{
	}

	private void UpdateCheckNearGBFootball()
	{
	}

	private void UpdateStealthDetect()
	{
	}

	private void UpdateHealRobotHint()
	{
	}

	private bool CheckNeedToUseSameHint(int hintType, BHGGAEEHJCO pid, UIHudWarningHint hudHint)
	{
		return false;
	}

	private bool CheckIsInElectricZoneHintArea(Vector3 pos)
	{
		return false;
	}

	private Quaternion CalcHintRotaion(Vector3 targetPos)
	{
		return default(Quaternion);
	}

	public void Clear()
	{
	}

	private void OnObservePlayer(object[] data)
	{
	}

	private void OnEnemyFootStep(uint data)
	{
	}

	private bool CheckShowFootStepLikeWarning(Player localPlayer)
	{
		return false;
	}

	private bool CheckSkillShowFootStepWarning(Player localPlayer)
	{
		return false;
	}

	private void OnEnemyFire(GEvent data)
	{
	}

	private void OnSomeoneStopFiring(uint param)
	{
	}

	private void OnSomeObjectFiring(object[] param)
	{
	}

	private void OnRecievingWarning(BHGGAEEHJCO pID, PriorityWaringType hintType, bool longLast, bool postionFixed, Vector3 fixedPos, bool iconFixRotation = false)
	{
	}

	private void RemovePriorityHintsAt(int index)
	{
	}

	private void OnRecievingFireWarningShow3DHint(BHGGAEEHJCO enemyID, uint hintType, bool longLast, bool postionFixed, Vector3 fixedPos)
	{
	}

	private void RemovePriorityHints3DAt(int index)
	{
	}

	private static Vector3 GetHurtHintLocalScaleWithDamage(int damageValue)
	{
		return default(Vector3);
	}

	private void OnLocalPlayerBeHit(object[] data)
	{
	}

	private void ShowBeHitHint(short specialHitType, BHGGAEEHJCO damagerID, uint weaponDataID, int damageValue, bool hasDotBuff = false)
	{
	}

	private void ShowBeHit3DHint(short specialHitType, BHGGAEEHJCO damagerID)
	{
	}

	public override void Hide()
	{
	}

	private void HideHurtFullEffect()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private IEnumerator RemoveHurtHint(float delayTime, ResourceID resourceID)
	{
		return null;
	}

	private void DequeueHurtHints(ResourceID resourceID)
	{
	}

	private void RemoveHurt3DHint()
	{
	}

	private void ClearAllPriorityHints()
	{
	}

	private void ClearAllPriorityHints2D()
	{
	}

	private void ClearAllPriorityHints3D()
	{
	}

	private void ClearAllHurtHints()
	{
	}

	private void PlayBurningEffect()
	{
	}

	private bool IsPenetrateHit(short specialHitType)
	{
		return false;
	}

	private Vector3 CalCameraForward(Player localPlayer)
	{
		return default(Vector3);
	}

	private void OnChargeShotGunStartCharge(uint playerID)
	{
	}

	private void OnChargeShotGunStopUse(uint playerID)
	{
	}

	private void UpdateChargeShotGunInfo(uint removePlayerID = 0u)
	{
	}

	private void Update2DChargeShotGunInfo(uint removePlayerID)
	{
	}

	private void ClearChargeShotGun()
	{
	}

	private void RemoveUnusedChargeShotGunUI(List<int> indexs)
	{
	}

	private bool CanShowChargeShotGunUI(BHGGAEEHJCO playerID, ref float distance, ref Vector3 enemyPosition)
	{
		return false;
	}

	private float GetPlayerSqrDistance(BHGGAEEHJCO playerID)
	{
		return 0f;
	}

	private void Update3DChargeShotGunInfo(uint removePlayerID)
	{
	}

	private void RemoveUnusedChargeShotGun3DUI(List<int> indexs)
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal abstract class UIHudNameDamageController : UIBaseController
{
	private sealed class _003CRemoveDamageEffect_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public uint UniqueID;

		public UIHudNameDamageController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRemoveDamageEffect_003Ed__32(int _003C_003E1__state)
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

	protected readonly Color CRITICAL_DAMAGE;

	protected readonly Color NORMAL_DAMAGE;

	protected readonly Color HEALING;

	protected readonly Color VEHICLE_SHIELD_DAMAGE;

	protected readonly Color SHIELD_DAMAGE;

	protected readonly Color CRITICAL_DAMAGE_NOBLOOD;

	protected readonly Color NORMAL_DAMAGE_NOBLOOD;

	protected readonly Color FRIEND_COLOR;

	protected readonly Color HEADSHOT_DAMAGE;

	protected Queue m_QueueDamageStates;

	protected UIInGameScene m_InGameScene;

	private AccumulatedDamageInfo m_AccumulatedDamageInfo;

	protected Dictionary<uint, Coroutine> m_ID2Coroutine;

	private GameObject m_LastObj;

	private uint m_DamageUniqueID;

	private float m_AccumulatedDamageDelay;

	private bool m_AccumulatedDamageDelaySpecified;

	protected bool HasAccumulateDamage()
	{
		return false;
	}

	protected bool HandleAccumulatedDamageBase(int damage, LLEDPGIGCMO colliderT, int shieldDamage, int weaponID, float delay, float accumSpan)
	{
		return false;
	}

	protected void SetEnemeySpecialInfo(CECJMLEEPLG specialDamageType, bool isHealing, bool isDecreaseByPetSkill, bool isGSDamage, bool isShowMissingDamage, string damageIconName, Color damageIconColor)
	{
	}

	protected AccumulatedDamageInfo GetAccumylateInfo()
	{
		return null;
	}

	protected void ResetAccumulatedDamageInfo(uint UniqueID)
	{
	}

	protected void ShowAccumulatedDamageLabel(AttackableEntity attackTarget, Player player, AccumulatedDamageInfo info, bool merge, float delay)
	{
	}

	protected virtual GameObject GetDamageGameObject(Player player = null, bool IsGSDamage = false)
	{
		return null;
	}

	protected virtual void SetupHitLabel(GameObject cloneLabelGO, AttackableEntity attackTarget, AccumulatedDamageInfo info, bool isDamageLabelType1, ref int xOff, ref int yOff)
	{
	}

	protected virtual void StartDamageCoroutine(GameObject cloneLabelGO, float delay, uint uniqueID)
	{
	}

	protected virtual Coroutine RemoveDamageEffectCoroutine(float delay, uint uniqueID)
	{
		return null;
	}

	protected virtual void AfterShowDamage()
	{
	}

	private void ShowCrossHairInfo()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected void ReturnDamageLabel(GameObject obj)
	{
	}

	protected virtual void ClearQueueDamage()
	{
	}

	protected IEnumerator RemoveDamageEffect(float delayTime, uint UniqueID)
	{
		return null;
	}

	protected void ClearDamageLabelCor()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudNameEnemyController : UIHudNameDamageController, IHudNameController
{
	private sealed class _003CDelayHideBuffECACustomContentLabel_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudNameEnemyController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideBuffECACustomContentLabel_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003CShowDamageEffect_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public GameObject effectGO;

		public float removeDelay;

		public UIHudNameEnemyController _003C_003E4__this;

		public uint UniqueID;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDamageEffect_003Ed__42(int _003C_003E1__state)
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

	private sealed class _003CShowOldDamageEffect_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public GameObject effectGO;

		public UIHudNameEnemyController _003C_003E4__this;

		public ResourceID id;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowOldDamageEffect_003Ed__41(int _003C_003E1__state)
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

	private UIHudNameEnemyView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private uint m_BindObjectAttackableID;

	private Vector3 m_PositionBind;

	private BindType m_BindType;

	private FollowCamera m_FollowCamera;

	private Camera m_FollowCameraComponent;

	private readonly Queue<GameObject> m_BuffECAContentLabels;

	private float m_RemoveHitDamageDelay;

	private bool m_ExecuteKillEffectActive;

	private Vector3 m_LastNamePos;

	private string MissStr;

	private Queue m_QueueOldDamageStates;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
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

	public void UnbindPlayer()
	{
	}

	public void BindObject(uint unique_id)
	{
	}

	public void BindPosition(Vector3 position)
	{
	}

	private void LateUpdate()
	{
	}

	private void InitCam()
	{
	}

	private void UpdateNamePosition()
	{
	}

	private void InitModeSpecialInfo()
	{
	}

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	private Vector3 GetAIRefPos(NetworkAIPawn ai)
	{
		return default(Vector3);
	}

	internal void OnGotHit(GEvent data)
	{
	}

	internal void OnGetHitObject(object[] data)
	{
	}

	private static bool IsHeadShotCollider(LLEDPGIGCMO colliderT)
	{
		return false;
	}

	private void PlayPVPHit(Player targetPlayer, int damage, int shieldDamage, LLEDPGIGCMO colliderT, float delay, CECJMLEEPLG specialDamageType, bool isHealing, bool isDecreaseByPetSkill, bool isGSDamage, bool isShowMissDamage, int weaponID, string damageIconName, Color damageIconColor)
	{
	}

	private GameObject CreatePVPHitGameObject(Player targetPlayer, bool isGSDamage)
	{
		return null;
	}

	private void SetPVPHitLabel(GameObject cloneLabelGO, int damage, int shieldDamage, LLEDPGIGCMO colliderT, CECJMLEEPLG specialDamageType, bool isHealing, bool isDecreaseByPetSkill, bool isShowMissDamage, bool isGSDamage, int weaponID, string damageIconName, Color damageIconColor, ref int xOff, ref int yOff)
	{
	}

	private string GetDamageTxtBySpecialDamageType(int damage, CECJMLEEPLG specialDamageType, bool isDecreaseByPetSkill)
	{
		return null;
	}

	private GameObject CreatePVEHitGameObject()
	{
		return null;
	}

	private void SetPVEHitLabel(GameObject cloneLabelGO, AttackableEntity targetP, int damage, int shieldDamage, LLEDPGIGCMO colliderT, CECJMLEEPLG specialDamageType, bool isHealing, bool isDecreaseByPetSkill, bool isShowMissingDamage, int weaponID, string damageIconName, Color damageIconColor)
	{
	}

	private void PlayPVEHit(AttackableEntity targetP, int damage, int shieldDamage, LLEDPGIGCMO colliderT, float delay, CECJMLEEPLG specialDamageType, bool isHealing, bool isDecreaseByPetSkill, bool isShowMissingDamage, int weaponID, string damageIconName, Color damageIconColor)
	{
	}

	private void PlayObjectHit(int damage, LLEDPGIGCMO collider_type, float delay, AGACNOCEEFP weaponData)
	{
	}

	public void ShowBuffECACustomContentLabel(BDPIKIMBPGN eventContext)
	{
	}

	private IEnumerator DelayHideBuffECACustomContentLabel()
	{
		return null;
	}

	private IEnumerator ShowOldDamageEffect(GameObject effectGO, float delay, ResourceID id)
	{
		return null;
	}

	private IEnumerator ShowDamageEffect(GameObject effectGO, float delay, uint UniqueID = 0u, float removeDelay = -1f)
	{
		return null;
	}

	private void OnDamageShowTypeChange(int newtype, int oldType)
	{
	}

	private void OnDamageLabelTotalChange(int newTotal, int oldTotal)
	{
	}

	protected override void ClearQueueDamage()
	{
	}

	private void HandleAccumulatedDamage(AttackableEntity targetPlayer, Player player, int damage, int shieldDamage, LLEDPGIGCMO colliderT, float delay, CECJMLEEPLG specialDamageType, bool isHealing, bool isDecreaseByPetSkill, bool isGSDamage, bool isShowMissingDamage, int weaponID, string damageIconName, Color damageIconColor, float accumSpan)
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

	public void _003C_003EiFixBaseProxy_ClearQueueDamage()
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
}

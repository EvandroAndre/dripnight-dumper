using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

internal class BountyWaitingUAV : AttackableEntity
{
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UnityEngine.Object ob;

		internal void _003COnDead_003Eb__0()
		{
		}
	}

	private sealed class _003CRandomTakeDamageSelf_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BountyWaitingUAV _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRandomTakeDamageSelf_003Ed__27(int _003C_003E1__state)
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

	public Action<BountyWaitingUAV> _OnPostDead;

	public AnimationCurve MoveCurve;

	public int MAXHP;

	public float MAXFlyTime;

	public float SelfTakeDamageRat;

	public int m_HP;

	public Transform FireEffect;

	public int Damage;

	public float DamageDuration;

	public float ImpactEffectSpawnDuration;

	public float ChangeDamageTargetDuration;

	public bool NoRespawn;

	private float m_LastDamageTime;

	private float m_LastChooseDamageTargetTime;

	private bool m_IsDamageToLocalPlayer;

	private bool m_IsUpdateMove;

	private float m_ActiveTime;

	private Coroutine m_RandomDamgeCor;

	private Vector3 m_StartPos;

	private Vector3 m_EndPos;

	private float m_LastHitEffectSpawnTime;

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnAwake()
	{
	}

	public override void TakeDamage(GLLLEDKLLDA damageInfo, LOAEBBHPMEK damagerWeaponDynamicInfo = null, List<float> checkParams = null, uint vehicleDataID = 0u)
	{
	}

	public void SimpleTakeDamage(int damage, int weaponDataID = -1)
	{
	}

	protected override void OnDead()
	{
	}

	private void Update()
	{
	}

	private IEnumerator RandomTakeDamageSelf()
	{
		return null;
	}

	private bool IsDamageSelf()
	{
		return false;
	}

	private void UpdateMove()
	{
	}

	private void UpdateRandomFire()
	{
	}

	private void ChooseDamageTarget()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudVerticlePlayerHPController : UIHudNameBaseController
{
	private sealed class _003CHideArrow_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudVerticlePlayerHPController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHideArrow_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CPlayHpChangedAnim_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudVerticlePlayerHPController _003C_003E4__this;

		public int curHp;

		public int maxHp;

		private float _003ClerpValue_003E5__2;

		private float _003CpreFillAmount_003E5__3;

		private float _003CtargetFillAmount_003E5__4;

		private float _003Cspeed_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayHpChangedAnim_003Ed__29(int _003C_003E1__state)
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

	private UIHudVerticlePlayerHPView m_View;

	public VerticleViewPlayer VPlayer;

	private Color m_TeammateLabelColor;

	private Color m_EnemyLabelColor;

	private string m_TeammateHpIcon;

	private string m_EnemyHpIcon;

	private int m_MaxDamageLabelCount;

	private List<UIHudVerticlePlayerHPDamageLabelParam> m_DamageLabelList;

	private List<float> m_DamageLabelLifeTimeList;

	private int m_CurLabelIndex;

	private float m_DamageLabelLifeTime;

	private Coroutine m_HpChangedCor;

	private float m_HpChangeAnimTime;

	private float m_HpYellowShineThreshold;

	private float m_HpRedShineThreshold;

	private List<UISprite> m_BulletLifeList;

	private float m_PerBulletLife;

	private ResourceID m_DamageSoundId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	private void CreateDamageLabel()
	{
	}

	public void ShowDamageLabel(int damage)
	{
	}

	private void OnMaxHpChange(object[] data)
	{
	}

	public void PlayerBulletEmptyAnim()
	{
	}

	public void SetData(VerticleViewPlayer player, int bulletNum, ResourceID resId, float perBulletLife = 100f)
	{
	}

	private IEnumerator HideArrow()
	{
		return null;
	}

	private IEnumerator PlayHpChangedAnim(int curHp, int maxHp)
	{
		return null;
	}

	public void OnHpChanged(int preHp, int curHP, int maxHP)
	{
	}

	private void FixedUpdate()
	{
	}

	public void UpdateBulletLife(float bulletLife)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}
}

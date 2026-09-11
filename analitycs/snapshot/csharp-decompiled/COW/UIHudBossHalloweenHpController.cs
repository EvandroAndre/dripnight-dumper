using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBossHalloweenHpController : UIBaseController
{
	private enum EBuffTipsType
	{
		None,
		NotHaveBuffOnBossSpawn,
		GetBuff,
		LoseBuff
	}

	private sealed class _003CAutoHide_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBossHalloweenHpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoHide_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CAutoHideVfx_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBossHalloweenHpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoHideVfx_003Ed__29(int _003C_003E1__state)
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

	private UIHudBossHalloweenHpView m_view;

	private Coroutine m_AutoHideCo;

	private Coroutine m_VfxHideCo;

	private NetworkAIPawn m_Boss;

	private Player m_Player;

	private float m_BossHalloweenHPShowTime;

	private float m_BossHalloweenHPShowDistance;

	private float m_ShowHpBarDragonDistance;

	private float m_lastUpdateBossHpShowTime;

	private EBuffTipsType m_lastBuffTipsType;

	private uint m_CurHp;

	private uint m_CurMaxHp;

	private NetworkAIDragonBoss m_DragonBoss;

	private Dictionary<int, float> BuffTipsTypeLastTimeDict;

	private uint BuffTipsDelayCall;

	private Action BuffTipsDelayCallAction;

	private LLEDPGIGCMO m_ShowDragonDamageType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitBuffTip()
	{
	}

	private void OnDamageBuffUpdate(bool data)
	{
	}

	public void ChangeDragonIcon()
	{
	}

	public void OnShowBoss(BHGGAEEHJCO bossPlayerID, bool isHit)
	{
	}

	private void UpdateBuff(bool showInBossSpawn)
	{
	}

	private void CloseOldBuffTip(EBuffTipsType mLastBuffTipsType, EBuffTipsType type)
	{
	}

	private void OnBossHPChange(object[] data)
	{
	}

	private void UpdateBuffTipShow(EBuffTipsType type)
	{
	}

	private IEnumerator AutoHide()
	{
		return null;
	}

	private IEnumerator AutoHideVfx()
	{
		return null;
	}

	private void Update()
	{
	}

	private void HideIfAutoOutRange(bool force = false)
	{
	}

	private void RefreshHpBar()
	{
	}

	private void OnBossDead(ulong id)
	{
	}

	private void _003COnUIInit_003Eb__19_0(GameObject go, bool state)
	{
	}

	private void _003COnUIInit_003Eb__19_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

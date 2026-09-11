using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIVerticleViewGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVerticleViewGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003COpenHud_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVerticleViewGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__12(int _003C_003E1__state)
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

	private UIHudVerticleViewJoystickController m_MoveUI;

	private UIHudVerticleViewFireController m_FireUI;

	private UIHudVerticleSkillController m_SkillUI;

	private UIHudVerticleViewKilledController m_KilledUI;

	private UIHudVerticleViewRevivingTipController m_RevivingTipUI;

	private UIHudVerticleViewCommonTipController m_CommonTipUI;

	private UIHudVerticleViewRoleController m_SelectRole;

	private UIHudVerticleMatchInfoController m_MatchInfoUI;

	private UIHudVerticleIntroInfoController m_IntroInfoUI;

	private UIHudVerticleViewTeamScoreBoardController m_TeamScoreBoardUI;

	private UIHudVerticleViewShowTimeController m_MatchEndTimer;

	public override void RegisterGameEventHandler()
	{
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected override void OnHudSettingChanged(object[] param)
	{
	}

	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	public bool IsFireBtnPress()
	{
		return false;
	}

	public float GetDragRatio(bool isSkill)
	{
		return 0f;
	}

	public Vector3 GetFireDirection(ref bool isSkill)
	{
		return default(Vector3);
	}

	protected override void AddTeammateHud(BHGGAEEHJCO id)
	{
	}

	public void ShowKill(int killCount)
	{
	}

	public UIHudVerticlePlayerHPController GetHudHpCtrl()
	{
		return null;
	}

	public void ShowIntroInfo()
	{
	}

	public void CloseIntroInfo()
	{
	}

	public void ShowRevivingTip()
	{
	}

	public void ShowRevivedTip()
	{
	}

	public void ShowReloadingTip()
	{
	}

	public void ShowTeamScoreBoard()
	{
	}

	public void ShowSelectRole(uint localPlayerId)
	{
	}

	public void RefreshMatchInfoUI()
	{
	}

	public void OnTeammateSelectRole(int roleId)
	{
	}

	public void CloseSelectRole()
	{
	}

	public void ShowGameStartTips()
	{
	}

	public void ShowFireTutorial()
	{
	}

	public void UpdateFireInput()
	{
	}

	public void DoMatchEnd(bool isWin)
	{
	}

	private void ShowResult()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHudSettingChanged(object[] P0)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_AddTeammateHud(BHGGAEEHJCO P0)
	{
	}
}

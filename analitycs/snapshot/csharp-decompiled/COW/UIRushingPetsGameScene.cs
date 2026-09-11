using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIRushingPetsGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRushingPetsGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003COpenHud_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRushingPetsGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__5(int _003C_003E1__state)
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

	public const uint VISIBILITY_STATE_EnabelDash = 1073741824u;

	protected ADJGKGIEEBL m_CurPhaseType;

	protected UIHUDRushingPetsLevelEndShowController m_CurLevelEndShowCtrl;

	protected UIHudSpeedupAreaController m_RushingSpeedUI;

	protected UIHUDRushingPetsJumpController m_RushingJumpUI;

	protected UIHudMovingJoystickController m_RushingPetsMoveUI;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
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

	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	public virtual void OpenSpeedUpHUD()
	{
	}

	public virtual void OpenJumpBtn()
	{
	}

	protected void OpenCountDownTip()
	{
	}

	public virtual void OpenMatchResult()
	{
	}

	public virtual void OpenLevelEndShowUI(CMBFDHADLAI msg)
	{
	}

	protected virtual void OpenMatchInfo()
	{
	}

	protected virtual void OpenMoveJoyStick()
	{
	}

	protected void ShowMovementUI(bool isShow)
	{
	}

	protected virtual void OnNewPhase(object[] data)
	{
	}

	protected void OnPhaseEndTimeCome(object[] data)
	{
	}

	protected virtual void OpenIntroInfo()
	{
	}

	public void OnIntroInfoDone(object[] data)
	{
	}

	protected override void OnHudSettingChanged(object[] param)
	{
	}

	private void _003COpenIntroInfo_003Eb__22_0()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
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

	public ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnHudSettingChanged(object[] P0)
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

internal class UIGiantGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGiantGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__16(int _003C_003E1__state)
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

	private UIHudGiantMatchInfoController m_GiantMatchInfoCtrl;

	private UIHudEscortVehicleInfoController m_VehicleInfoCtrl;

	private UIHudEscortBossNameController m_EscortBossNameCtrl;

	private UIHudEscortVehicleProgressController m_VehicleProgressCtrl;

	private UIHudEscortMaskController m_MaskCtrl;

	private UIHudGameShowInfoController m_ShowInfoCtrl;

	private const string Attack_StartGameKey = "T_23_GG_ESCORT_TUTORIAL_ATTACK_DES";

	private const string Denfence_StartGameKey = "T_23_GG_ESCORT_TUTORIAL_DEFENCE_DES";

	private UIHudEscortEquipSetSelectionController m_EquipCtrl;

	private UIHudFeedZoneController m_FeedCtrl;

	private UIHudEscortTipsController m_EscortTipCtrl;

	private uint m_DelayCallId;

	private bool m_IntroShowed;

	public bool JudgeOpenSelection()
	{
		return false;
	}

	public void OpenEquipSetSelection()
	{
	}

	public void OnCloseEquipSetSelection(object[] data)
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public void SetEscortTips(string content, BHGGAEEHJCO playerid)
	{
	}

	protected override void OnMaskClosed()
	{
	}

	public void OnEnterPregame()
	{
	}

	protected override void OnPlayerGodBegin(object[] param)
	{
	}

	public void OnIntroEnd()
	{
	}

	private void OnShowEscortInfo(object[] param)
	{
	}

	private void OnShowEscortMask(object[] param)
	{
	}

	private void OnNewPhaseStarted(object[] param)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private void _003COpenEquipSetSelection_003Eb__14_0()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private void _003COnEnterPregame_003Eb__21_0()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnMaskClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerGodBegin(object[] P0)
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}

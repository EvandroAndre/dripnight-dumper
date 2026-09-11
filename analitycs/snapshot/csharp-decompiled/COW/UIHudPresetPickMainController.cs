using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPresetPickMainController : UIBaseController
{
	public enum EPresetPickChangeLoadoutState
	{
		Normal,
		BanChange,
		Changing
	}

	private sealed class _003CRefreshChangeSkillClickMaskCoroutineInternal_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPresetPickMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshChangeSkillClickMaskCoroutineInternal_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CRefreshLoadoutClickMaskCoroutineInternal_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPresetPickMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshLoadoutClickMaskCoroutineInternal_003Ed__49(int _003C_003E1__state)
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

	private UIHudPresetPickMainView m_View;

	private UIHudPresetPickSkillInfoController m_CurSkillInfoCtrl;

	private UIHudPresetPickLoadoutChooseItemController m_CurChooseLoadoutChooseItemCtrl;

	private Dictionary<uint, UIHudPresetPickTeammateInfoController> m_TeammateInfoCtrlDic;

	private List<UIHudPresetPickSkillChooseItemController> m_CanChooseSkillInfoCtrlList;

	private List<UIHudPresetPickLoadoutChooseItemController> m_CanChooseLoadoutChooseItemCtrlList;

	private bool m_LastSyncIsChangingSkill;

	private bool m_IsChangingSkill;

	private EPresetPickChangeLoadoutState m_ChangeLoadoutState;

	private bool m_LastSyncIsChangingLoadout;

	private uint m_ChangingSkillSuccessVFXHolderID;

	private uint m_ChangingLoadoutSuccessVFXHolderID;

	private UIClickMask m_ClickMask;

	private Coroutine m_RefreshClickMaskCoroutine;

	private UIDetailTipsInGameController m_DetailTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitUIView()
	{
	}

	private void RefreshPlayerCurSkillInfo()
	{
	}

	private void RefreshPlayerCurLoadoutInfo()
	{
	}

	private void ShowEmptyLoadoutIcon(bool show)
	{
	}

	private void RefreshTeammateInfo()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void ClearUIFX()
	{
	}

	private void ClearClickMask()
	{
	}

	private void ShowTutorial()
	{
	}

	private void ShowTeammateInfoTutorial()
	{
	}

	private void StopCurrentTutorial()
	{
	}

	private void SetChangeSkillView()
	{
	}

	private void RefreshChangeSkillClickMaskView()
	{
	}

	private void AddChangeSkillClickMask()
	{
	}

	private void OnChangeSkillBtnClick()
	{
	}

	private void RefreshChangeSkillClickMaskCoroutine()
	{
	}

	private IEnumerator RefreshChangeSkillClickMaskCoroutineInternal()
	{
		return null;
	}

	private void RefreshCanChooseSkillInfo()
	{
	}

	private void OnCloseChangeSkillBtnClick()
	{
	}

	private void OnPresetChanged(bool needRefreshUIFX)
	{
	}

	private void PlayChangingSkillSuccessVFX()
	{
	}

	private void OnTeammateSkillChanged(object[] data)
	{
	}

	private void SetChangeLoadoutView()
	{
	}

	private void RefreshLoadoutClickMask()
	{
	}

	private void AddChangeLoadoutClickMask()
	{
	}

	private void BanChangeLoadout()
	{
	}

	private void RefreshCanChooseLoadoutInfo()
	{
	}

	private void OnChangeLoadoutBtnClick()
	{
	}

	private void RefreshLoadoutClickMaskCoroutine()
	{
	}

	private IEnumerator RefreshLoadoutClickMaskCoroutineInternal()
	{
		return null;
	}

	private void OnCloseChangeLoadoutBtnClick()
	{
	}

	private void OnBanChangeLoadoutBtnClick()
	{
	}

	private void OnLoadoutChanged(bool needRefreshUIFX)
	{
	}

	private void PlayChangingLoadoutSuccessVFX()
	{
	}

	private void OnTeammateLoadoutChanged(object[] data)
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshTeammateInfoVisibility()
	{
	}

	private void SyncChangingState(bool forceSync)
	{
	}

	private void OnCanChangingLoadoutChanged(object[] data)
	{
	}

	private void OnIsChangingSkillChanged(object[] data)
	{
	}

	private void OnIsChangingLoadoutChanged(object[] data)
	{
	}

	private void ShowSkillInfoPop(GEvent data)
	{
	}

	private void CloseDetailTips()
	{
	}

	private void _003CAddChangeSkillClickMask_003Eb__33_0()
	{
	}

	private void _003CAddChangeLoadoutClickMask_003Eb__44_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}

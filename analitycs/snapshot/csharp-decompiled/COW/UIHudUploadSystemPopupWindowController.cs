using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUploadSystemPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum EPublishSource
	{
		FromUI,
		FromClose,
		FromSwitchToggle
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__59_0;

		internal void _003COnClickDeleteBtn_003Eb__59_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIHudUploadSystemPopupWindowController _003C_003E4__this;

		public bool isClose;

		public int targetToggleIdx;

		internal void _003CSecondConfirm_003Eb__0()
		{
		}

		internal void _003CSecondConfirm_003Eb__1()
		{
		}

		internal void _003CSecondConfirm_003Eb__2()
		{
		}

		internal void _003CSecondConfirm_003Eb__3()
		{
		}

		internal void _003CSecondConfirm_003Eb__4()
		{
		}

		internal void _003CSecondConfirm_003Eb__5()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIHudUploadSystemPopupWindowController _003C_003E4__this;

		public int toggleIdx;

		internal void _003CCreateToggleByIdx_003Eb__0()
		{
		}
	}

	private sealed class _003CShowDefaultPreview_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUploadSystemPopupWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDefaultPreview_003Ed__31(int _003C_003E1__state)
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

	private UIHudUploadSystemPopupWindowView m_View;

	private List<string> m_HudNameList;

	private int m_CurrentSelectedToggleIdx;

	private uint m_TotalToggleCount;

	private Coroutine m_ShowPreviewCoroutine;

	private UIModelCheckNameValid m_ModelCheckNameValid;

	private UIModelSetting m_ModelSetting;

	private UIModelKolHud m_ModelKolHud;

	private List<HudUploadToggle> m_Toggles;

	private bool m_HasDescEverGotFocus;

	private UIHudSelectTagPopupController m_HudSelectTagPopupCtrl;

	private List<UIHudUploadTagController> m_HudUploadTagControllerList;

	private UIKolHudFastPreviewController m_SelectedPreviewCtrl;

	private List<string> m_PublishDisableReasonKeyList;

	private List<int> m_PublishDisableReasonList;

	private EPublishSource m_PublishSource;

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

	protected override void OnDestroy()
	{
	}

	public void SetViewData()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnCancelPublishBtnClick()
	{
	}

	private void SecondConfirm(bool isClose, int curToggleIdx, int targetToggleIdx = -1)
	{
	}

	private void GenerateToggleData()
	{
	}

	private void InitToggleLength()
	{
	}

	private HudUploadToggle CreateToggleByIdx(int toggleIdx)
	{
		return null;
	}

	private void OnToggleClick(int toggleIdx)
	{
	}

	private void OnToggleSwitchSucc(int toggleIdx)
	{
	}

	private void OnToggleSwitchCancel()
	{
	}

	private IEnumerator ShowDefaultPreview()
	{
		return null;
	}

	private void RefreshPanelData(int toggleIdx)
	{
	}

	private void RefreshHudNameInput(int toggleIdx)
	{
	}

	private void RefreshDescriptionInput(int toggleIdx)
	{
	}

	private void RefreshLikeCntLabel(int toggleIdx)
	{
	}

	private void RefreshSelectedPreview(int toggleIdx)
	{
	}

	private void RefreshEditState(int toggleIdx)
	{
	}

	private void RefreshNormalState(int toggleIdx)
	{
	}

	private void RefreshBtnView(bool isShowEnable)
	{
	}

	private void OnTagSelectConfirm(object[] args = null)
	{
	}

	private void RefreshTag(int toggleIdx, bool isEditState = true)
	{
	}

	private void ClearHudUploadTagControllers()
	{
	}

	private void OnClickSelectHudBtn()
	{
	}

	private void OnSelectHudFinish(int hudIdx)
	{
	}

	private void ShowPopupMessage(string message)
	{
	}

	private void OnClickEditSensiBtn()
	{
	}

	private void OnClickShowSensiBtn()
	{
	}

	private void OnClickEditDescBtn()
	{
	}

	private void RefreshPublishBtnState()
	{
	}

	private void OnDescriptionGetFocus()
	{
	}

	private void OnDescriptionLostFocus()
	{
	}

	private void OnClickEditNameButton()
	{
	}

	private void OnClickDisablePublishBtn()
	{
	}

	private void OnHudUploadEditNameConfirm(object[] args = null)
	{
	}

	private void OnClickPublishBtn()
	{
	}

	private void OnPublishSucc()
	{
	}

	private void OnPublishFail()
	{
	}

	private void OnClickSelectHudTagBtn()
	{
	}

	private void OnClickDeleteBtn()
	{
	}

	private void OnClickEditHudBtn()
	{
	}

	private void OnSetSensitivityFinish()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnClickDeleteBtn_003Eb__59_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIKolHudSelectPopWndController : UIPopupWindowController
{
	private sealed class _003CCreateFastPreviewsCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIKolHudSelectPopWndController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateFastPreviewsCoroutine_003Ed__18(int _003C_003E1__state)
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

	private UIHudFastPreviewSelectPopupView m_View;

	private const int FastPreviewCount = 4;

	private List<UIKolHudFastPreviewController> m_FastPreviewList;

	private Coroutine m_CreateFastPreviewCoroutine;

	private UIModelKolHud m_ModelKolHud;

	private bool m_IsUseSensitivity;

	private KolHudDetail m_SelectHudDetail;

	private float m_BGLength;

	private float[] m_sensitivitySettings;

	private bool m_IsHudUpload;

	private UIKolHudPopWndController m_UIKolHudPopWndController;

	private EHudShareGetSource m_HudGetSource;

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

	private void ClearFastPreviews()
	{
	}

	private void CreateFastPreviewsAsync()
	{
	}

	private IEnumerator CreateFastPreviewsCoroutine()
	{
		return null;
	}

	public void RefreshFastPreviewsChosen()
	{
	}

	private void OnUseConfirmBtnClick()
	{
	}

	private void HadndleUseHudSetting()
	{
	}

	private void OnUseSensitivityChange()
	{
	}

	private void OnPreviewSensivityEntranceClick()
	{
	}

	public void SetSelectHudInfo(KolHudDetail itemData, bool isUseSensitivity, string player_name, UIKolHudPopWndController kolHudPopWndCtrl)
	{
	}

	public void OnQrCodeSuccess(byte[] hud_settings, string playerName, ulong player_id, bool isUseSensitivity, UIKolHudPopWndController kolHudPopWndCtrl)
	{
	}

	public void SetHudShareGetSource(EHudShareGetSource source)
	{
	}

	public void SetViewDataForHudUpload()
	{
	}

	private void OnEnableConfirmBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

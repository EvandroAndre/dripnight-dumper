using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTC_DecipherPopupWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private sealed class _003CScrollProgress_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomTC_DecipherPopupWndController _003C_003E4__this;

		private int _003CFinalCount_003E5__2;

		private float _003CdeltaCount_003E5__3;

		private float _003CNowCount_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollProgress_003Ed__35(int _003C_003E1__state)
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

	private sealed class _003CWaitOpenAnimation_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomTC_DecipherPopupWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitOpenAnimation_003Ed__34(int _003C_003E1__state)
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

	private UIBigEvent_CustomTC_DecipherPopupWndView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private CustomTCPieceInfo m_PieceInfo;

	private CustomTCPieceInfo.TCPieceState m_PieceState;

	private bool m_IsDecoding;

	private ResourceID m_DecipherVFXResID;

	private GameObject m_DecipherVFXGO;

	private ResourceID m_SuccessVFXResID;

	private GameObject m_SuccessVFXGO;

	private const string TC_IDLE_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_Stand";

	private const string TC_OPEN_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_Open";

	private const string TC_DECIPHER_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_Noise";

	private const string TC_PERFECT_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_Explode";

	private const string TC_VIEW_OPEN_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_UiOpen";

	private const string TC_VIEW_EXOLODE_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_UiExplode";

	private const string TC_VIEW_SUCCESS_ANIM = "UIFX_Jumpsuit23B_DecipherPopupWnd_UiSuccesslabel";

	private Animation m_VFX_Animation;

	private uint m_OldProgress;

	private uint m_TargetProgress;

	private uint m_Multiple;

	private float m_AnimationTime;

	private const float ScrollTime = 0.8f;

	private float m_Open_Time;

	private float m_Decipher_Time;

	private float m_Perfect_Time;

	private float m_uiOpen_Time;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

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

	public void SetPieceInfo(uint pieceId, uint oldProgress, uint targetProgress, uint multiple)
	{
	}

	private void SetProgressInfo(uint oldProgress, uint targetProgress, uint multiple)
	{
	}

	public void PlayProgressInfo(uint oldProgress, uint targetProgress, uint multiple)
	{
	}

	private void PlayProgressInfo()
	{
	}

	private IEnumerator WaitOpenAnimation()
	{
		return null;
	}

	private IEnumerator ScrollProgress()
	{
		return null;
	}

	private void RefreshViewBeforeAnim()
	{
	}

	private void RefreshViewEndAnim()
	{
	}

	private void MakeItemPixelPerfect()
	{
	}

	private void InitEffectVFX()
	{
	}

	private void DestoryEffectVFX()
	{
	}

	private void OnClickDecipherBtn()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnMaskCloseBtnClick()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected void PlayAnimationSafe(Animation animation, string clipName)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTC_OpenPopupWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private sealed class _003CCloseOpenView_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomTC_OpenPopupWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseOpenView_003Ed__21(int _003C_003E1__state)
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

	private UIBigEvent_CustomTC_OpenPopupWndView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private uint m_OpenAnimationDelayCall;

	private ResourceID m_TCStartOpenVFXResID;

	private GameObject m_TCStartOpenVFXGO;

	private const string TCStartOpenVFXName = "UIFX_Jumpsuit23B_OpenPopupWnd_in";

	private ResourceID m_TCStartPrintVFXResID;

	private GameObject m_TCStartPrintVFXGO;

	private const string TCStartPrintVFXName = "UIFX_Jumpsuit23B_OpenPopupWnd_loop";

	private ResourceID m_TCStartSuccesVFXResID;

	private GameObject m_TCStartSuccesVFXGO;

	private const string TCStartSuccesVFXName = "UIFX_Jumpsuit23B_OpenPopupWnd_Sucess";

	private const string START_PRINT_ANIM = "UIFX_Jumpsuit23B_main_loop_ani";

	private const string STSRT_SUCCESS_ANIM = "UIFX_Jumpsuit23B_main_once_ani";

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

	protected override void OnSetNavigationController()
	{
	}

	private void StartOpenAnimation()
	{
	}

	private void OnMaskClick(GameObject go, bool press)
	{
	}

	private IEnumerator CloseOpenView()
	{
		return null;
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void InitEffectVFX()
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

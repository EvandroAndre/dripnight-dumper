using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIJerseyNumberEditPopWndController : UIPopupWindowController
{
	private sealed class _003CRepeatSingleDigitMinus_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIJerseyNumberEditPopWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRepeatSingleDigitMinus_003Ed__47(int _003C_003E1__state)
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

	private sealed class _003CRepeatSingleDigitPlus_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIJerseyNumberEditPopWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRepeatSingleDigitPlus_003Ed__46(int _003C_003E1__state)
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

	private sealed class _003CRepeatTenDigitMinus_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIJerseyNumberEditPopWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRepeatTenDigitMinus_003Ed__45(int _003C_003E1__state)
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

	private sealed class _003CRepeatTenDigitPlus_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIJerseyNumberEditPopWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRepeatTenDigitPlus_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003CShowNumberChangeEffectCoroutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIJerseyNumberEditPopWndController _003C_003E4__this;

		private int _003CcurrentSingleDigit_003E5__2;

		private int _003CcurrentTenDigit_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNumberChangeEffectCoroutine_003Ed__37(int _003C_003E1__state)
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

	private UIJerseyNumberEditPopWndView m_View;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private uint m_CollectionId;

	private EJerseyNumberEditPopWndSource m_Source;

	private int m_JerseyNumberInTenDigit;

	private int m_JerseyNumber;

	private Action m_CloseCallback;

	private Coroutine m_TenDigitPlusCoroutine;

	private Coroutine m_TenDigitMinusCoroutine;

	private Coroutine m_SingleDigitPlusCoroutine;

	private Coroutine m_SingleDigitMinusCoroutine;

	private const float m_RepeatInterval = 0.2f;

	private GameObject m_EnableBg;

	private ResourceID m_InfoVfx;

	private UICenterOnChild m_TenDigitCenterOnChild;

	private UICenterOnChild m_SingleDigitCenterOnChild;

	private List<int> m_TenDigitSpriteNames;

	private List<GameObject> m_TenDigitSpriteObjects;

	private List<int> m_SingleDigitSpriteNames;

	private List<GameObject> m_SingleDigitSpriteObjects;

	private float m_ShowNumberChangeEffectIntervalTime;

	private float m_NumberStartScrollTime;

	private float m_TenDigitAndSingleDigitIntervalTime;

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

	private void InitSpriteNames(int jerseyNumberInTenDigit, int jerseyNumber)
	{
	}

	public void SetCollectionID(uint collectionId, EJerseyNumberEditPopWndSource source, Action closeCallback = null)
	{
	}

	public void RefreshView()
	{
	}

	private void ScrollToTenDigit(int targetDigit)
	{
	}

	private void ScrollToSingleDigit(int targetDigit)
	{
	}

	public void OnClickTenDigitPlusButton()
	{
	}

	public void OnClickTenDigitMinusButton()
	{
	}

	public void OnClickSingleDigitPlusButton()
	{
	}

	public void OnClickSingleDigitMinusButton()
	{
	}

	private void OnClickConfirmButton()
	{
	}

	private void ShowInfoVfx()
	{
	}

	private IEnumerator ShowNumberChangeEffectCoroutine()
	{
		return null;
	}

	private void OnCloseButtonClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPressTenDigitPlusButton(GameObject go, bool isPressed)
	{
	}

	private void OnPressTenDigitMinusButton(GameObject go, bool isPressed)
	{
	}

	private void OnPressSingleDigitPlusButton(GameObject go, bool isPressed)
	{
	}

	private void OnPressSingleDigitMinusButton(GameObject go, bool isPressed)
	{
	}

	private IEnumerator RepeatTenDigitPlus()
	{
		return null;
	}

	private IEnumerator RepeatTenDigitMinus()
	{
		return null;
	}

	private IEnumerator RepeatSingleDigitPlus()
	{
		return null;
	}

	private IEnumerator RepeatSingleDigitMinus()
	{
		return null;
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

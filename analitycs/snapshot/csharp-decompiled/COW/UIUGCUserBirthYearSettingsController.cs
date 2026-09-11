using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserBirthYearSettingsController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIPopMenuItemSmallController> _003C_003E9__30_0;

		internal int _003CGetBirthYearDropdownItemControllers_003Eb__30_0(UIPopMenuItemSmallController left, UIPopMenuItemSmallController right)
		{
			return 0;
		}
	}

	private sealed class _003CScrollBirthYearDropdownToDefaultPosition_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCUserBirthYearSettingsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollBirthYearDropdownToDefaultPosition_003Ed__28(int _003C_003E1__state)
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

	private const int MinBirthYear = 1900;

	public static int AdultAge;

	private const int DefaultBottomYearAge = 26;

	private const float BirthYearDropdownMaxShowCount = 6f;

	private const int BirthYearDropdownScrollBarPanelDepthOffset = 1;

	private UIUGCUserBirthYearSettingsView m_View;

	private List<PopMenuData> m_BirthYearDataList;

	private UIPopMenuSmallControler m_BirthYearPopMenuCtrl;

	private int m_SelectedBirthYear;

	private int m_BirthYearDataMaxYear;

	private Coroutine m_ScrollBirthYearDropdownCoroutine;

	public Action ContinueCallback;

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

	protected override void OnUIClose()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnBtnContinueClick()
	{
	}

	private void InitBirthYearPopMenu()
	{
	}

	private void ResetBirthYearSelection()
	{
	}

	private void InjectBirthYearData()
	{
	}

	private void InitBirthYearData()
	{
	}

	private void OnBirthYearSelected(object data)
	{
	}

	private void RefreshBirthYearDataSelection()
	{
	}

	private void RefreshContinueButtonState()
	{
	}

	private bool CanContinue()
	{
		return false;
	}

	private void OnBirthYearPopMenuOpen()
	{
	}

	private void OnBirthYearPopMenuClose()
	{
	}

	private IEnumerator ScrollBirthYearDropdownToDefaultPosition()
	{
		return null;
	}

	private UIScrollView GetActiveBirthYearScrollView()
	{
		return null;
	}

	private List<UIPopMenuItemSmallController> GetBirthYearDropdownItemControllers()
	{
		return null;
	}

	private void RefreshBirthYearDropdownScrollBar(UIScrollView scrollView)
	{
	}

	private void RefreshBirthYearDropdownScrollBarDepth(UIScrollView scrollView, UIScrollBar scrollBar)
	{
	}

	private void HideBirthYearDropdownScrollBar()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}

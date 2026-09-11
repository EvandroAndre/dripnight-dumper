using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeGameplayAffixPreviewController : UIBaseController
{
	private sealed class _003CClosePreviewAfterAnimation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeGameplayAffixPreviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClosePreviewAfterAnimation_003Ed__14(int _003C_003E1__state)
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

	private sealed class _003CPlaySequence_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeGameplayAffixPreviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaySequence_003Ed__13(int _003C_003E1__state)
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

	private int m_PreviewSequenceIdx;

	protected UIGameModeGameplayAffixPreviewView m_View;

	protected UIGameModeGameplayAffixPreviewParameters m_Parameters;

	private UIGameModeGameplayAffixPreviewItemViewData[] m_ViewDataArray;

	private Coroutine m_SequenceCoroutine;

	public bool IsAvailable => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void PopulateEntry1(UIGameModeGameplayAffixPreviewItemViewData viewData)
	{
	}

	private void PopulateSingleEntry()
	{
	}

	private void TryStopSequenceCoroutine()
	{
	}

	private IEnumerator PlaySequence()
	{
		return null;
	}

	protected virtual IEnumerator ClosePreviewAfterAnimation()
	{
		return null;
	}

	private void OnSkipBtnClick()
	{
	}

	private void AddEventDelegates()
	{
	}

	public void SetViewData(UIGameModeGameplayAffixPreviewItemViewData[] viewDataArray)
	{
	}

	public bool Play()
	{
		return false;
	}

	public void AdjustPanelDepthWithBase(int dropdownBaseDepth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

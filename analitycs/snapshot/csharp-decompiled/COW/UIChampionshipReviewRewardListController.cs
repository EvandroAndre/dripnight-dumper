using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIChampionshipReviewRewardListController : UIPopupWindowController, IEasyList
{
	private sealed class _003CDelayRefreshView_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChampionshipReviewRewardListController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshView_003Ed__13(int _003C_003E1__state)
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

	private UIChampionshipReviewRewardListView m_View;

	private ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	private ChampionshipSettingDesc m_ChampionshipSettingInfo;

	private UIModelChampionship m_ModelChampionship;

	private UIClickMask m_Mask;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnCloseButtonClick()
	{
	}

	public void SetChampionshipInfo(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
	}

	public void RefreshView()
	{
	}

	private void ReviseScrollView()
	{
	}

	private IEnumerator DelayRefreshView()
	{
		return null;
	}

	private void RefreshChampionReward()
	{
	}

	protected virtual void RefreshCupIcon()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}

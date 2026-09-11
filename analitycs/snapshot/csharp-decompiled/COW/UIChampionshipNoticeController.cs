using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipNoticeController : UIPopupWindowController
{
	private sealed class _003CAutoScrollItem_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChampionshipNoticeController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoScrollItem_003Ed__14(int _003C_003E1__state)
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

	private UIChampionshipNoticePopupView m_View;

	private ChampionshipSettingDesc m_SettingInfo;

	private List<string> m_CDNUrlList;

	private List<uint> m_GoPosList;

	private List<uint> m_SubGoPosList;

	private int m_selectedIndex;

	private List<UIChampionshipNoticeDotController> m_DotCtrls;

	private List<UIChampionshipNoticeItemController> m_NetworkTextures;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(List<string> CDNUrlList, List<uint> goPosList, List<uint> subGoPosList)
	{
	}

	private void RefreshView()
	{
	}

	private IEnumerator AutoScrollItem()
	{
		return null;
	}

	private void OnAutoScrollAdItem(int next = 1)
	{
	}

	private void OnLeftBtnClick()
	{
	}

	private void OnRightBtnClick()
	{
	}

	private void GetCenterItem(GameObject centeredObject)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

internal class UIHUDRushingPetsLevelEndShowController : UIBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TeammateStats> _003C_003E9__19_0;

		internal int _003CInitLeaderBoardInfo_003Eb__19_0(TeammateStats x, TeammateStats y)
		{
			return 0;
		}
	}

	private sealed class _003CDelayShowCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDRushingPetsLevelEndShowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowCoroutine_003Ed__16(int _003C_003E1__state)
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

	private UIHUDRushingPetsLevelEndShowView m_View;

	private const float WinShowTimeSec = 2.5f;

	private const float RoundEndTipShowTimeSec = 3f;

	private bool m_IsShowWin;

	private bool m_IsLevelEnd;

	private bool m_IsLastRound;

	protected UIModelMatch m_ModelMatch;

	private float m_EndTime;

	private List<int> m_PlayerInfoType;

	private UIHUDRushingPetsPlayerInfoItemController m_SelfUIItem;

	private int m_LocalPlayerItemIndex;

	private const int ShowSelfItemRank = 4;

	private int m_LastLeftTimeCeil;

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

	public void InitData(CMBFDHADLAI msg)
	{
	}

	private IEnumerator DelayShowCoroutine()
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void InitLeaderBoardInfo(List<ODKOGBPDEPP> playerList)
	{
	}

	private void OnPhaseEndTimeCome(object[] data)
	{
	}

	protected void UpdateCheckLocalPlayerInfo()
	{
	}

	private void Update()
	{
	}

	private void UpdateLeftTime()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

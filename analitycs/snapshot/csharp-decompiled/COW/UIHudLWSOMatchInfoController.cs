using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudLWSOMatchInfoController : UIBaseController
{
	private sealed class _003CRefreshTeamHPBGWidth_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLWSOMatchInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTeamHPBGWidth_003Ed__33(int _003C_003E1__state)
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

	private UIHudLWSOMatchInfoView m_View;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private List<UISprite> m_MyTeamHP;

	private List<UISprite> m_OppoTeamHP;

	private CIBDABGDGOM mGame;

	private UIModelMatch m_ModelMatch;

	private int m_TeamCount;

	private bool InitedHP;

	private List<int> m_states;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void SetUIData()
	{
	}

	private void RefreshTeamStatesUI(BHGGAEEHJCO pId)
	{
	}

	private void SetTeamStatesUI(List<BHGGAEEHJCO> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	private void SetHP()
	{
	}

	private void Update()
	{
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnPlayerStateChanged(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnNewMiniPhaseEnter(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void SetRoundInfoUI()
	{
	}

	private int CalTeamCount()
	{
		return 0;
	}

	private void InstantiateHP(object[] param)
	{
	}

	private IEnumerator RefreshTeamHPBGWidth()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}

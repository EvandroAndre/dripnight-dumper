using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarChampionshipInfoController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LeaderBoardInfo> _003C_003E9__35_0;

		internal int _003CGetTargetRankClanScore_003Eb__35_0(LeaderBoardInfo x, LeaderBoardInfo y)
		{
			return 0;
		}
	}

	private sealed class _003CSelectRankTabDefaultCoroutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanWarChampionshipInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSelectRankTabDefaultCoroutine_003Ed__40(int _003C_003E1__state)
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

	private const string FAST_MSG_TEAMLEADER_CHOOSE_CLANWAR_KEY = "T_42_ZZ_CHANGEMODE";

	private UIClanWarChampionshipInfoView m_View;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClan m_ModelClan;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private ClanWarChampionshipStage m_Stage;

	private UIStandardCarouselController m_CarouselController;

	private UIClanWarChampionshipMathPoolController m_MathPoolController;

	private const int ITEMWIDTH = 120;

	private const int ITEMHEIGHT = 150;

	private const int GRIDDOTWIDTH = 25;

	private const int GRIDDOTHEIGHT = 6;

	private const int DOTWIDTH = 22;

	private const int DOTHEIGHT = 6;

	private const string LOBBY_BANNER_DOT_ENABLE_SPRITE_NAME = "FF_UI_Lobby_BannerTab01";

	private const string LOBBY_BANNER_DOT_DISABLE_SPRITE_NAME = "FF_UI_Lobby_BannerTab02";

	private const uint COLOR_GRAY = 2037742847u;

	private const uint COLOR_WHITE = uint.MaxValue;

	private Color m_WhiteColor;

	private Color m_GrayColor;

	private UIClanWarV2LeaderBoardMiniController m_MiniLeaderBoardControllerInQualifier;

	private UIClanWarV2LeaderBoardMiniController m_MiniLeaderBoardControllerInEliminator;

	private string m_Region;

	private bool m_InitLeaderBoard;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshAward()
	{
	}

	private void RefreshQualifierWarmUp()
	{
	}

	private void RefreshQualifierMatch()
	{
	}

	private void RefreshQulifierBtn()
	{
	}

	private void RefreshQualifierSettlement()
	{
	}

	private void RefreshEliminatorWarmUp()
	{
	}

	private void RefreshEliminatorMatch()
	{
	}

	private uint GetTargetRankClanScore(int rank)
	{
		return 0u;
	}

	private void RefreshEliminatorSettlement()
	{
	}

	private void RefreshOutInQualifier()
	{
	}

	private void RefreshOutInEliminator()
	{
	}

	private void RefreshEliminatorFinish()
	{
	}

	private IEnumerator SelectRankTabDefaultCoroutine()
	{
		return null;
	}

	private void RefreshEliminatorBtnTable()
	{
	}

	private void OnRuleBtnInQualifierWarmUpClick()
	{
	}

	private void OnRuleBtnInQualifierMatchClick()
	{
	}

	private void OnRuleBtnInEliminatorClick()
	{
	}

	private void OnOutTipBtnClick()
	{
	}

	private void OnQualifierBtnClick()
	{
	}

	private void CheckAndPlayClanWar()
	{
	}

	private void SendLobbyClanWarMsg()
	{
	}

	private void ChooseClanWarMode()
	{
	}

	private void OnMatchPoolBtnClick()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnEliminatorBattleBtnClick()
	{
	}

	private void CheckAndPlayClanWarChampionship()
	{
	}

	private void ChooseClanWarChampionshipMode()
	{
	}

	private void OnRankTabClick()
	{
	}

	private void OnResultTabClick()
	{
	}

	public void ShowClanBriefBox(ClanInfo info)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

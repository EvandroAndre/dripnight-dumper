using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudReviveSelectController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<InstantKillPlayerData> _003C_003E9__20_0;

		internal int _003CRefreshPendingReviveTeammates_003Eb__20_0(InstantKillPlayerData x, InstantKillPlayerData y)
		{
			return 0;
		}
	}

	public static readonly Color AvailableConfirmBtnColor;

	public static readonly Color UnavailableConfirmBtnColor;

	private UIHUDReviveSelectView m_View;

	private bool m_RequestAll;

	private List<InstantKillPlayerData> m_PlayerList;

	private int m_Selected;

	private List<int> m_MultiSelected;

	private int m_CardPrice;

	private int m_TokenCnt;

	private bool m_MultiRevive;

	private HEOJAGLBHLJ m_CurType;

	private UILabel[] m_NameArray;

	private UISprite[] m_SpriteArray;

	private UILabel[] m_TeamIndexArray;

	private bool m_BuffRevivePointShop;

	private int mOwnerItemId;

	private BGMFPPDLCBB m_OwnerShopItemInfo;

	private List<ulong> m_UserList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(bool all, BGMFPPDLCBB shopItemInfo, HEOJAGLBHLJ shopType, bool buffRevivePoint = false)
	{
	}

	private void RefreshPendingReviveTeammates()
	{
	}

	private List<Player> GetTeammatesInGulagBattle(MatchTeam team)
	{
		return null;
	}

	private void OnPlayer1Click()
	{
	}

	private void OnPlayer2Click()
	{
	}

	private void OnPlayer3Click()
	{
	}

	private void OnPlayerClick()
	{
	}

	private void OnCancelClick()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void ReviveSelectedPlayers(List<int> indexes, int multiBuyIndex = -1)
	{
	}

	private bool IsMultiRevive()
	{
		return false;
	}

	private void RefreshTokenNum(int playerCount)
	{
	}

	public override void Hide()
	{
	}

	private void OnReviveCardDiscountChanged(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}

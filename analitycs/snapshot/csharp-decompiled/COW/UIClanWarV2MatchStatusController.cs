using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanWarV2MatchStatusController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	public enum RoundType
	{
		ClanWar = 1,
		ClanWarChampionship
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GuildWarMemberStats, uint> _003C_003E9__13_0;

		internal uint _003CRefreshView_003Eb__13_0(GuildWarMemberStats x)
		{
			return 0u;
		}
	}

	private UIClanWarV2MatchStatusView m_View;

	private UIModelClanWarV2 m_ModelWar;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private List<GuildWarMemberStats> m_DataList;

	private Action m_OnClose;

	private RoundType roundType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string Rule()
	{
		return null;
	}

	public override string CustomTitle()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RefreshView()
	{
	}

	public void SetCloseAction(Action func)
	{
	}

	public void SetRoundType(RoundType type)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void GotoLeaderBoard()
	{
	}

	private void GotoLeaderBoard_ClanActive()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}

using System;
using GCommon;
using tcp;

namespace COW;

internal class UICustomRoomRankTeamBoardController : UIBaseController
{
	private enum TeamBoardState
	{
		None,
		Empty,
		NotAvaliable,
		HasInfo
	}

	public enum RankTemplateType
	{
		RankTitle,
		TeammateInfo,
		TeamSplit
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RoomGroupMatchStatsInfo> _003C_003E9__10_0;

		internal int _003CRefreshTable2_003Eb__10_0(RoomGroupMatchStatsInfo a, RoomGroupMatchStatsInfo b)
		{
			return 0;
		}
	}

	private UICustomRoomRankTeamBoardView m_View;

	private UIModelCustomRoom m_ModelRoom;

	private TeamBoardState m_State;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnGotoSettingClicked()
	{
	}

	public void RefreshViewData()
	{
	}

	public void UpdatePanelDepth(int depth)
	{
	}

	private void RefreshTable2()
	{
	}

	public int SortTeamMates(RoomPlayerMatchStatsInfo player1, RoomPlayerMatchStatsInfo player2)
	{
		return 0;
	}

	public void GotoSelfTeamPos()
	{
	}

	private void InitTable2Template()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__13_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__13_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__13_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

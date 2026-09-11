using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHUDFootballGameLeaderBoardItemBaseController : UIBaseController
{
	protected UIHudFootballGameLeaderBoardItemView m_View;

	protected Player m_Player;

	protected BHGGAEEHJCO m_PlayerID;

	protected ulong m_UserID;

	private List<int> m_InfoTypeList;

	protected List<UILabel> m_InfoLabelList;

	private Dictionary<int, LeaderBoardSortingData> m_SortingDataDict;

	private List<LeaderBoardSortingData> m_SortingDatas;

	private bool m_Reported;

	private uint m_Rank;

	private UIPrivilegeIconController m_PrivilegeIconController;

	public List<LeaderBoardSortingData> SortingDatas => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitData(List<int> list, Player player, bool isLocalSelf, List<LeaderBoardSortingData> sortingDatas)
	{
	}

	protected virtual void SetInfoLabelList()
	{
	}

	public virtual void RefreshPlayerProfile(bool isLocalSelf)
	{
	}

	protected virtual void OnInitData(Player player)
	{
	}

	protected virtual bool ShowDeadBg()
	{
		return false;
	}

	protected virtual bool ShowTop3Icon()
	{
		return false;
	}

	protected virtual bool UseSelectBGReplaceSelfBG()
	{
		return false;
	}

	public virtual void SetRank(uint rank)
	{
	}

	protected void OnReportBtnClick()
	{
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	protected virtual void OnPlayerAliveStateChanged(uint data)
	{
	}

	public void ShowSelf(bool isShow)
	{
	}

	public BHGGAEEHJCO GetPlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public Player GetPlayer()
	{
		return null;
	}

	public ulong GetUserID()
	{
		return 0uL;
	}

	protected virtual void SetPlayer(Player player)
	{
	}

	public uint GetRank()
	{
		return 0u;
	}

	public void ShowReportButton(bool show)
	{
	}

	private void SetInfoTypeList(List<int> list)
	{
	}

	private void SetSortingDatas(List<LeaderBoardSortingData> sortingDatas)
	{
	}

	private void SetIsSelf(bool isSelf)
	{
	}

	protected virtual void SetDeadBG()
	{
	}

	protected virtual void OnRefreshPlayerStats()
	{
	}

	public void RefreshPlayerStats()
	{
	}

	private void RefreshInfoLabels()
	{
	}

	private void RefreshInfoLabel(int index)
	{
	}

	private void InitInfoLabelByType()
	{
	}

	public void RefreshSortingDatas()
	{
	}

	private void RefreshSortingData(LeaderBoardSortingData sortingData)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

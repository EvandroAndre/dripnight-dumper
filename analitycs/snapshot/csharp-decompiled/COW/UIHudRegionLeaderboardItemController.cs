using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudRegionLeaderboardItemController : UIEasyListItemController
{
	public class CurMatchPlayerInfo
	{
		public ulong UserID;

		public BHGGAEEHJCO PlayerID;

		public string NickName;

		public int Kill;

		public int Death;

		public int Rank;

		public int PeakRankPos;

		public Dictionary<uint, float> PersistentDataDic;
	}

	public class RegionRankPlayerInfo
	{
		public ulong UserID;

		public string NickName;

		public int Rank;

		public int PeakRankPos;

		public Dictionary<uint, float> PersistentDataDic;
	}

	private UIHudRegionLeaderboardItemView m_View;

	private object m_CurData;

	private GameModeStatsConfigManager.GameModeStatsConfig m_Config;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshRankIcon(int rank, int peakRankPos)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void OnNameBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}

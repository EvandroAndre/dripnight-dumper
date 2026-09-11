using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelRankingItem : UIBaseModel
{
	private Dictionary<uint, RankingItemRank> m_RankingItemDict;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessRankingItem(GetRankingItemRankConfigRes res)
	{
	}

	public void ProcessRankingItemRankMapping()
	{
	}

	public RankingItemRank FindRankingItemDataByID(uint itemID)
	{
		return null;
	}

	public bool CheckIsReachRankItemUseLevel(uint itemId)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}

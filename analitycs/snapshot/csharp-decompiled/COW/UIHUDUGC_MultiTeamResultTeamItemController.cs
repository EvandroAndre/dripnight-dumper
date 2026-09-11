using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHUDUGC_MultiTeamResultTeamItemController : UIEasyListItemController
{
	private UIHUDUGC_MultiTeamResultTeamItemView m_View;

	private UIHUDUGC_MultiTeamResultController m_parentController;

	private UIDetailTipsInUGCMatchResultController m_Tips;

	private int[] m_RankToScoreRule;

	private List<UIHUDUGC_MultiTeamMatchResultPlayerItemController> m_items;

	private static float playerItemHeight;

	private static float selfHeight;

	private bool _dirty;

	private bool _003CDirty_003Ek__BackingField;

	public ulong TeamRank;

	public bool Dirty
	{
		get
		{
			return _003CDirty_003Ek__BackingField;
		}
		set
		{
			_003CDirty_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	internal void SetParentController(UIHUDUGC_MultiTeamResultController parentController)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetTitle(int index, string value)
	{
	}

	public void SetTeamScore(string value)
	{
	}

	public void SetTeamRank(string value)
	{
	}

	public void SetPlayerScore(int index, List<string> playerList, List<object> scoreList)
	{
	}

	public void SetMVPInfo(List<string> mvpList, bool isWin)
	{
	}

	public void SetLikeVisible(bool flag)
	{
	}

	public void SetMatchStats(MatchStats stats)
	{
	}

	public void SetAddFriendVisible(bool flag)
	{
	}

	public void SetReportVisible(bool flag)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public bool RefreshPlayerData(UGCPlayerStats data, bool isSingle)
	{
		return false;
	}

	public static int CalculateContainerHeight(int numOfPlayerItem)
	{
		return 0;
	}

	private void OnQuestionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

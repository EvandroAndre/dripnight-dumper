using GCommon;
using proto;

namespace COW;

public class UIChampionshipTeamRecordItemController : UIEasyListItemController
{
	private UIChampionshipTeamRecordItemView m_View;

	private TeamChampionshipMatchData m_MatchData;

	private TeamChampionshipMatchStats m_MatchStats;

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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

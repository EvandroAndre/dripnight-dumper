using GCommon;
using proto;

namespace COW;

public class UIChampionshipLeaderBoardItem : UIEasyListItemController
{
	private UIChampionshipLeaderBoardItemView m_View;

	private UIModelChampionship m_ModelChampionship;

	private UITeamBaseProfileController m_ProfileCtrl;

	private TeamInfo m_TeamInfo;

	public uint m_ChampionshipType;

	public bool m_IsSelf;

	private LeaderBoardInfo m_Info;

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

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

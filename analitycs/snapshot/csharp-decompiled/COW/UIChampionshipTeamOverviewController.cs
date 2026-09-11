using GCommon;
using proto;

namespace COW;

public class UIChampionshipTeamOverviewController : UIBaseController
{
	private UIChampionshipTeamOverviewView m_View;

	private UIModelChampionship m_ModelChampionship;

	private EChampionship.TeamScaleType m_TeamScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(TeamInfo teamInfo, uint championshipType, bool showEditButton = false)
	{
	}

	public void SetNationFlag(UISprite flagSprite, TeamInfo teamInfo)
	{
	}

	protected void EditInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

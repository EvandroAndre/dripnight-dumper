using GCommon;
using proto;

namespace COW;

public class UITeamBaseProfileController : UIBaseController
{
	private UITeamBaseProfileView m_View;

	private TeamInfo m_TeamInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(TeamInfo teamInfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

using GCommon;
using message;

namespace COW;

public class UILobbyBaseStartGameController : UIBaseController
{
	public bool ShowBigTeamMode;

	public string FILTER_GROUP_KEY;

	public virtual bool CheckPlayerLimits(CMDBIPLGLGA groupMode, bool showTips = true)
	{
		return false;
	}

	public virtual bool CheckIntraTeamDuel()
	{
		return false;
	}
}

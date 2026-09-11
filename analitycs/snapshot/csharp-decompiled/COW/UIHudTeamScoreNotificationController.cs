using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudTeamScoreNotificationController : UIHudKillNotificationBaseController
{
	private static readonly Dictionary<int, uint> HYPELEVEL_COLOR;

	private static readonly uint DEFAULT_COLOR;

	private UIHudTeamScoreNotificationView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnKill(Player killer, Player beKiller, MatchModelKillData data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

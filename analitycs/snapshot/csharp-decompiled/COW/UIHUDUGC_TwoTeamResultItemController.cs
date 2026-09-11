using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHUDUGC_TwoTeamResultItemController : UIHudUGCTeamBattleMatchResultItemController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetAccountID(ulong accountID)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void SetPlayerData(Player p)
	{
	}

	public void RefreshExtraData(UGCPlayerStats stats)
	{
	}

	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	public void SetPlayerScore(int scoreIndex, string scoreValue)
	{
	}

	public override void ShowAddFriendButton(bool show)
	{
	}

	public override void ShowReportButton(bool show)
	{
	}

	public override void ShowLikeContainer(bool show)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowAddFriendButton(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowReportButton(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowLikeContainer(bool P0)
	{
	}
}

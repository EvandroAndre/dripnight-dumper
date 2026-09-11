using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVerticleViewTeamScoreBoardItemController : UIBaseController
{
	private UIHudVerticleViewTeamScoreBoardItemView m_View;

	private Player m_Player;

	private bool hasReported;

	private bool m_IsSelf;

	private GIFGAGAGFLA m_Game;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void ShowReportButton(bool show)
	{
	}

	public void InitData(Player player, bool isLocalSelf)
	{
	}

	public void RefreshHeadPic(int roleId)
	{
	}

	public int GetPlayerTeamIndex()
	{
		return 0;
	}

	public void ShowSelf(bool isShow)
	{
	}

	public void RefreshData(VerticleViewPlayer player)
	{
	}

	public void SetIsSelf(bool isSelf)
	{
	}

	private void SetDeadBG(bool isDead)
	{
	}

	public void UpdatePlayerData(Player player)
	{
	}

	private void UpdateTeamIndex(Player player)
	{
	}

	private void OnPlayerAliveStateChanged(uint data)
	{
	}

	private void OnClickReportBtn()
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

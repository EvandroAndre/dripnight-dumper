using GCommon;
using message;

namespace COW.HUD;

internal class UIHudCasualRoomMatchResultController : UIBaseController
{
	private const int SOLO_TOP_TEAM_HEIGHT = 60;

	private const int SOLO_TOP_TEAM_CELL_HEIGHT = 68;

	private const int SOLO_TOP_PLAYER_HEIGHT = 40;

	private const int SOLO_NORMAL_TEAM_HEIGHT = 60;

	private const int SOLO_NORMAL_TEAM_CELL_HEIGHT = 66;

	private const int SOLO_NORMAL_PLAYER_HEIGHT = 40;

	private const int SOLO_TOP_COUNT = 7;

	private const int SOLO_NORMAL_CNT_LABEL_POSX = 250;

	private const int SOLO_TOP_CNT_LABEL_POSX = 350;

	private const int DUO_TOP_TEAM_HEIGHT = 75;

	private const int DUO_TOP_TEAM_CELL_HEIGHT = 81;

	private const int DUO_TOP_PLAYER_HEIGHT = 40;

	private const int DUO_NORMAL_TEAM_HEIGHT = 70;

	private const int DUO_NORMAL_TEAM_CELL_HEIGHT = 76;

	private const int DUO_NORMAL_PLAYER_HEIGHT = 40;

	private const int DUO_TOP_COUNT = 6;

	private const int DUO_NORMAL_CNT_LABEL_POSX = 160;

	private const int DUO_TOP_CNT_LABEL_POSX = 160;

	private const int QUAD_TOP_TEAM_HEIGHT = 90;

	private const int QUAD_TOP_TEAM_CELL_HEIGHT = 98;

	private const int QUAD_TOP_PLAYER_HEIGHT = 40;

	private const int QUAD_NORMAL_TEAM_HEIGHT = 78;

	private const int QUAD_NORMAL_TEAM_CELL_HEIGHT = 84;

	private const int QUAD_NORMAL_PLAYER_HEIGHT = 40;

	private const int QUAD_TOP_COUNT = 5;

	private const int QUAD_NORMAL_CNT_LABEL_POSX = 160;

	private const int QUAD_TOP_CNT_LABEL_POSX = 160;

	private UIHudCasualRoomMatchResultView m_View;

	private CMDBIPLGLGA m_CurrentGroupMode;

	private int m_TopTeamHeight;

	private int m_TopTeamCellHeight;

	private int m_NormalTeamHeight;

	private int m_NormalTeamCellHeight;

	private int m_TopCount;

	private int m_TopCntLabelPosX;

	private int m_NormalCntLabelPosX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBackToLobbyButtonClick()
	{
	}

	private void OnPrevBtnClick()
	{
	}

	private void RefreshUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

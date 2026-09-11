using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewTeamMemberItemController : UIBaseController
{
	private UIBRMatchReviewTeamMemberItemView m_View;

	private NGKNJIMOHBM m_PlayerInfo;

	private int m_PositionIndex;

	private bool m_IsVisible;

	private bool m_IsLocalPlayer;

	private Color m_DefaultPlayerNameColor;

	private const uint SELF_PLAYER_NAME_COLOR = 4290380031u;

	public uint PlayerId => 0u;

	public new bool IsVisible => false;

	private UIBRMatchReviewTeammatePanelController PanelCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(NGKNJIMOHBM playerInfo, int positionIndex, uint localPlayerID)
	{
	}

	private void OnMemberClicked()
	{
	}

	private bool IsLastVisibleMember()
	{
		return false;
	}

	private void RefreshView()
	{
	}

	private void LogTeamMemberClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIBRMatchReviewTeammatePanelController : UIBaseController
{
	private UIBRMatchReviewTeammatePanelView m_View;

	private List<UIBRMatchReviewTeamMemberItemController> m_MemberControllers;

	private HashSet<uint> m_VisiblePlayerIds;

	private UIBRMatchReviewController ReviewCtrl => null;

	public HashSet<uint> GetVisiblePlayerIds()
	{
		return null;
	}

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

	public void SetData(List<NGKNJIMOHBM> players, uint localPlayerID)
	{
	}

	public void OnMemberVisibilityChanged(uint playerId, bool isVisible)
	{
	}

	public void ClearData()
	{
	}

	private void CleanupMembers()
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
}

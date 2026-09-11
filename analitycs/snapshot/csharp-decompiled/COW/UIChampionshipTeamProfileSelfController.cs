using System;
using GCommon;

namespace COW;

public class UIChampionshipTeamProfileSelfController : UIChampionshipTeamProfileController, IUIModelDataChangeObserver
{
	private const string TabApply = "TabApply";

	private const string TabInvite = "TabInvite";

	private UIChampionshipTeamProfileView m_View;

	private UIModelChampionship m_ModelChampionship;

	private StandardTabItemViewData m_SelectedTab;

	private UIChampionshipMemberReviewPopupController m_MemberReviewPopupCtrl;

	public Action SignUpPopupWndCancelAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(uint championshipType)
	{
	}

	public void UpdateTeamInfoView()
	{
	}

	public void UpdateTeamMemberView()
	{
	}

	private void OnExitTeam()
	{
	}

	private void OnCreateTeamClick()
	{
	}

	private void OnBtnChatRecruitClick()
	{
	}

	private void OnJoinTeamOnlick()
	{
	}

	private void OnRecruit()
	{
	}

	private void OnRecourdDetail()
	{
	}

	private void OnTeamInfoRefresh()
	{
	}

	private void RequestData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void ShowMembers()
	{
	}

	public void ShowRecord()
	{
	}

	private void ShowInvite()
	{
	}

	private void ShowApplyAndInvite()
	{
	}

	public void ShowCreateTeamWnd()
	{
	}

	private void ShowCreateTeamGuide()
	{
	}

	private void _003COnExitTeam_003Eb__13_0()
	{
	}

	private void _003COnTeamInfoRefresh_003Eb__19_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

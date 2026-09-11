using System;
using GCommon;

namespace COW;

public class UICupMatchTeamProfileSelfController : UICupMatchTeamProfileController, IUIModelDataChangeObserver
{
	private UIModelCupMatch m_ModelCupMatch;

	private UICupMatchMemberReviewPopupController m_MemberReviewPopupCtrl;

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

	public void SetViewData(int cupMatchKey)
	{
	}

	public void UpdateTeamInfoView()
	{
	}

	public void UpdateTeamMemberView()
	{
	}

	private void UpdateTicketInfo()
	{
	}

	private void ShowCreateTeamGuide()
	{
	}

	private void UpdateInvitationRedTips()
	{
	}

	private void UpdateApplicationRedTips()
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

	private void OnJoinTeamClick()
	{
	}

	private void OnRecruit()
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

	private void ShowInvite()
	{
	}

	private void ShowApplyAndInvite()
	{
	}

	private void _003COnExitTeam_003Eb__13_0()
	{
	}

	private void _003COnTeamInfoRefresh_003Eb__18_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

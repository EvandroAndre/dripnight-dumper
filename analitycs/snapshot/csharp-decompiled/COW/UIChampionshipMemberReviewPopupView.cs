using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipMemberReviewPopupView : UIBaseView
{
	public GameObject Tabs;

	public UITable Btns;

	public UIToggleButton BtnApply;

	public UITipsButton ApplyTipsBtn;

	public UIToggleButton BtnInvite;

	public UILabel LabelUnSelect;

	public UITipsButton InviteTipsBtn;

	public GameObject Apply;

	public UIEasyList ApplyEasyList;

	public UIButton RejectAll;

	public GameObject ApplyNoData;

	public GameObject Invite;

	public UIEasyList InviteEasyList;

	public UIButton RejectAllInvite;

	public GameObject InviteNoData;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

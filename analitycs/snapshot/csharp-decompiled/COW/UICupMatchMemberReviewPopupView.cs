using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchMemberReviewPopupView : UIBaseView
{
	public GameObject Tabs;

	public UITable Btns;

	public UIToggleButton BtnApply;

	public GameObject ApplyRedPoint;

	public UIToggleButton BtnInvite;

	public UILabel LabelUnSelect;

	public GameObject InviteRedPoint;

	public GameObject Apply;

	public UIEasyList ApplyEasyList;

	public UIButton RejectAll;

	public GameObject ApplyNoData;

	public GameObject Invite;

	public UIEasyList InviteEasyList;

	public UIButton RejectAllInvite;

	public GameObject InviteNoData;

	public UIButton Refresh;

	public GameObject RefreshIcon;

	public UICountDownLabel CountDownLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

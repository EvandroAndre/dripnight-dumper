using GCommon;
using UnityEngine;

namespace COW;

public class UIRematchGroupMemberInfoView : UIBaseView
{
	public Transform FakeMemberTrans;

	public UILabel MemberName;

	public UISprite AcceptIcon;

	public UISprite PendingIcon;

	public UILabel RematchLabel;

	public UILabel CountDownLabel;

	public UIButton AddFriendBtn;

	public UISprite CountDownIcon;

	public GameObject TopCountDownContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIGroupInviteItemView : UIBaseView
{
	public UIButton bgBtn;

	public UISprite platformIcon;

	public UIButton inviteBtn;

	public GameObject inviteBtnGray;

	public GameObject inviteSprite;

	public GameObject JoinObj;

	public GameObject JoinObjGrey;

	public Transform invited;

	public Transform profileinfo;

	public UIButton ReserveBtn;

	public GameObject CanReserve;

	public GameObject Reserved;

	public GameObject Reserving;

	public GameObject CannotReserve;

	public GameObject FloatingWindowBG;

	public GameObject inviteAndJoinGrey;

	public GameObject inviteAndJoinObj;

	public GameObject InviteAndJoinWnd;

	public UIButton SecondInviteBtn;

	public UIButton SecondJoinBtn;

	public UIButton CloseMaskBtn;

	public GameObject inviteBtnGrayOff;

	public GameObject inviteSpriteOff;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

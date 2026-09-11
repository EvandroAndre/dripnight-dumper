using GCommon;
using UnityEngine;

namespace COW;

public class UILoginView : UIBaseView
{
	public GameObject LoginPanel;

	public GameObject LoginBtns;

	public UIButton BtnLoginGuest;

	public GameObject MoreLogin;

	public UIButton MoreLoginBtn;

	public Transform TopLeft;

	public GameObject BottomRight;

	public GameObject BottomLeft;

	public UILoginButton BtnLoginTemplate;

	public GameObject Normal;

	public UILabel LoginGuestLabel;

	public Transform LoginGuestIcon;

	public UILabel MoreLoginLabel;

	public Transform MoreLoginIcon;

	public GameObject UILogin;

	public GameObject TopRight;

	public Transform Age18Pos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

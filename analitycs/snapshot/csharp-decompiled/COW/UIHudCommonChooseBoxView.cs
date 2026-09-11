using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCommonChooseBoxView : UIBaseView
{
	public UISprite TimeCircle;

	public UILabel TimeLabel;

	public UILabel TitleLabel;

	public UITable ContentTable;

	public UILabel DescLabel;

	public UIButton AcceptBtn;

	public UIButton RejectBtn;

	public UIToggle IgnoreToggle;

	public UILabel IgnoreLabel;

	public GameObject Timer;

	public UISprite BG;

	public UIAnchor Bottom;

	public GameObject Mask;

	public GameObject ChooseContainer;

	public Transform ProfileContainer;

	public GameObject ProfileInfoLow;

	public UILabel Nickname;

	public UILabel Clanname;

	public Transform ProfileTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

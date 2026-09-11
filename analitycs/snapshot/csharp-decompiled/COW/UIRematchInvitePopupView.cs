using GCommon;
using UnityEngine;

namespace COW;

public class UIRematchInvitePopupView : UIBaseView
{
	public GameObject WindowBG;

	public GameObject Timer;

	public UISprite TimeCircle;

	public UILabel TimeLabel;

	public UIButton BtnClose;

	public UILabel ReasonLabel;

	public UITable TeammateTable;

	public GameObject PassiveAcceptContainer;

	public UILabel PassiveAcceptLabel;

	public UILabel TipsTypeLabel;

	public UIButton AcceptBtn;

	public UIButton IgnoreToggle;

	public GameObject unselected;

	public UILabel IgnoreLabel;

	public GameObject Highlight;

	public Animation PopupAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

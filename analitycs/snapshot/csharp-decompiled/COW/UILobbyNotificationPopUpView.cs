using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyNotificationPopUpView : UIBaseView
{
	public UISprite TitleIcon;

	public UILabel TitleLabel;

	public Transform Content;

	public UISprite TitleBG;

	public UISprite BGDecorate;

	public UISprite BGLine;

	public UISprite TitleBGLine;

	public UIButton BtnClose;

	public UISprite CloseBtnBg;

	public TweenPosition TweenPos;

	public UIPanel BasePanel;

	public GameObject TeamUpRecommend;

	public GameObject LobbyTopRightNotification;

	public Transform TeamUpRecommendContent;

	public Transform GiftboxContent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

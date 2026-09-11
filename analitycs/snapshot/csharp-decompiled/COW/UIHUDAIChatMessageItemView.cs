using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatMessageItemView : UIBaseView
{
	public GameObject RightView;

	public GameObject LeftView;

	public GameObject RightContentContainer;

	public GameObject RightContentLoadingIcon;

	public UILabel RightContent;

	public BoxCollider RightBannerBoxCollider;

	public UIButton RightBannerButton;

	public UISprite RightBanner;

	public GameObject LeftContentContainer;

	public GameObject LeftContentLoadingIcon;

	public UILabel LeftContent;

	public BoxCollider LeftBannerBoxCollider;

	public UIButton LeftBannerButton;

	public UISprite LeftBanner;

	public UIWidget LeftVote;

	public GameObject LikeContainer;

	public UISprite LikedIcon;

	public UIButton NoLikeIcon;

	public GameObject DislikeContainer;

	public UISprite DislikedIcon;

	public UIButton NoDislikeIcon;

	public UITable LeftContentTable;

	public UITable LeftVerticaTable;

	public UITable RightContentTable;

	public UITable LeftUGCParamsSetTable;

	public UIButton Excute;

	public GameObject Excuted;

	public UIColor LeftColorBG;

	public GameObject TipsTrans;

	public GameObject SetParamsWidget;

	public GameObject LeftFastChatContainer;

	public GameObject FastChat1;

	public UILabel FastChatLabel1;

	public UIButton FastChatBtn1;

	public GameObject FastChat2;

	public UILabel FastChatLabel2;

	public UIButton FastChatBtn2;

	public GameObject PaddingWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

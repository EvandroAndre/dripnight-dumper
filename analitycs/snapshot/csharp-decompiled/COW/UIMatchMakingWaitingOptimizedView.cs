using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchMakingWaitingOptimizedView : UIBaseView
{
	public GameObject DefaultViewContent;

	public GameObject MatchMakingContainer;

	public UIAnchor MatchMakingAnchor;

	public UIWidget ContainerWidget;

	public UIGroupWaitingDropItem DragDropItem;

	public UILabel OtherTime;

	public UISprite MatchWatingBG;

	public UIButton OtherCancelBtn;

	public UISprite OtherCancelBtnIcon;

	public UISprite OtherCancelBtnBG;

	public GameObject OtherEstimateContent;

	public UILabel EstimateLabel;

	public UILabel OtherEstimateTime;

	public GameObject VFX_Loop;

	public GameObject EstimateTime;

	public GameObject MatchMaking;

	public UIFixTimeCarousel MatckMakingCarousel;

	public UIPanel MatchMakingPanel;

	public UIPanel UIMatchMakingWaitingOptimized;

	public GameObject Icon_Drag;

	public UILabel FriendSpectateLabel;

	public GameObject RematchInfoContainer;

	public UILabel RematchInfoLabel;

	public UITable TeammatesList;

	public GameObject PlayerIconContainer;

	public GameObject IngameGroupModeContainer;

	public UILabel MatchMakingTime;

	public UILabel MatchMakingLabel;

	public GameObject PostMatchTeamUpMatchContainer;

	public UILabel SocialLobbyLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

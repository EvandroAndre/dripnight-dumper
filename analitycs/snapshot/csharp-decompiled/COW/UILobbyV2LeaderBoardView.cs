using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2LeaderBoardView : UIBaseView
{
	public UIToggleButton BtnBrTab;

	public UIToggleButton BtnCsTab;

	public UIEasyList EasyList;

	public Transform SelfRankPos;

	public UIButton InviteEnter;

	public Transform BriefBoxPos;

	public UIScrollView ScrollView;

	public UIWidget ScrollViewWidget;

	public UISprite AnchorContainer;

	public GameObject NoDataTips;

	public UILabel NoDataTipsLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

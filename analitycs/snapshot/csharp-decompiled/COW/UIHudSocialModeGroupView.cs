using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSocialModeGroupView : UIBaseView
{
	public GameObject UIHudSocialModeGroup;

	public UIGrid Grid;

	public GameObject TeamInfoContainer;

	public UISprite TeamBuffIcon;

	public GameObject NoTeamContainer;

	public UIScrollView ScrollView;

	public UIWidget ScrollViewWidget;

	public GameObject SwitchLobbyContainer;

	public UIButton TeamInfoBtn;

	public UIButton NoTeamBtn;

	public UIButton FoldBtn;

	public GameObject IsFold;

	public GameObject UnFold;

	public UILabel TeamInfoLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

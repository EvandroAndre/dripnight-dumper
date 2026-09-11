using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomDuoPlayerWithTeamItemView : UIBaseView
{
	public UIWidget UIRoomDuoPlayerWithTeamItem;

	public GameObject Selected;

	public UILabel TeamName;

	public UIEffectSprite TeamIcon;

	public UISprite TeamFakeIcon;

	public UILabel Id;

	public GameObject PlayerGo1;

	public GameObject PlayerGo2;

	public UILabel TeamScore;

	public UIButton InteractionBtn1;

	public UIButton InteractionBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

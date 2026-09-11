using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomPentaPlayerWithTeamItemView : UIBaseView
{
	public UIWidget UIRoomPentaPlayerWithTeamItem;

	public GameObject Selected;

	public UIEffectSprite TeamIcon;

	public UISprite TeamFakeIcon;

	public UILabel TeamName;

	public UILabel Id;

	public GameObject PlayerGo1;

	public GameObject PlayerGo2;

	public GameObject PlayerGo3;

	public GameObject PlayerGo4;

	public GameObject PlayerGo5;

	public UIButton InteractionBtn;

	public UIButton InteractionBtn1;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

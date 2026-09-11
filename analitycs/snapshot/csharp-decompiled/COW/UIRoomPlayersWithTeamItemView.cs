using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomPlayersWithTeamItemView : UIBaseView
{
	public UIWidget UIRoomPlayersWithTeamItem;

	public GameObject Selected;

	public UILabel TeamName;

	public UIEffectSprite TeamIcon;

	public UISprite TeamFakeIcon;

	public UISprite LeftLine;

	public UISprite LeftBG;

	public UILabel Id;

	public UIGrid PlayerContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

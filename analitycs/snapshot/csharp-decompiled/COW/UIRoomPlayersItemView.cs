using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomPlayersItemView : UIBaseView
{
	public UIWidget UIRoomPlayersItem;

	public GameObject Selected;

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

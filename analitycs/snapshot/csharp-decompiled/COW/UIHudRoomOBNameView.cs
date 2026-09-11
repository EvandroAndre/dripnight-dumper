using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRoomOBNameView : UIBaseView
{
	public GameObject Container;

	public UIWidget ContainerWidget;

	public GameObject RoomOBFreeName;

	public UILabel RoomOBTeamId;

	public UISprite RoomOBTeamBg;

	public UILabel RoomOBNameLbl;

	public UISprite RoomOBHpbarfg;

	public UISprite RoomOBHpbarbg;

	public UISprite RoomOBBg;

	public GameObject RoomOBSelfSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

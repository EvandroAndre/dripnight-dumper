using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditMessageReservationItemView : UIBaseView
{
	public GameObject UIHudReservationContent;

	public UILabel Name;

	public UISprite Rank;

	public GameObject Selection;

	public UIButton RejectBtn;

	public UIButton AgreeBtn;

	public GameObject Result;

	public GameObject Agree;

	public GameObject Reject;

	public GameObject Expired;

	public UILabel ReservationContent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

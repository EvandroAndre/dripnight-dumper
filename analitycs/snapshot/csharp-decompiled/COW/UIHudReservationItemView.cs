using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReservationItemView : UIBaseView
{
	public GameObject UIHudReservationItem;

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

	public UILabel ReserveTitleLabel;

	public UILabel TimeLabel;

	public UITable StateTable;

	public GameObject GroupCon;

	public GameObject PlayerTag;

	public UILabel GroupNum;

	public UISprite PlayerTagBG;

	public UILabel PlayerTagLabel;

	public UISprite TimeCircle;

	public UISprite BG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamMemberItemView : UIBaseView
{
	public UIButton Item;

	public Transform BaseProfile;

	public UILabel State;

	public GameObject Captain;

	public UISprite bg;

	public UIButton Tier;

	public UILabel TireLabel;

	public UIButton TicketBtn;

	public UISprite TicketIcon;

	public GameObject NoTicket;

	public GameObject Change;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

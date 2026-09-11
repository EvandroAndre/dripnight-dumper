using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyLoadoutView : UIBaseView
{
	public UIButton LoadoutBtn;

	public UISprite PlanNumIcon;

	public UIWidget WidgetGuide;

	public GameObject VFX_Icon;

	public Transform RedTipsContainer;

	public Transform LoadoutV2Guide;

	public Transform LoudoutBubbleTrans;

	public GameObject ActivityContainer;

	public UISprite ActivityPlanNumBgIcon;

	public UISprite ActivityPlanNumBg;

	public GameObject NormalContainer;

	public GameObject LoadoutLock;

	public Transform LobbySocialAreaBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

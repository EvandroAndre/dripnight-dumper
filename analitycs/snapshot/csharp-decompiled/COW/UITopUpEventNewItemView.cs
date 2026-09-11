using GCommon;
using UnityEngine;

namespace COW;

public class UITopUpEventNewItemView : UIBaseView
{
	public UIGrid ItemGrid;

	public GameObject State_CanNotCliam;

	public Animation ButtonTopUpAnimation;

	public UIButton GoToTopUpBtn;

	public GameObject State_CanCliam;

	public Animation ButtonClaimAnimation;

	public UIButton GoToCliamBtn;

	public GameObject State_Cliamed;

	public GameObject DiamondCountContainer;

	public UILabel DiamondCountLabel;

	public UIDragScrollView DrawScrollView;

	public UISprite Daily;

	public GameObject main;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

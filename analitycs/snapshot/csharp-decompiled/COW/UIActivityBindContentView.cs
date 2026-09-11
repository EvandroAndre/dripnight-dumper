using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityBindContentView : UIBaseView
{
	public GameObject State_CanNotCliam;

	public Animation ButtonTopUpAnimation;

	public UIButton GoToTopUpBtn;

	public GameObject State_CanCliam;

	public Animation ButtonClaimAnimation;

	public UIButton GoToCliamBtn;

	public GameObject State_Cliamed;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityScoreTaskItemView : UIBaseView
{
	public GameObject State_CanCliam;

	public Animation ButtonClaimAnimation;

	public UIButton GoToCliamBtn;

	public GameObject State_Cliamed;

	public GameObject State_CanNotCliam;

	public UIButton GoToTopUpBtn;

	public UISprite NotCliamSprite;

	public UILabel Title;

	public GameObject State_CanNotCliam1;

	public UIButton GoToTopUpBtn1;

	public UISprite NotCliamSprite1;

	public UILabel Title1;

	public UITable ButtonTable;

	public UIDragScrollView DragView;

	public GameObject ItemRoot;

	public GameObject main;

	public UILabel NotClaimLabel;

	public UILabel NotClaimLabel1;

	public GameObject State_Complete;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

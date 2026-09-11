using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisDrawPartialWndView : UIBaseView
{
	public UIButton ConfirmBtn;

	public UILabel DrawPartialLabel1;

	public GameObject DiamondIcon;

	public GameObject DiamondNumberGameObject;

	public UILabel DiamondNumberLabel;

	public GameObject PlusLabel;

	public GameObject TokenIconGameObject;

	public UISprite TokenIcon;

	public GameObject TokenNumberGameObject;

	public UILabel TokenNumberLabel;

	public UICenterTargetHelper DiamondAndTokenStateCenterHelper;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

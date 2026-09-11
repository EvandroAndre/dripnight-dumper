using GCommon;
using UnityEngine;

namespace COW;

public class UIChangeNameView : UIBaseView
{
	public UIGrid BottomBtnContainer;

	public UIButton DiamondBtn;

	public GameObject DiamondBtnEnable;

	public GameObject DiamondBtnDisable;

	public UILabel DiamondEnablePrice;

	public UILabel DiamondDisablePrice;

	public UIButton CardBtn;

	public GameObject CardBtnEnable;

	public GameObject CardBtnDisable;

	public UIInput InputNewName;

	public UIButton ConfirmBtn;

	public UIWidget ClearBtn;

	public UIButton ReSetBtn;

	public UITable TopContainer;

	public UILabel InValidLabel;

	public GameObject ConfirmBtnEnable;

	public GameObject ConfirmBtnDisable;

	public GameObject InValidContainer;

	public GameObject CheckingContainer;

	public GameObject MiddleContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

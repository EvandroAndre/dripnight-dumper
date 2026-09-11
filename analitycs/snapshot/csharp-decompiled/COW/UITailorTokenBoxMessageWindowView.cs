using GCommon;
using UnityEngine;

namespace COW;

public class UITailorTokenBoxMessageWindowView : UIBaseView
{
	public UISprite TokenBoxSprite;

	public UILabel TokenBoxName;

	public Transform TokenBoxScrollViewTransform;

	public UIScrollView TokenBoxScrollView;

	public UIButton CloseBtn;

	public UISprite CloseBtnIcon;

	public GameObject ModifyNumContainer;

	public UIButton PlusBtn;

	public UIInput CountInput;

	public UILabel CountLabel;

	public UIButton MinusBtn;

	public UIButton MaxBtn;

	public UIButton AddTenBtn;

	public UILabel LabelMax;

	public UIVoucher Voucher;

	public GameObject Bound;

	public UILabel Label;

	public Transform TokenBoxBuyBtnGroup;

	public Transform TokenBoxProbablilityTransform;

	public UIButton TokenBoxProbabilityBtn;

	public UIEasyList TokenBoxGrid;

	public UISprite TokenIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

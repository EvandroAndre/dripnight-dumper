using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopTokenExchangeView : UIBaseView
{
	public GameObject Container;

	public UIScrollView ItemScrollView;

	public UIEasyList Grid;

	public UIButton ExchangeBtn;

	public UISprite ExchangeBtnBG;

	public UILabel LabelLimitedCount;

	public GameObject ExChangeNormalState;

	public GameObject ExChangeDiamondState;

	public UISprite NormalIcon;

	public UILabel NoramlBtnLabel;

	public UISprite TokenIcon;

	public UILabel TokenNumberLabel;

	public UISprite DiamondIcon;

	public UILabel DiamondNumberLabel;

	public UICenterTargetHelper ExchangeDiamondBtnCenterHelper;

	public GameObject NotEnoughMaterial;

	public GameObject NotEnoughMaterialWithDiamond;

	public UISprite NotEnoughMaterial1;

	public UISprite NotEnoughMaterial2;

	public UILabel NotEnoughMaterialWithDiamondLabel;

	public UIWidget PreviewBorder;

	public UICenterTargetHelper NoramlCenterHelper;

	public UISprite RuleTokenIcon;

	public UILabel RuleDiamondNumberLabel;

	public UISprite CoinTypeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNewSceneEditItemPanelView : UIBaseView
{
	public UIEasyList ExtendGrid;

	public UIEasyList ShrinkGrid;

	public UIButton FolderBtn;

	public GameObject SpriteFolder;

	public UISprite SpriteBG;

	public UIButton PopUpButton;

	public TweenScale TweenScale;

	public UILabel LabelPopUp;

	public UILabel LabelRecede;

	public GameObject SliderBar;

	public UITable SliderTable;

	public UIToggleButtonGroup TabButtonGroup;

	public UIScrollView SliderScrollView;

	public UILabel ItemCostLabel;

	public GameObject TweenPos;

	public UIInput SearchInput;

	public UIButton BtnSearch;

	public GameObject DeleteIcon;

	public GameObject SearchDefaultLabel;

	public GameObject FoldSearch;

	public UIInput FoldSearchInput;

	public GameObject FoldSearchDefaultLabel;

	public GameObject iconUnfold;

	public GameObject iconFold;

	public UIWidget DragGuide;

	public UIWidget DragGuide2;

	public Animation Ani;

	public GameObject PopUpMenu;

	public UIButton OpenShopBtn;

	public UIWidget OpenShopBtnWidget;

	public UIButton AIGenBtn;

	public UIWidget AIGenBtnWidget;

	public GameObject ContainerShrink;

	public GameObject ContainerExtend;

	public UIPanel ScrollShrink;

	public UIScrollView ShrinkScrollView;

	public UIScrollView ExtendScrollView;

	public UIButton BtnCreatorLvTip;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

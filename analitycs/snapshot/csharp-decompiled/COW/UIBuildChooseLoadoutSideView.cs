using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseLoadoutSideView : UIBaseView
{
	public UILabel PlanLabel;

	public UIGrid Grid;

	public UILabel LoadoutNameLabel;

	public UISprite TagSprite1;

	public UISprite TagSprite2;

	public UISprite TagSprite3;

	public UILabel TagLabel1;

	public UILabel TagLabel2;

	public UILabel TagLabel3;

	public UITable Tag;

	public UITable DescriptionTable;

	public UILabel BRLabel;

	public UILabel BRDescriptionLabel;

	public UILabel CSLabel;

	public UILabel CSDescriptionLabel;

	public UILabel EmptyLabel;

	public GameObject LoadoutDesc;

	public UIButton BtnClose;

	public UIButton BuyBtn;

	public Animation main;

	public UISprite AdjustIcon;

	public UIButton AdjustBtn;

	public Transform V1;

	public Transform V2;

	public UIButton BtnV2;

	public UIButton BtnV1;

	public GameObject Tab;

	public GameObject V2Select;

	public GameObject V2Unselect;

	public GameObject V1Unselect;

	public GameObject V1Select;

	public Transform LoadoutPanelNew;

	public UISprite ContainerBG;

	public GameObject TipsContainer;

	public UIScrollView DescScrollView;

	public GameObject Arrow;

	public GameObject BRSelect;

	public GameObject BRUnselect;

	public GameObject CSSelect;

	public GameObject CSUnselect;

	public UIButton BtnBR;

	public UIButton BtnCS;

	public UILabel DescriptionLabel;

	public UINetworkTexture CDNTextureTutorials;

	public UILabel BRTabLabel;

	public UILabel BRTabUnselectLabel;

	public UILabel CSTabLabel;

	public UILabel CSTabUnselectLabel;

	public GameObject BRCSTab;

	public UISprite bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudResourceShopView : UIBaseView
{
	public UIButton CloseBtn;

	public UIButton HelpBtn;

	public UIPanel BgTexture;

	public UIScrollView SchollHTab;

	public UIEasyList EasyListHTab;

	public GameObject ContainerEmpty;

	public UIButton BtnStore;

	public UIEasyList EasyListShopItem;

	public GameObject Search;

	public UIInput SearchInput;

	public GameObject SortPopMenu;

	public UILabel LabelEmpty;

	public UIButton ClearBtn;

	public UILabel LabelNum;

	public GameObject TabContainer;

	public UIButton BtnUpload;

	public GameObject ContainerShop;

	public GameObject ContainerRecommend;

	public UIScrollView ScrollShopItem;

	public GameObject ContainerShopItem;

	public UITable2 Table2Recommend;

	public UINetworkTexture TextureBG;

	public UIScrollView ScrollRecommendItem;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

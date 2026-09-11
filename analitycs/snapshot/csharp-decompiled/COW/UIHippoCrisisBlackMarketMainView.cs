using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisBlackMarketMainView : UIBaseView
{
	public GameObject AnimationMain;

	public Transform TopCurrencyTrans;

	public UINetworkTexture mainBGCDN;

	public UIButton CloseBtn;

	public UIPanel MarketContentScrollView;

	public UIEasyList ItemEasyList;

	public Transform PopMenuPos;

	public UIButton VaultBtn;

	public UIPanel MarketContentPanel;

	public UIEasyList MainTabEasyList;

	public GameObject SubTabScrollView;

	public UIEasyList SubTabEasyList;

	public UIButton BuyBtn;

	public UIButton AscendingBtn;

	public UIButton DescendingBtn;

	public Transform ItemBriefBoxTrans;

	public Transform MarketContentContainer;

	public GameObject SubTab_Container;

	public UINetworkTexture RoleCDN;

	public GameObject EmptyContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

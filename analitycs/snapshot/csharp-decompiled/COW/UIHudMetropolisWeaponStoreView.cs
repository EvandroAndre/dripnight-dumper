using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisWeaponStoreView : UIBaseView
{
	public UIEasyList ItemList;

	public UIButton ActionBtn;

	public UILabel ActionTxt;

	public GameObject ActionDisableBG;

	public GameObject ActionEnableBG;

	public UIButton BtnCloseMask;

	public UIButton LevelupBtn;

	public UILabel CoinTxt;

	public UIGrid TabGrid;

	public UIHudMetropolisStoreTabItem ShopTabItem;

	public GameObject LevelupEnableBG;

	public GameObject LevelupDisableBG;

	public UIButton BtnCloseMaskLeft;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

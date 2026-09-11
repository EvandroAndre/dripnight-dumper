using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileHistoryHighestTitleView : UIBaseView
{
	public UIButton ChooseCSBtn;

	public UIButton ChooseBRBtn;

	public UIButton ShareBtn;

	public GameObject HighestRankTitle;

	public UIEasyList EasyList;

	public UIScrollView ScrollView;

	public UISprite BRSelectedBG;

	public UISprite CSSelectedBG;

	public GameObject EmptyContainer;

	public UILabel EmptyLabel;

	public UIButton GoPosBtn;

	public GameObject RankTtileContainer;

	public GameObject WeaponTtileContainer;

	public GameObject ChooseBtnContainer;

	public Transform NoRankTitlePos;

	public GameObject BRSelected;

	public GameObject BRUnSelected;

	public GameObject CSSelected;

	public GameObject CSUnSelected;

	public UIEasyList EasyListNoRank;

	public UIScrollView ScrollViewNoRank;

	public GameObject WeaponNormal;

	public GameObject WeaponNoRank;

	public GameObject PeakTtileContainer;

	public GameObject HighestRankPeakTitle;

	public GameObject WeaponwithPeakAndRank;

	public UIScrollView ScrollViewWithPeakAndRank;

	public UIEasyList EasyListWithPeakAndRank;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

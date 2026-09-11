using GCommon;
using UnityEngine;

namespace COW;

public class UIHGSnowDifficultySelectionView : UIBaseView
{
	public UIButton BtnTalent;

	public UIWidget BtnTalentWidget;

	public UIButton BtnRank;

	public UISprite Headpic;

	public UILabel Name;

	public UILabel DetlaRank;

	public UISprite Trend;

	public UIButton BtnShop;

	public UIWidget BtnShopWidget;

	public UIButton BtnToken;

	public UILabel LabelTokenCount;

	public Transform Difficulty1;

	public Transform Difficulty2;

	public Transform Difficulty3;

	public Transform Difficulty4;

	public Transform Difficulty5;

	public GameObject Line1Normal;

	public GameObject Line1Lock;

	public GameObject Line2Normal;

	public GameObject Line2Lock;

	public Animation RankBubbleAnim;

	public GameObject Rank;

	public GameObject TalentRedTips;

	public UIWidget RankGuide;

	public UIEasyList Tabs;

	public Transform RankResult;

	public Animation MainAnim;

	public GameObject Download;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

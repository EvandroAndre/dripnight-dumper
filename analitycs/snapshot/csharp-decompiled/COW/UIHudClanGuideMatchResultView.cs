using GCommon;
using UnityEngine;

namespace COW;

public class UIHudClanGuideMatchResultView : UIBaseView
{
	public UILabel RankNum;

	public UILabel TotalNum;

	public UILabel ResultDesc;

	public UILabel GameModeTxt;

	public UILabel GameMapTxt;

	public UIButton FastSendGiftBtn;

	public UILabel BigrankingLabel;

	public UILabel ClanPointLabel;

	public UILabel RankChanegeNumLabel;

	public UILabel TeamPointChangeLabel;

	public UIButton NextBtn;

	public UIButton ShareBtn;

	public GameObject NewRecordLabel;

	public UILabel PersonalPointsChangeLabel;

	public UIButton QueationBtn;

	public UIEasyList List;

	public UILabel PointsDetailLabel;

	public GameObject EmptyNode;

	public GameObject RankNode;

	public GameObject RankChanegeLabel;

	public UILabel RegiongLabel;

	public GameObject DefeatGuideLabel;

	public UISprite BgRank;

	public GameObject Bg01;

	public GameObject Bg02;

	public GameObject DefeatClanContainer;

	public UILabel TopRankingLabel;

	public UILabel NoRankingLabel;

	public GameObject ShareInfoContainer;

	public UILabel ShareGameModeTxt;

	public GameObject CSRankInfo;

	public GameObject BRRankInfo;

	public UILabel LeftTeamScore;

	public UISprite LeftClanFrame;

	public UISprite LeftClanIcon;

	public UINetworkTexture LeftClanCDNIcon;

	public UILabel LeftTeamName;

	public UILabel RightTeamScore;

	public UISprite RightClanFrame;

	public UINetworkTexture RightClanCDNIcon;

	public UISprite RightClanIcon;

	public UILabel RightTeamName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UILadderRankIconView : UIBaseView
{
	public GameObject BRRankCon;

	public GameObject CSRankCon;

	public UISprite rankBR;

	public GameObject BRStarContainer;

	public UILadderMatchHeroicLevelView HeroicLevelView;

	public UISprite CSRank;

	public UISprite MaxCSStar;

	public UILabel MaxCSRankTxt;

	public UISprite star1;

	public UISprite star2;

	public UISprite star3;

	public UISprite star4;

	public UISprite star5;

	public UISprite blackstar1;

	public UISprite blackstar2;

	public UISprite blackstar3;

	public UISprite blackstar4;

	public UISprite blackstar5;

	public UIGrid CSGrid;

	public UILabel LabelRankPoints;

	public Transform UIFX_BRRankIcon;

	public Transform UIFX_CSRankIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

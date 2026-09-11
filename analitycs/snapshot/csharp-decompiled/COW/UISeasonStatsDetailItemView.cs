using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonStatsDetailItemView : UIBaseView
{
	public GameObject BRRankLevel;

	public UILabel CurRankName;

	public GameObject RankEffect;

	public UILabel SeasonInfoLabel;

	public UILabel SeasonLabel;

	public GameObject CSRankLevel;

	public UILabel CSRankName;

	public UILabel CSSeasonInfoLabel;

	public UILabel CSSeasonLabel;

	public UILabel BRRankLabel;

	public UILabel CSRankLabel;

	public UIButton BRExtendButton;

	public GameObject BRCurrentSeasonLabel;

	public UIButton CSExtendButton;

	public GameObject CSCurrentSeasonLabel;

	public UISprite BRBtnArrow;

	public UISprite CSBtnArrow;

	public TweenPosition TweenPosition;

	public Transform BRRankIconContainer;

	public Transform CSRankIconContainer;

	public GameObject CSPeakLogo;

	public GameObject CSLogo;

	public Transform CSPeakRankContainer;

	public GameObject SquadContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

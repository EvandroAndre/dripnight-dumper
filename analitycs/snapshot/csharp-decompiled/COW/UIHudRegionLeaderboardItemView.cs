using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRegionLeaderboardItemView : UIBaseView
{
	public UISprite RankSprite;

	public UILabel RankLabel;

	public UILabel NameLabel;

	public UIButton NameBtn;

	public GameObject CurMatchNode;

	public GameObject RegionRankNode;

	public GameObject SelfBg;

	public UILabel Kill;

	public UILabel Dead;

	public UILabel TotalPlayed;

	public UILabel TotalKill;

	public UILabel KD;

	public UISprite RankIcon;

	public GameObject SelectedBg;

	public UIColor HighRankColor;

	public UIColor LowRankColor;

	public GameObject InfoNode;

	public GameObject EmptyNode;

	public Transform TipsTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

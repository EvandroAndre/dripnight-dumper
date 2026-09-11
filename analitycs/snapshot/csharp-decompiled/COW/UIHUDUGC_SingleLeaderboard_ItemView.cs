using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_SingleLeaderboard_ItemView : UIBaseView
{
	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public UILabel ClanName;

	public UILabel Nickname;

	public GameObject Icon_Celebrity;

	public UIGrid LabelGrid;

	public GameObject LabelTemp;

	public GameObject DefaultBg;

	public GameObject SelfBg;

	public UILabel RankLabel;

	public UISprite RankSprite;

	public UILabel LV;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

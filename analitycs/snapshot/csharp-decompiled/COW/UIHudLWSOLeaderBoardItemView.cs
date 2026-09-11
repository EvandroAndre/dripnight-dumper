using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWSOLeaderBoardItemView : UIBaseView
{
	public UIButton UIHudLWSOLeaderBoardItem;

	public Animator ItemAni;

	public GameObject Info;

	public GameObject OwnBG;

	public GameObject TeamMateBG;

	public GameObject EnemyBG;

	public GameObject UpArrow;

	public UILabel UpArrowNumLabel;

	public GameObject DownArrow;

	public UILabel DownArrowNumLabel;

	public UILabel RankLabel;

	public GameObject Rankone;

	public GameObject Ranktwo;

	public GameObject Rankthre;

	public UIGrid HPGrid;

	public UISprite HP1;

	public UISprite HP2;

	public UISprite HP3;

	public UISprite HP4;

	public UISprite HP5;

	public UILabel NameLabel;

	public UISprite RandomIcon;

	public UILabel KLabel;

	public UILabel DLabel;

	public UILabel HSLabel;

	public GameObject Eliminate;

	public GameObject WinStreakVFX2;

	public GameObject WinStreakVFX3;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

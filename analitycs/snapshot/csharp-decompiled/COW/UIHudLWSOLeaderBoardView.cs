using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWSOLeaderBoardView : UIBaseView
{
	public UIButton ExitBtn;

	public UILabel RoundLabel;

	public UILabel TimerLabel;

	public UIScrollView ScrollView;

	public UIGrid ItemGrid;

	public GameObject SelfInfo;

	public GameObject SelfInfoUpArrow;

	public UILabel SelfInfoUpArrowNumLabel;

	public GameObject SelfInfoDownArrow;

	public UILabel SelfInfoDownArrowNumLabel;

	public UILabel SelfInfoRankLabel;

	public GameObject SelfInfoRankone;

	public GameObject SelfInfoRanktwo;

	public GameObject SelfInfoRankthre;

	public UIGrid SelfInfoHPGrid;

	public UISprite SelfInfoHP1;

	public UISprite SelfInfoHP2;

	public UISprite SelfInfoHP3;

	public UISprite SelfInfoHP4;

	public UISprite SelfInfoHP5;

	public UILabel SelfInfoNameLabel;

	public UISprite SelfInfoRandomIcon;

	public UILabel SelfInfoKLabel;

	public UILabel SelfInfoDLabel;

	public UILabel SelfInfoHSLabel;

	public GameObject SelfInfoEliminate;

	public GameObject WinStreakVFX2;

	public GameObject WinStreakVFX3;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVerticleViewTeamScoreBoardView : UIBaseView
{
	public UILabel LeftTeamScore;

	public UILabel LeftTeamName;

	public UIHudTeamBattleScoreTitle TeamScoreTitleLeft;

	public UILabel LeftTitleInfo1Txt;

	public UILabel LeftTitleInfo2Txt;

	public UILabel LeftTitleInfo3Txt;

	public UIScrollView LeftTeamInfoScrollView;

	public UIGrid LeftTeammateGrid;

	public UIWidget LeftTeammateGridWgt;

	public GameObject LeftDragScroll;

	public GameObject LeftDownArrow;

	public UILabel RightTeamScore;

	public UILabel RightTeamName;

	public UIHudTeamBattleScoreTitle TeamScoreTitleRight;

	public UILabel RightTitleInfo1Txt;

	public UILabel RightTitleInfo2Txt;

	public UILabel RightTitleInfo3Txt;

	public UIScrollView RightTeamInfoScrollView;

	public UIGrid RightTeammateGrid;

	public UIWidget RightTeammateGridWgt;

	public GameObject RightDragScroll;

	public GameObject RighttDownArrow;

	public UIButton BackMask;

	public UIButton ReportBtn;

	public UIButton NextBtn;

	public GameObject TipLabel;

	public Transform NormalPos;

	public Transform SpecialPos;

	public UILabel NextBtnTime;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

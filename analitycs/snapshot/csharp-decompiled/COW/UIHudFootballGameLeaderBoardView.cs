using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFootballGameLeaderBoardView : UIBaseView
{
	public UILabel TitleInfo1Txt;

	public UILabel TitleInfo2Txt;

	public UILabel TitleInfo3Txt;

	public UILabel TitleInfo4Txt;

	public Transform LocalPlayerInfo;

	public UIButton BackMask;

	public UIGrid PlayerGrid;

	public UIButton ReportBtn;

	public GameObject MetropolisRoot;

	public UIScrollView PlayerScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

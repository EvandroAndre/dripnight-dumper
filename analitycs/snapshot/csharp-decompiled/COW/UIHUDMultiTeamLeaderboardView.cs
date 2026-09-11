using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDMultiTeamLeaderboardView : UIBaseView
{
	public UIScrollView TeamScrollView;

	public UITable TeamTable;

	public UIButton SpaceBtn;

	public GameObject LeftTitlePlayerTxt;

	public UILabel LeftTitlScoreTxt;

	public Transform TeamScoreTitleLeft;

	public GameObject LabelTemp;

	public UIGrid TitleGrid;

	public UIButton ReportBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeamMatchInfoSimpleView : UIBaseView
{
	public Transform Root;

	public GameObject Bg_Left;

	public UIGrid LeftTeammates;

	public UILabel LeftTeamScore;

	public GameObject Bg_Right;

	public UILabel RightTeamScore;

	public UIGrid RightTeammates;

	public UISprite LeftTeamIcon;

	public UILabel LeftTeamAlive;

	public UISprite RighttTeamIcon;

	public UILabel RightTeamAlive;

	public UIWidget tutorialWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDMultiTeamLeaderboard_TeamItemView : UIBaseView
{
	public UILabel Rank;

	public UISprite TeamColor;

	public Transform ColorTrans;

	public UIGrid TeammateGrid;

	public GameObject No1;

	public GameObject No2;

	public GameObject No3;

	public UIColor Color;

	public Transform infoRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

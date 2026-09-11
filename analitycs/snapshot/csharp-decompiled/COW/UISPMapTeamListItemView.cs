using GCommon;
using UnityEngine;

namespace COW;

public class UISPMapTeamListItemView : UIBaseView
{
	public UILabel Rank;

	public GameObject RankBGOrdinary;

	public GameObject RankBGGold;

	public GameObject RankBGSilver;

	public GameObject RankBGCopper;

	public UISprite TeamIcon;

	public UILabel TeamShortName;

	public UIGrid PlayerNameList;

	public UILabel PlayerName_1;

	public UILabel PlayerName_2;

	public UILabel PlayerName_3;

	public UILabel PlayerName_4;

	public GameObject TeamDeadMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

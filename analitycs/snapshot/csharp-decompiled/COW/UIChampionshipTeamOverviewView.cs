using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipTeamOverviewView : UIBaseView
{
	public GameObject Content;

	public UISprite TeamIcon;

	public UIButton TeamIconBtn;

	public UILabel TeamName;

	public GameObject FlagBg;

	public UISprite NationFlag;

	public UIButton InfoEdit;

	public UIButton InfoEdit_bg;

	public GameObject RankNomal;

	public UILabel RankValue;

	public UISprite RankTop3;

	public UITable TeamInfoTable;

	public UILabel TeamID;

	public GameObject MemberCount;

	public UILabel TeamMemberCount;

	public GameObject TopCup;

	public GameObject NoTeamIcon;

	public GameObject Solo;

	public GameObject Double;

	public GameObject Four;

	public GameObject TopThreeEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

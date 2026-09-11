using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_RoundScoreBannerView : UIBaseView
{
	public UILabel RoundNum;

	public UILabel LeftTeamScore;

	public GameObject LeftDefaultTeamIcon;

	public GameObject LeftDefaultTeamName;

	public UILabel RightTeamScore;

	public GameObject RightDefaultTeamIcon;

	public GameObject RightDefaultTeamName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeamLeaderboardView : UIBaseView
{
	public Transform LeftTeammateInfo;

	public Transform RightTeammateInfo;

	public UILabel LeftTeamScore;

	public UILabel RightTeamScore;

	public UIButton SpaceBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

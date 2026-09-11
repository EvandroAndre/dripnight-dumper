using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSSOLeaderboardView : UIBaseView
{
	public UIGrid ItemListGridMyTeam;

	public Transform ItemListGridMyTeamTF;

	public UIButton BtnClose;

	public GameObject TapToClose;

	public GameObject Round;

	public GameObject ComingSoon;

	public UILabel CountDown;

	public UILabel CurrRoundNum;

	public UILabel LastRoundNum;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

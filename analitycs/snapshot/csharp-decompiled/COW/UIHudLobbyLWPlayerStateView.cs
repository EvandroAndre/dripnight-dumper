using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbyLWPlayerStateView : UIBaseView
{
	public UIProgressBar HPBar;

	public Transform StreakContainer;

	public UILabel TxtPlayerName;

	public GameObject ObserveContainer;

	public GameObject FightingContainer;

	public GameObject Team1Bg;

	public GameObject Team2Bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

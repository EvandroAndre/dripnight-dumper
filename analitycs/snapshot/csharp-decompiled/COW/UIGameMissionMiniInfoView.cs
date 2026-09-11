using GCommon;
using UnityEngine;

namespace COW;

public class UIGameMissionMiniInfoView : UIBaseView
{
	public UISprite Icon;

	public UILabel Countdown;

	public UIProgressBar ProgressBar;

	public GameObject CountdownRoot;

	public UILabel ProgressText;

	public UILabel Name;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

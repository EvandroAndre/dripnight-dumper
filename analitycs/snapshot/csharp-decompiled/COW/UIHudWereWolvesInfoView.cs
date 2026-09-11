using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesInfoView : UIBaseView
{
	public UIProgressBar Progress;

	public GameObject TutorialEffect;

	public UILabel ProgressLabel;

	public UILabel TimerLabel;

	public GameObject AlertNode;

	public UILabel AlertCountDownLabel;

	public UILabel AlertInfoLabel;

	public GameObject WinAlertInfo;

	public GameObject FinalCompleteTaskRoot;

	public UILabel FinalCompleteTaskLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

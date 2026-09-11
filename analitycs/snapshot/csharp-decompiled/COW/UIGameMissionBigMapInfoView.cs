using GCommon;
using UnityEngine;

namespace COW;

public class UIGameMissionBigMapInfoView : UIBaseView
{
	public UISprite TitleBackground;

	public UISprite Icon;

	public UILabel Title;

	public UILabel Countdown;

	public UILabel Description;

	public UIProgressBar ProgressBar;

	public UILabel ProgressLabel;

	public UIWidget GlobalMissionContainer;

	public UILabel RewardDesc;

	public GameObject CountDownIcon;

	public GameObject SuccessIcon;

	public GameObject FailIcon;

	public UILabel RewardTitle;

	public UIWidget TutorialWidget;

	public GameObject ProgressContainer;

	public UITable ContentTable;

	public UISprite Highlight;

	public GameObject FinishIcon;

	public GameObject CountdownRoot;

	public UIWidget EndPadding;

	public Transform TitleRoot;

	public UIColor Background;

	public UISprite RewardIcon;

	public GameObject CrisisRoot;

	public UILabel CrisisTokenCount;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

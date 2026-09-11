using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserCenterView : UIBaseView
{
	public GameObject LevelInfoGo;

	public UIButton SettingBtn;

	public UIButton FeedbackBtn;

	public UIButton TabHelpBtn;

	public UIToggleButtonGroup TabBtns;

	public GameObject CollectionContentContainer;

	public GameObject HistoryPlayedContentContainer;

	public GameObject FollowContentContainer;

	public GameObject FollowRedMarkerPrompt;

	public UIButton CloseBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIToggleConfirmView : UIBaseView
{
	public UIButton CancelBtn;

	public UIButton ConfirmBtn;

	public UIGrid BtnGroupsContainer;

	public UIScrollView ScrollView;

	public UIEasyList EasyList;

	public GameObject Content;

	public GameObject VoiceContent;

	public UILabel ProgressLabel;

	public UISprite Prograssbar;

	public UIButton VoiceTabBtn;

	public UIButton DebugTabBtn;

	public GameObject VoiceTabUnSelect;

	public GameObject VoiceTabSelect;

	public GameObject DebugTabUnSelect;

	public GameObject DebugTabSelect;

	public UILabel ConfirmBtnLabel;

	public UIButton DeleteBtn;

	public GameObject VoiceEmpty;

	public GameObject Progress;

	public UIButton PCMDeleteBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

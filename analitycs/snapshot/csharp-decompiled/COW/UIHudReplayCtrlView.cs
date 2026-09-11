using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReplayCtrlView : UIBaseView
{
	public TweenPosition ContainerTP;

	public UIButton MinusBtn;

	public UIButton PlusBtn;

	public UILabel SpeedTxt;

	public UISprite EventTagDownTemplate;

	public UILabel TimeTxt;

	public UISlider GameTimeSlider;

	public UISprite ProgressBG;

	public UISprite BG;

	public UIButton ExitBtn;

	public UIButton ToggleBtn;

	public UIReplayScreenPress ScreenPress;

	public GameObject Normal;

	public GameObject Highlight_StartObj;

	public Animation Highlight_StartAnim;

	public UIButton OverlooktCamBtn;

	public UIButton NormalCamBtn;

	public UIButton ResetBtn;

	public UISprite EventTagUpTemplate;

	public UIButton RecordBtn;

	public Transform HighlightSettingPos;

	public GameObject Timer;

	public UISprite TimeCircle;

	public UILabel TimeLabel;

	public GameObject SingleHighlightWaitingContainer;

	public GameObject FirstPageContainer;

	public UISprite HighlightIcon;

	public UILabel HighlightLabel;

	public UILabel Label;

	public UITexture PlayerAvatar;

	public UILabel KillCountLabel;

	public GameObject HighLightFilter;

	public UILabel PlayerName;

	public GameObject Highlight_InternalObj;

	public Animation Highlight_InternalAnim;

	public Transform StartLogo;

	public Transform InternalLogo;

	public VFXCreateHelper UIFX_Highlight_Cover;

	public UINetworkTexture FF_Ui_Replay_Mvp_Bg_left01;

	public UINetworkTexture FF_Ui_Replay_Mvp_Bg_left02;

	public UINetworkTexture FF_Ui_Replay_Mvp_Bg_right01;

	public UINetworkTexture FF_Ui_Replay_Mvp_Bg_right02;

	public UINetworkTexture FF_Ui_Replay_Mvp_Bg_Start;

	public UINetworkTexture FF_Ui_Replay_Mvp_Bg_Internal;

	public UINetworkTexture FF_Ui_Replay_Mvp_end_Bg02;

	public UINetworkTexture FF_Ui_Replay_Mvp_end_Bg03;

	public UINetworkTexture FF_Ui_Replay_Mvp_end_Bg01;

	public VFXCreateHelper UIFX_UIHudReplayCtrl_Highlight_Start;

	public VFXCreateHelper UIFX_UIHudReplayCtrl_Highlight_Internal;

	public UIButton ReportBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

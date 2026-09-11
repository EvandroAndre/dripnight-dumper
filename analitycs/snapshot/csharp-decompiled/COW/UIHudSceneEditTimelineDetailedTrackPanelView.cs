using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineDetailedTrackPanelView : UIBaseView
{
	public UILabel title;

	public UITexture Preview;

	public UIButton AddSubTrack;

	public UIButton DelTrack;

	public UIButton CopyTrack;

	public UIButton TrackSetting;

	public UIButton BtnClose;

	public UIButton DelKeyFrameBtn;

	public UIButton AddKeyFrameBtn;

	public UIButton Play;

	public UIButton Pause;

	public UIButton PrevFrame;

	public UIButton NextFrame;

	public GameObject TrackMenu;

	public GameObject EmptyLabel;

	public GameObject Drag;

	public UIPanel UIHudSceneEditTimelineDetailedTrackPanel;

	public UGCTimelineScrollView TrackScrollView;

	public UIPanel TrackScrollViewPanel;

	public UIPanel TrackTitleNode;

	public UITable TrackTable;

	public UIWidget EmptyBack;

	public UITable TrackTitleTable;

	public UILabel Time;

	public UGCTimelineTickHeader Header;

	public GameObject Toolbar;

	public UISprite ToolBarBg;

	public UIButton BtnRecording;

	public UILabel Duration;

	public UISprite PrevIcon;

	public UISprite NextIcon;

	public GameObject EndTimelLine;

	public UIButton BtnPerformance;

	public GameObject RecordIcon;

	public UITable Table;

	public TweenAlpha Flag;

	public TweenAlpha RecordToolIcon;

	public UIButton Back;

	public UILabel LeftPlayheadTime;

	public UILabel RightPlayheadTime;

	public Transform LeftPlayhead;

	public Transform RightPlayhead;

	public GameObject Playhead;

	public UIWidget RightAutoMoveArea;

	public UIWidget LeftAutoMoveArea;

	public UILabel LeftDiffTime;

	public UILabel RightDiffTime;

	public UIButton DelKeyClipBtn;

	public UIButton AddKeyClipBtn;

	public GameObject NormalContainer;

	public UIButton FPVBtn;

	public UISprite TimelineSettingIcon;

	public UISprite FPVIcon;

	public UIGrid Grid;

	public UIButton HintBtn;

	public UIButton BtnSwitchCamera;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

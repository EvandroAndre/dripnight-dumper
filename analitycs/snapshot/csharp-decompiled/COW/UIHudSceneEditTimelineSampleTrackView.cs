using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineSampleTrackView : UIBaseView
{
	public UIButton BtnDetialEdit;

	public UITable TrackTable;

	public UITable TrackTitleTable;

	public UIButton Play;

	public UISprite PlayIcon;

	public UIButton PrevFrame;

	public UIButton NextFrame;

	public UGCTimelineScrollView TrackScrollView;

	public UIPanel TrackScrollViewPanel;

	public UGCTimelineTickHeader Header;

	public GameObject TrackMenu;

	public UIPanel UIHudSceneEditTimelineSampleTrack;

	public UGCTimelineUILayout Layout;

	public UILabel Time;

	public UIButton BtnRecording;

	public BoxCollider Drag;

	public UIWidget DragWidget;

	public UISprite Back;

	public UIPanel TrackTitleNode;

	public UIWidget EmptyBack;

	public GameObject EmptyLabel;

	public Transform Node;

	public UIButton Pause;

	public UISprite PrevIcon;

	public UISprite NextIcon;

	public TweenAlpha RecordIcon;

	public Transform LeftPlayhead;

	public UILabel LeftPlayheadTime;

	public UILabel LeftDiffTime;

	public Transform RightPlayhead;

	public UILabel RightPlayheadTime;

	public UILabel RightDiffTime;

	public UIWidget LeftAutoMoveArea;

	public UIWidget RightAutoMoveArea;

	public UIButton BtnSwitchCamera;

	public UIButton HintBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

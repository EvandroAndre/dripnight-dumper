using UnityEngine;

namespace COW;

public class UGCTimelineUILayout : MonoBehaviour
{
	private int defaultBackHeight;

	public int expandBackHeight;

	private Vector4 defaultScrollViewSize;

	public Vector4 expandScrollViewSize;

	private Vector4 defaultPlayHeadViewSide;

	public Vector4 expandPlayHeadViewSide;

	private int defaultPlayHeadTickLineHeight;

	public int expandPlayHeadTickLineHeight;

	private Vector3 defaultScrollViewTrackPos;

	public Vector3 expandScrollViewTracPos;

	private Vector3 defaultScrollViewTrackTitlePos;

	public Vector3 expandScrollViewTrackTitlePos;

	private Vector3 defaultPlayHeadViewTitlePos;

	public Vector3 expandPlayHeadViewTitlePos;

	public Vector3 SidePlayHeadTitlePos;

	private int defaultDragWidgetHeight;

	public int expandDragWidgetHeight;

	private Vector3 defaultNodePos;

	public Vector3 expandNodePos;

	private float scrollViewExpandHalfSize;

	private float scrollPlayHeadViewHalfSize;

	public float TableOffsetY;

	public UIAnchor Node;

	public UISprite Back;

	public UIPanel TrackScrollView;

	public UIPanel TitleScrollView;

	public UITable TrackTable;

	public UITable TitleTable;

	public UISprite PlayHeadTickLine;

	public UIWidget DragWidget;

	public UIPanel PlayHeadView;

	public Transform LeftPlayHead;

	public Transform RightPlayHead;

	private bool m_Expand;

	public bool Expand => false;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetExpandTrack(bool expand)
	{
	}
}

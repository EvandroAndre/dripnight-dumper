using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugPlayerMatchSummaryDataWindowView : UIBaseView
{
	public Transform ContainerTransform;

	public UIWidget ContainerUIWidget;

	public GameObject ContainerEventTrigger;

	public UIGrid Grid;

	public UIScrollView UIScrollView;

	public UIPanel UIScrollViewPanel;

	public UIPanel UIDebugPlayerMatchSummaryDataWindow;

	public UIDragScrollView DragScrollView;

	public GameObject DragScrollEventTrigger;

	public UIButton Close;

	public UIButton StartBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

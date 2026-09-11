using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatBubbleView : UIBaseView
{
	public UISprite BubbleBG;

	public UILabel BubbleLabel;

	public UIWidget ContainerWidget;

	public UIHUDAIChatDragItem DragItem;

	public BoxCollider ContainerBoxCollider;

	public GameObject ArrowLeftUp;

	public GameObject ArrowLeftBottom;

	public GameObject ArrowRightUp;

	public GameObject ArrowRightBottom;

	public UIPanel BubblePanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

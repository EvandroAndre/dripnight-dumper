using GCommon;
using UnityEngine;

namespace COW;

public class UIPresetAgentBubbleView : UIBaseView
{
	public UISprite BubbleBG;

	public UILabel BubbleLabel;

	public TypewriterEffect TypeWriter;

	public UIWidget ContainerWidget;

	public UIHUDAIChatDragItem DragItem;

	public BoxCollider ContainerBoxCollider;

	public GameObject ArrowLeftUp;

	public UIPanel BubblePanel;

	public GameObject ArrowRightUp;

	public UIWidget RecommendContainer;

	public UIButton BtnGotoRecommend;

	public UITable FastMessageTable;

	public UITable Table;

	public AudioCDNDownload AudioCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

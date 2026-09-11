using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityADContentView : UIBaseView
{
	public UIPanel Mask;

	public UIDragScrollView DragArea;

	public UIWidget DragWidget;

	public UIScrollView ScrollView;

	public UINetworkTexture AD;

	public UIEventListener ADMaxEvent;

	public GameObject ArrowDown;

	public UIButton GoTo;

	public Animation ButtonAnimation;

	public UILabel Title;

	public GameObject GoToRedpoint;

	public UIButton GoPosButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

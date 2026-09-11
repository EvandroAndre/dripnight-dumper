using GCommon;
using UnityEngine;

namespace COW;

public class UIWishBriefBoxView : UIBaseView
{
	public UIButton ReturnButton;

	public UIGrid Grid;

	public Transform Container;

	public Transform ContainerTransform;

	public TweenPosition ContainerTweenPosition;

	public TweenAlpha ContainerTweenAlpha;

	public UIWidget Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudStackedFeedbackNotificationView : UIBaseView
{
	public Transform PreNode1;

	public Animation OutAni;

	public Animation OutAni2;

	public Transform PreNode2;

	public Transform Label1;

	public Transform Label2;

	public TweenAlpha OutNode1;

	public TweenAlpha OutNode2;

	public TweenAlpha LabelAlpla;

	public TweenScale LabelScale;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

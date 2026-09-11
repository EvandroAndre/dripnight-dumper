using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardGuideMaskView : UIBaseView
{
	public UITexture GuideMaskBg;

	public Transform LeftCollider;

	public Transform RightCollider;

	public Transform DownCollider;

	public Transform UpCollider;

	public UIWidget GuideClickAreaWidget;

	public UIButton GuideClickAreaBtn;

	public UIButton GuideCloseBtn;

	public GameObject SkipContent;

	public UIButton SkipButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

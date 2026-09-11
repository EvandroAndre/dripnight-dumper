using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaView : UIBaseView
{
	public Animator GachaAnimator;

	public UIScrollView TabScrollView;

	public GameObject UIGachaRightBorder;

	public TweenAlpha ChangeSceneMask;

	public UINetworkTexture NetworkTexture;

	public Transform ContentPanel;

	public UIButton InterfaceContentMask;

	public GameObject InterfaceContentMaskLabel;

	public UIButton InterfaceMask;

	public GameObject InterfaceMaskLabel;

	public UIWidget PreviewBorder;

	public UITable GachaTab;

	public GameObject UI3DPanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

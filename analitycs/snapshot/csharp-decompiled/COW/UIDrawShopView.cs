using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopView : UIBaseView
{
	public UIScrollView DropShopScrollView;

	public UITable DrawShopTable;

	public UINetworkTexture NetworkTexture;

	public GameObject ContentPanel;

	public UIButton InterfaceContentMask;

	public GameObject InterfaceContentMaskLabel;

	public GameObject InterfaceMaskLabel;

	public GameObject UI3DPanel;

	public UIWidget PreviewBorder;

	public UIButton InterfaceMask;

	public UIWidget LimitedPreviewBorder;

	public UIAnchor Left;

	public UIAnchor Right;

	public Animation TabINAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

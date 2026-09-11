using GCommon;
using UnityEngine;

namespace COW;

public class UICommonDiamondPurchasePopupWndView : UIBaseView
{
	public GameObject ItemPreviewGroup;

	public GameObject NoPreviewGroup;

	public UILabel PreviewPurchaseMsgLabel;

	public Transform PreviewItemRoot;

	public UILabel NoPreviewPurchaseMsgLabel;

	public UIButton DiamondPurchaseBtn;

	public UILabel DiamondLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

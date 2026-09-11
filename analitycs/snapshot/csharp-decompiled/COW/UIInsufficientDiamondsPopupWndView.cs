using GCommon;
using UnityEngine;

namespace COW;

public class UIInsufficientDiamondsPopupWndView : UIBaseView
{
	public UIPanel MainWidget;

	public UINetworkTexture CDN;

	public GameObject TableBtns;

	public UIButton IAPBtn;

	public UIButton BundleBtn;

	public UILabel Title;

	public UILabel Desc;

	public UILabel BundleBtnLabel;

	public UILabel cdnLabel;

	public UILabel Label;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

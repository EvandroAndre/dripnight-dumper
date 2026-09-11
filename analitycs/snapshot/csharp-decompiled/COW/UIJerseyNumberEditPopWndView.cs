using GCommon;
using UnityEngine;

namespace COW;

public class UIJerseyNumberEditPopWndView : UIBaseView
{
	public UIButton CloseBtn;

	public UIButton TenNumberPlus;

	public UIButton TenNumberSubtr;

	public UIButton NumberPlus;

	public UIButton NumberSubtr;

	public UIButton ComfirmBtn;

	public UINetworkTexture EnableBg;

	public UINetworkTexture WndBg;

	public UILabel WndTitle;

	public GameObject DefaultWndBg;

	public GameObject ConfigBg;

	public GameObject DefaultBg;

	public GameObject DefaultEnableBg;

	public UIScrollView TenNumberScrollView;

	public UIWrapContent TenNumbWrapcontent;

	public UIScrollView NumberScrollView;

	public UIWrapContent NumbWrapcontent;

	public Transform TenNumberEffect;

	public Transform NumberEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIFastSendGiftView : UIBaseView
{
	public UIButton CloseBtn;

	public UIScrollView GiftItemScrollView;

	public UIEasyList GiftItemGrid;

	public UISprite Mask;

	public UIGrid TeamMateGrid;

	public GameObject BtnGroupContainer;

	public UIButton SendBtn;

	public UINetworkTexture BGCDN;

	public GameObject SendBtnBGGray;

	public GameObject SendBtnBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

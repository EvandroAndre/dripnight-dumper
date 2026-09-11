using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2GiftSendView : UIBaseView
{
	public TweenColor tweenColor;

	public UIButton CloseBtn;

	public GameObject CallSignList;

	public GameObject ListPanel;

	public UIGrid ReceiverGrid;

	public UIInput MessageInput;

	public UIButton SendBtn;

	public UILabel GiftTitle;

	public Transform ProfileInfoRoot;

	public Transform RepeatTransform;

	public UISprite bg;

	public UILabel SubTitleGiftName;

	public UINetworkTexture CDNBG;

	public GameObject PrimeMessageBox;

	public GameObject MessageBox;

	public UILabel PrimeGiftTitle;

	public UILabel PrimeSubTitleGiftName;

	public UIInput MultiReceiverMessageInput;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIGiftGetRewardView : UIBaseView
{
	public UIButton OKBtn;

	public UILabel BtnLabel;

	public UILabel Message;

	public UILabel GiftItemName;

	public Transform GiftCardCallsignContainer;

	public Transform ReceiveGiftItemContainer;

	public Transform ReceiveGiftCallsignContainer;

	public Transform GiftCardItemContainer;

	public GameObject PrimeContainer;

	public GameObject NormalContainer;

	public GameObject ReceiveGiftContainer;

	public GameObject GiftCardContainer;

	public UIButton NextBtn;

	public UIButton AddFriendBtn;

	public UIButton MaskBtn;

	public UINetworkTexture PrimeCDNBG;

	public UINetworkTexture NormalCDNBG;

	public GameObject NormalReceiveGiftContainer;

	public GameObject PrimeReceiveGiftContainer;

	public UIButton AddFriendBtn_Prime;

	public UILabel Message_Prime;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureRewardItemView : UIBaseView
{
	public GameObject ItemPos;

	public GameObject Dot;

	public UILabel Label;

	public UIButton BtnClaim;

	public GameObject RedDot;

	public UISprite Claimed;

	public GameObject Bubble;

	public Transform BubbleItemPos;

	public GameObject UIFX_ItemPos;

	public UINetworkTexture BigAwardCDN;

	public GameObject Lock;

	public VFXCreateHelper UIFX_BigAward;

	public GameObject UIFX_TeamNumber;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

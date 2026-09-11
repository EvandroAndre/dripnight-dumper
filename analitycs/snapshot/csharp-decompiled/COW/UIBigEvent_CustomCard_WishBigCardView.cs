using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_WishBigCardView : UIBaseView
{
	public UINetworkTexture Background;

	public UINetworkTexture CardIcon;

	public UIButton CardBtn;

	public UIButton BtnReceive;

	public UINetworkTexture BtnReceiveTexture;

	public Transform ProfileInfoGo;

	public GameObject WishContainer;

	public UILabel WishLabel;

	public GameObject main;

	public Transform EffectContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopTabItemView : UIBaseView
{
	public UINetworkTexture NetworkTexture;

	public UIButton ItemBtn;

	public UISprite Icon;

	public GameObject NewsIcon;

	public GameObject PrimeLockState;

	public Transform NewBieVFX;

	public GameObject DiscountTag;

	public UILabel DiscontTagLabel;

	public GameObject Mask;

	public Transform HighLightVFX;

	public Animation Ani;

	public GameObject Selected;

	public UISprite SelectedSprite;

	public GameObject SelectedCDN;

	public UINetworkTexture SelectedCDNNetWorkTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

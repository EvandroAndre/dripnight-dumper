using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomShopCardItemView : UIBaseView
{
	public UINetworkTexture Background;

	public UILabel LimitLabel;

	public UIButton ConfirmBtn;

	public UINetworkTexture ConfirmBtnTex;

	public UISprite TokenIcon;

	public UILabel TokenCount;

	public Transform Card;

	public GameObject SellOutLabel;

	public UILabel Need;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

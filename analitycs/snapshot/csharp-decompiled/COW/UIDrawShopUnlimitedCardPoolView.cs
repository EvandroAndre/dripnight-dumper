using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedCardPoolView : UIBaseView
{
	public UILabel CardPoolNameLabel;

	public UIButton ClickBtn;

	public Transform PoolItemTransform0;

	public Transform PoolItemTransform1;

	public Transform PoolItemTransform2;

	public Transform PoolItemTransform3;

	public Transform PoolItemTransform4;

	public Transform PoolItemTransform5;

	public Transform PoolItemTransform6;

	public Transform PoolItemTransform7;

	public GameObject CardPoolCdnBG;

	public UINetworkTexture CardPoolCdnBGNetWorkTexture;

	public GameObject CardPoolBG;

	public Transform CardBackVFXTransfrom;

	public VFXCreateHelper CardBackVFXHelper;

	public Transform CardPoolTransform;

	public VFXCreateHelper CardPoolVFXHelper;

	public Animation CardPoolDrawAnimation;

	public GameObject CdnCardPoolDownBG;

	public UINetworkTexture CdnCardPoolDownBGNetworkTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

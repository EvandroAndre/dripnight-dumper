using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisNormalWholeRowSTierSpecialItemView : UIBaseView
{
	public UINetworkTexture CDNNetWorkTexture;

	public UILabel NumberLabel;

	public GameObject ItemContainer;

	public GameObject CDNContainer;

	public UICenterTargetHelper ItemGrid;

	public GameObject ItemSlot0;

	public GameObject ItemSlot1;

	public GameObject ItemSlot2;

	public GameObject ItemSlot3;

	public GameObject NumberContainer;

	public GameObject SelectedContainer;

	public GameObject OwnedContainer;

	public GameObject CDNItemNumberContainer;

	public GameObject CDNItemNumberLabel;

	public GameObject TimeLimit;

	public GameObject TimeLimitLabel;

	public GameObject SoldoutObject;

	public GameObject CDNItemStateContainer;

	public UIButton CDNBtn;

	public UINetworkTexture CDNSoldOutNetWorkTexture;

	public GameObject NumberUIFX;

	public VFXCreateHelper NumberUIFXVFXCreateHelper;

	public UINetworkTexture CDNBG;

	public UINetworkTexture CDNSoldOutBGNetWorkTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

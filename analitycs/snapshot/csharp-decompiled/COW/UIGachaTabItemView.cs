using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaTabItemView : UIBaseView
{
	public Animation AnimationScale;

	public UINetworkTexture NetworkTexture;

	public UIButton ItemBtn;

	public UISprite Icon;

	public UISprite NewsIcon;

	public GameObject Effect_Glow;

	public GameObject LuckySpin;

	public GameObject ScaledWidget;

	public GameObject OriginalWidget;

	public Transform LuckySpinVFX;

	public GameObject OriginalLuckySpinWidget;

	public GameObject ScaledLuckySpinWidget;

	public Transform NewBieVFX;

	public Transform RoyaleVFX;

	public GameObject PrimeLockState;

	public GameObject DiscountTag;

	public UILabel DiscountTagLabel;

	public GameObject Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

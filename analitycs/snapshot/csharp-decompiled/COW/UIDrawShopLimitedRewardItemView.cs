using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopLimitedRewardItemView : UIBaseView
{
	public GameObject UIDrawShopLimitedRewardItem;

	public Animation RewardAnim;

	public VFXCreateHelper SelectedBG;

	public UIButton BtnTip;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite Quality;

	public GameObject ObtainedSprite;

	public GameObject GrayContainer;

	public UISprite SpriteOrangeQualityPlus;

	public BaseItemView2 BaseInfoView;

	public GameObject FinishedSprite;

	public GameObject OnlyOnceSprite;

	public VFXCreateHelper VFXNormal;

	public VFXCreateHelper VFXTranslucent;

	public VFXCreateHelper VFXGetReward;

	public VFXCreateHelper VFXDropReward;

	public VFXCreateHelper VFXDropSelect;

	public UINetworkTexture bgCDN;

	public GameObject ReturnItemContainer;

	public UILabel ReturnNumLabel;

	public UISprite ReturnIcon;

	public VFXCreateHelper VFXDroping;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

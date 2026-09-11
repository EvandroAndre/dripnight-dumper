using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaLimitChestSelectRewardItemView : UIBaseView
{
	public GameObject UIGachaLimitChestSelectRewardItem;

	public GameObject ItemInfoContainer;

	public BaseItemView BaseInfoView;

	public UISprite SelectedBG;

	public GameObject ItemContainer;

	public GameObject ObtainedSprite;

	public GameObject LimitTimeLabel;

	public UILabel DropUpLabel;

	public GameObject AlreadyOwnSprite;

	public UIButton BtnTip;

	public UISprite QualityBG;

	public UISprite SpritePurplePlus;

	public UISprite Quality;

	public GameObject FlickerEffect;

	public GameObject SecondVFX;

	public GameObject FirstVFX;

	public GameObject ThirdVFX;

	public UIButton ChooseContainer;

	public GameObject ChooseState;

	public Animation RemoveContainer;

	public GameObject VfxRemove;

	public UISprite SpriteOrangePlus;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

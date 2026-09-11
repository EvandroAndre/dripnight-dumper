using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaLimitItemView : UIBaseView
{
	public GameObject UIGachaLimitItem;

	public GameObject GameObjectItemInfoContainer;

	public BaseItemView BaseItemViewItemInfoContainer;

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

	public GameObject ThirdVFX;

	public UIButton ChooseContainer;

	public GameObject ChooseState;

	public Animation RemoveContainer;

	public GameObject VfxRemove;

	public GameObject SpriteOrangePlus;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

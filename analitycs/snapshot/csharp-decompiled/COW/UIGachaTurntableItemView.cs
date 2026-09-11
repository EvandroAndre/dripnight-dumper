using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaTurntableItemView : UIBaseView
{
	public GameObject UIGachaTurntableItem;

	public TweenAlpha AnimAlpha;

	public GameObject ItemInfoContainer;

	public BaseItemView BaseInfoView;

	public TweenScale AnimScale;

	public UISprite SelectedBG;

	public UIButton BtnTip;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite Quality;

	public GameObject ObtainedSprite;

	public GameObject LimitTimeLabel;

	public UILabel DropUpLabel;

	public GameObject FlickerEffect;

	public GameObject SeniorVFX;

	public GameObject JuniorVFX;

	public UISprite SpriteOrangeQualityPlus;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

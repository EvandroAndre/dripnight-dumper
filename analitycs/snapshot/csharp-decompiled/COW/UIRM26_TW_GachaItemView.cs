using GCommon;
using UnityEngine;

namespace COW;

public class UIRM26_TW_GachaItemView : UIBaseView
{
	public GameObject UIRM26_TW_GachaItem;

	public TweenAlpha AnimAlpha;

	public TweenScale AnimScale;

	public UISprite SelectedBG;

	public UIButton BtnTip;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite Quality;

	public GameObject ObtainedSprite;

	public UILabel DropUpLabel;

	public GameObject FlickerEffect;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject VFX_Red;

	public GameObject VFX_Orange;

	public GameObject VFX_Purple;

	public GameObject VFX_Blue;

	public BaseItemView2 BaseInfoView;

	public GameObject FinishedSprite;

	public GameObject OnlyOnceSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

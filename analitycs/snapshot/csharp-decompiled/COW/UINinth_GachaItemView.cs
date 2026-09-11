using GCommon;
using UnityEngine;

namespace COW;

public class UINinth_GachaItemView : UIBaseView
{
	public GameObject UINinth_GachaItem;

	public TweenScale AnimScale;

	public UISprite SelectedBG;

	public UIButton BtnTip;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite Quality;

	public GameObject ObtainedSprite;

	public UILabel DropUpLabel;

	public UISprite SpriteOrangeQualityPlus;

	public BaseItemView2 BaseInfoView;

	public GameObject FinishedSprite;

	public GameObject OnlyOnceSprite;

	public Transform VFX;

	public VFXCreateHelper AnimSprite;

	public VFXCreateHelper FlickerEffect;

	public VFXCreateHelper VFXNormal;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

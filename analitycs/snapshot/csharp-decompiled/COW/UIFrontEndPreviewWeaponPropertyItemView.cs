using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponPropertyItemView : UIBaseView
{
	public GameObject pro;

	public GameObject down;

	public UISprite down3;

	public TweenAlpha alphaDown3;

	public UISprite down2;

	public TweenAlpha alphaDown2;

	public UISprite down1;

	public TweenAlpha alphaDown1;

	public GameObject up;

	public UISprite up1;

	public TweenAlpha alphaUp1;

	public UISprite up2;

	public TweenAlpha alphaUp2;

	public UISprite up3;

	public TweenAlpha alphaUp3;

	public UILabel scoreName;

	public TweenAlpha alphaName;

	public UIProgressBar scoreBar;

	public UISprite BarFG;

	public UISprite deltaFg;

	public UILabel scoreValue;

	public UILabel deltaValue;

	public UISprite BarBG;

	public GameObject deltaFg02;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

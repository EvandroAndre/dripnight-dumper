using GCommon;
using UnityEngine;

namespace COW;

public class UICollectionVehicleSkinScoreItemView : UIBaseView
{
	public UILabel scoreName;

	public TweenAlpha alphaName;

	public GameObject up;

	public UISprite up1;

	public TweenAlpha alphaUp1;

	public UISprite up2;

	public TweenAlpha alphaUp2;

	public UISprite up3;

	public TweenAlpha alphaUp3;

	public GameObject down;

	public UISprite down3;

	public TweenAlpha alphaDown3;

	public UISprite down2;

	public TweenAlpha alphaDown2;

	public UISprite down1;

	public TweenAlpha alphaDown1;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

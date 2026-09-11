using GCommon;
using UnityEngine;

namespace COW;

public class UIHudItemSearchMarkView : UIBaseView
{
	public UISprite MarkPoint;

	public UISprite PickUpLine;

	public UIWidget UIShowContainer;

	public GameObject Distance;

	public GameObject ArrowDown;

	public UISprite ArrowDownSprite;

	public GameObject ArrowRight;

	public UISprite ArrowRightSprite;

	public GameObject ArrowLeft;

	public UISprite ArrowLeftSprite;

	public GameObject ArrowUp;

	public UISprite ArrowUpSprite;

	public UISprite TriggerImg;

	public GameObject CrossIcon;

	public Animation CrossAnimation;

	public UILabel DistanceLabel;

	public UILabel DistanceM;

	public TweenScale TweenScale;

	public UIButton hideBtn;

	public UISprite EffectLevelBG;

	public UISprite CommonBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

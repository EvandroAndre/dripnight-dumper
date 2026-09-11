using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunCarouselView : UIBaseView
{
	public UIScrollView ScrollViewCarousel;

	public UICenterOnChild CenterOnChild;

	public UIWrapContent WrapContent;

	public UICarouselTickManager Content;

	public UIGrid GridDots;

	public GameObject CountDownProgress;

	public UISprite SpriteThumb;

	public UISprite SpriteContentBg;

	public UISprite SpriteTittleBg;

	public GameObject BgContainer;

	public UIButton ButtonShowPrivilegeList;

	public GameObject ShowPrivilegeList;

	public GameObject UpArrow;

	public GameObject DownArrow;

	public Transform PrivilegeListTrans;

	public GameObject Title;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

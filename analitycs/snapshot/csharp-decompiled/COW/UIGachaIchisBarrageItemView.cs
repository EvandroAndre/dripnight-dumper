using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisBarrageItemView : UIBaseView
{
	public UISprite HeadPicSprite;

	public UITexture HeadPicTexture;

	public UINetworkTexture HeadPicNetworkTexture;

	public UILabel NameLabel;

	public GameObject VFXContainer;

	public VFXCreateHelper VFXCreateHelper;

	public GameObject BigPrizeBg;

	public GameObject NormalBg;

	public UICircle HeadPicCircle;

	public UIButton BarrageBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

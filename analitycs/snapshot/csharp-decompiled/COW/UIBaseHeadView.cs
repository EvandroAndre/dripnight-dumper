using GCommon;
using UnityEngine;

namespace COW;

public class UIBaseHeadView : UIBaseView
{
	public UIButton UIBaseHead;

	public UIWidget BaseProfileWidget;

	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public GameObject FakeSprite;

	public Transform AvatarFramePos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchProfileItemView : UIBaseView
{
	public UISprite LeaderIcon;

	public UILabel LabelName;

	public GameObject Right;

	public UINetworkTexture HeadTextureRight;

	public UISprite HeadIconRight;

	public GameObject Left;

	public UINetworkTexture HeadTextureLeft;

	public UISprite HeadIconLeft;

	public GameObject Center;

	public UISprite HeadIconCenter;

	public UINetworkTexture HeadTextureCenter;

	public UILabel LabelNameCenter;

	public UISprite LeaderIconCenter;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

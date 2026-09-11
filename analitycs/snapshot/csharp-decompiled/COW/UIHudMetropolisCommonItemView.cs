using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisCommonItemView : UIBaseView
{
	public GameObject light_mask;

	public UITexture Texture;

	public UILabel LabelCount;

	public UIButton BtnItemAction;

	public UILabel ItemName;

	public UIEventListener BtnEventListener;

	public UISprite SpriteItemIcon;

	public UISprite SpriteBackground;

	public GameObject Chosen;

	public UISprite IconBuff;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

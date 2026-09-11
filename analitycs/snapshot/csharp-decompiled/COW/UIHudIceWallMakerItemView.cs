using GCommon;
using UnityEngine;

namespace COW;

public class UIHudIceWallMakerItemView : UIBaseView
{
	public UIToggle ItemToggle;

	public GameObject NonDragGO;

	public UILabel ItemName;

	public UILabel ItemCount;

	public UISprite SpriteBg;

	public GameObject HighlightGO;

	public UISprite ItemIcon;

	public UILabel CountLabel;

	public UISprite ProcessSp;

	public UISprite GenerateIcon;

	public UILabel MaxLabel;

	public GameObject ReplacerEffectRoot;

	public GameObject ReplacerNormallEffect;

	public GameObject ReplacerMaxEffect;

	public Animation UIFX_Group;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

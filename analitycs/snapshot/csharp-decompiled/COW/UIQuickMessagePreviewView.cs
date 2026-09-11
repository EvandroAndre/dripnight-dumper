using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessagePreviewView : UIBaseView
{
	public UIEasyList PreviewEasyList;

	public UIEasyList DetailTipEasyList;

	public UIEasyList RewardEasyList;

	public GameObject PreviewContainer;

	public GameObject DetailTipsContainer;

	public GameObject RewardContainer;

	public UISprite ItemIcon;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite QualityNameBG01;

	public UISprite SpriteOrangeQualityPlus;

	public UIPanel PreviewBgPanel;

	public UISprite Icon;

	public UIPanel PreviewScrollPanel;

	public UINetworkTextureExt BGframe;

	public UISprite BGrecord;

	public UISprite BGrecord2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

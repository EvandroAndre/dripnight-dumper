using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeGameplayAffixPreviewView : UIBaseView
{
	public GameObject EnterGroup;

	public Animation EnterGroupAnim;

	public GameObject GameplayAffixEntry1;

	public Animation GameplayAffixEntry1Anim;

	public UISprite AffixIcon1;

	public UILabel AffixTitleLabel1;

	public UILabel AffixDescriptionLabel1;

	public UIButton SkipBtn;

	public UIPanel RootPanel;

	public TweenAlpha RootTweenAlpha;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UILadderHeroicMarkPopupView : UIBaseView
{
	public Animation EnterAnim;

	public GameObject InfoBefore;

	public UILabel IconBeforeLabel;

	public GameObject InfoAfter;

	public UILabel IconAftereLabel;

	public UIButton backBtnMask;

	public UILabel BackBtnLabel;

	public GameObject VfxContent;

	public UILabel GrandmasterIconBeforeLabel;

	public UILabel GrandmasterIconAftereLabel;

	public UISprite IconBgBeforeSprite;

	public UISprite IconBgAfterSprite;

	public UISprite GrandmasterIconBgBeforeSprite;

	public UISprite GrandmasterIconBgAftereSprite;

	public UISprite SIconBeforeSprite;

	public UISprite SIconAfterSprite;

	public UISprite GrandmasterSIconBeforeSprite;

	public UISprite GrandmasterSIconAfterSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIScreenShotShareMessageWindowView : UIBaseView
{
	public UILabel Label;

	public UIButton CloseBtn;

	public Transform ShareBtnGroupContainer;

	public UIButton LineInvite;

	public UIButton BindInvite;

	public UISprite BindSprite;

	public UIButton OtherInvite;

	public UIGrid Grid;

	public Animator PopWndAnimator;

	public UIButton WhatsAppInvite;

	public UIButton InstagramInvite;

	public UIButton PreviewBtn;

	public UITable PreviewContent;

	public UILabel PreviewLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

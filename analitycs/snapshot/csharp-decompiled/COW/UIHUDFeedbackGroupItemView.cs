using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDFeedbackGroupItemView : UIBaseView
{
	public UISprite KillTypeIcon;

	public GameObject Node;

	public UILabel content;

	public UISprite KillerNameBG;

	public UIEventListener BtnTip;

	public UISprite Bg;

	public TweenScale AudioRoot;

	public Animation Widget;

	public UIGridAnimPopAsideItem QueueItem;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

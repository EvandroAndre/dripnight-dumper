using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDFeedbackItemView : UIBaseView
{
	public GameObject UIHUDFeedbackItem;

	public UISprite KillTypeIcon;

	public GameObject Node;

	public UILabel content;

	public UISprite KillerNameBG;

	public UISprite Bg;

	public Transform VFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

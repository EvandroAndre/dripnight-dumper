using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReviveBubbleView : UIBaseView
{
	public UIButton BtnClaim;

	public Object Card;

	public UISprite ActivatedProgress;

	public GameObject Activated;

	public GameObject Inactive;

	public UISprite InactiveProgress;

	public Animation BubbleAnim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

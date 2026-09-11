using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHintQueueView : UIBaseView
{
	public UISprite Icon;

	public UILabel Desc;

	public UISprite DescBG;

	public UISprite HorizontalIcon;

	public UILabel HorizontalDesc;

	public UISprite HorizontalDescBG;

	public GameObject Horizontal;

	public UICenterTargetHelper CenterHelper;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

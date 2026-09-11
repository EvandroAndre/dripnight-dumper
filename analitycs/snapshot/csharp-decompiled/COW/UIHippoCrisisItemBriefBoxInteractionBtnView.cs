using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisItemBriefBoxInteractionBtnView : UIBaseView
{
	public UILabel Label;

	public UISprite bg;

	public UISprite Icon;

	public UIButton Btn;

	public UIWidget BtnWidget;

	public BoxCollider BtnBoxCollider;

	public GameObject AbleContainer;

	public GameObject DisableContainer;

	public UISprite disableIcon;

	public UILabel disableLabel;

	public UISprite disableBg;

	public UIWidget GuideWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

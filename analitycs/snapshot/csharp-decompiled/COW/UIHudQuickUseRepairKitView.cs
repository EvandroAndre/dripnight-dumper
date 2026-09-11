using GCommon;
using UnityEngine;

namespace COW;

public class UIHudQuickUseRepairKitView : UIBaseView
{
	public UIButton BtnQuickUse;

	public UIWidget Icon;

	public ParticleSystem FlashEffect;

	public UILabel RepairKitCount;

	public GameObject PrepTimer;

	public UILabel TimeLabel;

	public UISprite Progress;

	public GameObject UrgencyTipObj;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTokenInReviveZoneView : UIBaseView
{
	public GameObject NormalRoot;

	public GameObject WarningRoot;

	public UIEventListener RevivalBtn;

	public UILabel TimeLabel;

	public UILabel RevivalTipsLabel;

	public UISprite RevivalIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

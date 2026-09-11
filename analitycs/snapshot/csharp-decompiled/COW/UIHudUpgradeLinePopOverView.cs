using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUpgradeLinePopOverView : UIBaseView
{
	public UITable DetailTable;

	public UISprite DetailBg;

	public GameObject NextAbility;

	public UIHudUpgradeGemStateItem GemGroup;

	public UISprite NextIcon;

	public UILabel NextDesc;

	public UIHudUpgradeLineDescItem DetailUpgradeTemplate;

	public GameObject QuickInvBtnContainer;

	public UIButton QuickInvBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

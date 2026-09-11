using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarInfoNavigationView : UIBaseView
{
	public UIPanel UIAvatarInfoNavigation;

	public GameObject TopContainer;

	public UIButton VaultBtn;

	public Transform LeftContainer;

	public UILabel LoadoutPlanLabel;

	public GameObject ExpireTime;

	public UILabel ExpireTimeLabel;

	public Transform RightContainer;

	public UIWidget PreviewBoard;

	public GameObject EvogunVipTip;

	public UIButton EvogunVipButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

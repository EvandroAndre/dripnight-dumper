using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassPrivilegeIntroduceWndView : UIBaseView
{
	public UIGrid PrivilegeGrid;

	public UIToggleButtonGroup PrivilegeToggleGroup;

	public UINetworkTexture PrivilegeCDNTexture;

	public UILabel RuleLabel;

	public UIButton CloseBtn;

	public Transform BtnUnlockNode;

	public Transform Bg;

	public UIButton PurchaseBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

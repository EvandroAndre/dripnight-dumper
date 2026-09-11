using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunMembershipPageView : UIBaseView
{
	public UIScrollView ScrollView;

	public UITable2 RewardList;

	public UICheckboxButton SubscribeBtn;

	public UIButton SubscribeRuleBtn;

	public UIButton PurchaseBtn;

	public GameObject WithInPeriodContainer;

	public UIToggleButtonGroup ToggleBtnGroup;

	public Transform PosPrice1;

	public Transform PosPrice2;

	public Transform PosPrice3;

	public GameObject SubscribeContainer;

	public UINetworkTexture TopBGTexture;

	public UILabel BoundsLabel;

	public UILabel WithInPeriodLabel;

	public UICountDownLabel ExpireTimeLabel;

	public UIButton SubscribeRuleBtn2;

	public GameObject Main;

	public GameObject ActiveContainer;

	public Transform GunItemPos;

	public GameObject SubscribeLabel;

	public UITable PurchaseContentTable;

	public UILabel PurchaseLabel;

	public UIButton EvoPassRuleBtn;

	public GameObject DescContainer;

	public GameObject PurchaseContainer;

	public GameObject OutOfServiceContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

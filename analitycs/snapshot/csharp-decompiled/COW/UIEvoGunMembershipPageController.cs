using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIEvoGunMembershipPageController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
{
	public enum EvoGunMembershipPagePrivilegeType
	{
		None,
		Gun,
		Normal
	}

	private UIEvoGunMembershipPageView m_View;

	private Vector3 PrivilegeItemSize;

	private UITable2.Margin PrivilegeItemOddMargin;

	private UITable2.Margin PrivilegeItemEvenMargin;

	private EVipCard.MembershipRebateType m_CurrentEvoPassType;

	private ClientEvoPassData m_CurrentEvoPassData;

	private UIModelEvoPass m_ModelEvoPass;

	private Dictionary<uint, Transform> m_EvoPassType2TransDic;

	private Dictionary<uint, UIEvoPassTypeBtnController> m_EvoPassType2BtnDic;

	private UIEvoGunMembershipPagePrivilegeGunItemController m_BigAwardItem;

	public bool ChooseSubscription;

	private EVipCard.MembershipRebateType m_SubscribeType;

	private bool m_HasInitToggleBtn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ApplyOutOfServiceLockdown()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnSubscribeCheckBoxBtnClick()
	{
	}

	private void OnEvoPassRuleBtnClick()
	{
	}

	private void OnSubscibeRuleBtnClick()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private void OnPurchaseWndOpen()
	{
	}

	private void OnChooseEvoPassType(uint type)
	{
	}

	private void RequestData()
	{
	}

	private void InitView()
	{
	}

	private void InitTemplate()
	{
	}

	private void RefreshEvoPassAwardList()
	{
	}

	private void OnPurchaseSuccess()
	{
	}

	private void GotoSubscription()
	{
	}

	private void RefreshEvoPassTypeBtn()
	{
	}

	private void RefreshSelectedEvoPassType()
	{
	}

	private void RefreshFirstSubscribeBonus()
	{
	}

	private void ClearAllPurchaseState()
	{
	}

	public override void RefreshContent()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__25_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}

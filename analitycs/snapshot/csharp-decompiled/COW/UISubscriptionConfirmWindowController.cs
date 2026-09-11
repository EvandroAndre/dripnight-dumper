using System;
using GCommon;

namespace COW;

public class UISubscriptionConfirmWindowController : UIPopupWindowController
{
	public enum ButtonStyle
	{
		None,
		OK,
		Confirm_Cancel
	}

	public class SubscriptionConfirmDisplayInfo
	{
		public string Title;

		public string Desc_1;

		public string Desc_2;

		public string Desc_3;

		public string Desc;

		public string SubscriptionProductIdentifier;

		public Action<string> OnOK;

		public bool ShowClose;

		public ButtonStyle ButtonStyle;

		public RebateCardInfo RebateCard;

		public ClientMemberShipCardData MembershipCard;
	}

	private UISubscriptionConfirmWindowView m_View;

	private SubscriptionConfirmDisplayInfo m_Info;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(SubscriptionConfirmDisplayInfo info)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnOKClick()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

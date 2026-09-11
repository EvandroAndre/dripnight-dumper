using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHudUGCPremiumCenterController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIHudUGCPremiumCardItemController cardItem;

		public UIHudUGCPremiumCenterController _003C_003E4__this;

		internal void _003CInitStore_003Eb__0(UIHudUGCPremiumCardItemController item)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIHudUGCPremiumCenterController _003C_003E4__this;

		public bool subscribeEnable;

		public EWorkshop.VIPType subscribeType;

		public int diamondCount;

		public uint price;

		internal void _003COnClickBuyButton_003Eb__0()
		{
		}

		internal void _003COnClickBuyButton_003Eb__1()
		{
		}

		internal void _003COnClickBuyButton_003Eb__2()
		{
		}
	}

	private UIHudUGCPremiumCenterView m_View;

	private UIModelUGCPremium m_PremiumModel;

	private UIModelMall m_MallModel;

	private List<UIHudUGCPremiumCardItemController> m_CardItemList;

	private List<UGCPremiumBenefitData> m_BenefitDataList;

	private UIHudUGCPremiumCardItemController m_CurrentSelectedCardItem;

	private bool m_InGame;

	public UIHudUGCPremiumCardItemController CurrentCardItem
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitStore()
	{
	}

	private void InitBenefitDatas()
	{
	}

	private void OnClickCloseButton()
	{
	}

	private void OnClickHelpButton()
	{
	}

	private void OnClickIntroButton()
	{
	}

	private void OnClickSubscribeHelpButton()
	{
	}

	private void OnSubscibeValueChanged()
	{
	}

	private void OnClickViewMoreButton()
	{
	}

	private void OnClickBuyButton()
	{
	}

	private void OnShowRewardWnd(object[] data)
	{
	}

	private void OnCurrentCardItemChanged()
	{
	}

	private void SendPremiumCenterState(bool state)
	{
	}

	private void RefreshMyVipInfo()
	{
	}

	private void ShowCurrentCardInfo()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnSubscibeValueChanged_003Eb__21_0()
	{
	}

	private void _003COnSubscibeValueChanged_003Eb__21_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

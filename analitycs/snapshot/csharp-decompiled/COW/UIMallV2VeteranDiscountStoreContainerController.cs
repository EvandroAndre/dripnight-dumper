using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallV2VeteranDiscountStoreContainerController : UIBaseController, IUIModelDataChangeObserver
{
	public enum UIMallV2DiscountItemType
	{
		Normal = 1,
		Weapon
	}

	public enum VeteranStoreState
	{
		None,
		Unrewarded,
		Rewarding,
		Rewarded,
		InStore
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__21_0;

		public static OnFinished _003C_003E9__21_1;

		public static OnFinished _003C_003E9__33_0;

		internal void _003CInitState_003Eb__21_0()
		{
		}

		internal void _003CInitState_003Eb__21_1()
		{
		}

		internal void _003CSetViewData_003Eb__33_0()
		{
		}
	}

	private UIMallV2VeteranDiscountStoreView m_View;

	private UICountDownController m_VeteranCountDownStoreCtrl;

	private UICountDownController m_VeteranCountDownCtrl;

	private UIModelVeteran m_ModelVeteran;

	private UIModelMall m_ModelMall;

	private UIEasyListItemController m_CurrentItem;

	private VeteranStoreState m_CurrentState;

	private AudioResource m_LoopAudioSource;

	private string VeteranStoreUnrewardedDiscount;

	private string VeteranStoreUnrewardedTips;

	private string VeteranStoreUnrewardedButtonTips;

	private string VeteranStoreRewardingTips;

	private string VeteranStoreRewardingButtonTips;

	private string VeteranStoreRewardedTips;

	private string VeteranStoreRewardedButtonTips;

	private string VeteranStoreDiscountLabel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnContinueButtonClick()
	{
	}

	private void InitState()
	{
	}

	private void RefreshStateShow()
	{
	}

	internal int GetDataListCount()
	{
		return 0;
	}

	internal void SelectItem(int index, bool force = false)
	{
	}

	private void SetPreviewState()
	{
	}

	public bool SetPreviewStateNavigation()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitShoppingMallItemTemplate()
	{
	}

	private UITable2.IUITable2Item OpenNormalMallItem()
	{
		return null;
	}

	private UITable2.IUITable2Item OpenWeaponMallItem()
	{
		return null;
	}

	internal void HighLightItem(int index)
	{
	}

	public void SetViewData(List<VeteranStoreDesc> veteranStoreDescs)
	{
	}

	public void RefreshTableAndButtonView()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__29_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__29_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

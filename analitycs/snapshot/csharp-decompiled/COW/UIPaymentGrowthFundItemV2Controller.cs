using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentGrowthFundItemV2Controller : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIPaymentGrowthFundItemV2View m_View;

	private PayBundleWindowDesc m_Data;

	private LevelUpPassDesc m_LevelUpPassDesc;

	private UIModelPayment m_ModelPayment;

	private PlayLevelInfo m_Info;

	private EGrowthFundV2ButtonState m_BtnState;

	private List<UIPaymentGrowthFundItemV2ContentItemController> m_GridItemControllers;

	private Transform[] m_ItemRoots;

	private bool m_HasSetPrice;

	private const int MAX_ITEM = 3;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetBundleId()
	{
		return 0u;
	}

	public void PlayUnlockVFX()
	{
	}

	private void UpdateContents()
	{
	}

	private void RefreshProgressBar()
	{
	}

	private void RefreshGrowthFundInfo()
	{
	}

	private void RefreshBundle()
	{
	}

	private void UpdateItemControllers(List<BundleShowData> bundleShowDataList)
	{
	}

	private void ResetItemController()
	{
	}

	private void RefreshButtonView()
	{
	}

	private EGrowthFundV2ButtonState GetButtonState()
	{
		return EGrowthFundV2ButtonState.None;
	}

	private void RefreshPrice()
	{
	}

	private void InitView()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private void OnLockBtnClick()
	{
	}

	private void RefreshCDN()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

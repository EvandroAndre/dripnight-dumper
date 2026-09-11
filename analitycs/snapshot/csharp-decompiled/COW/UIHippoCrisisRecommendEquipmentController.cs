using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHippoCrisisRecommendEquipmentController : UIBaseController
{
	private UIHippoCrisisRecommendEquipmentView m_View;

	private List<HippoCrisisPreSetData> m_Datas;

	private uint m_PresetId;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIHippoCrisisRecommendWeaponItemController m_WeaponCtrl;

	private UIHippoCrisisRecommendEquipmentItemController m_HelmetCtrl;

	private UIHippoCrisisRecommendEquipmentItemController m_VestCtrl;

	private UIHippoCrisisRecommendEquipmentItemController m_BagCtrl;

	private UIHippoCrisisRecommendEquipmentItemController m_SkillChipCtrl;

	private List<UIHippoCrisisInventoryItemController> m_ConsumablesCtrls;

	private bool m_IsFree;

	private uint m_TotalWeight;

	private uint m_ComsumablesTotalWeight;

	private uint m_TotalPrice;

	private uint m_OriginalTotalPrice;

	private uint m_MaxItemWeight;

	private bool m_IsBestOwnedEquipment;

	private IHippoCrisisBackPackItemUIData m_BestWeapon;

	private List<IHippoCrisisBackPackItemUIData> m_NeedAddAttacgments;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(List<HippoCrisisPreSetData> datas)
	{
	}

	public void SetViewDataBestEquipment()
	{
	}

	public void StartGuide()
	{
	}

	public void SetViewDataFree()
	{
	}

	private void OpenEquipItems()
	{
	}

	private void ShowConsumables(HippoCrisisPreSetData data, int index)
	{
	}

	private void RefreshOwnedAndStoreInfo()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void RequestPurchase()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

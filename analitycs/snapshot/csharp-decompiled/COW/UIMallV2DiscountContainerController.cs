using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallV2DiscountContainerController : UIBaseController
{
	public enum UIMallV2DiscountItemType
	{
		Normal = 1,
		Weapon
	}

	private UICountDownController m_DiscountCountDownCtrl;

	private UIMallV2DiscountContainerView m_View;

	private UIModelMall m_ModelMall;

	private UIEasyListItemController m_CurrentItem;

	private DiscountStoreDesc m_FreeStore;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnGifBtnClick()
	{
	}

	private void InitShoppingMallItemTemplate()
	{
	}

	internal void SelectItem(int index, bool force = false)
	{
	}

	internal void HighLightItem(int index)
	{
	}

	public void SetViewData(List<DiscountStoreDesc> storeDescs)
	{
	}

	protected ulong CalculateDiscountRefreshTime()
	{
		return 0uL;
	}

	public override void Hide()
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

	public void RefreshTableView()
	{
	}

	internal int GetDataListCount()
	{
		return 0;
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__9_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__9_1()
	{
		return null;
	}

	private void _003CSetViewData_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}

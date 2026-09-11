using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILegendClothVaultPickItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private ClothVaultData m_Data;

	private UIModelTailor m_ModelTailor;

	private GoPos m_GoPosData;

	private ItemChannelInfo m_ChannelGoposInfo;

	private UILaunchTagFrameController m_LaunchTagCtrl;

	private readonly Vector3 LaunchTagPos_WithoutNumber;

	private UILegendClothVaultPickItemView m_View;

	private UIModelInventory m_ModelInventory;

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

	private void RefreshBottomView()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	private void GoPosButtonOnClick()
	{
	}

	private void ResetRedDot()
	{
	}

	private void ShowLaunchTag()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool _003CSetViewData_003Eb__10_0(AdvertDesc x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}
}

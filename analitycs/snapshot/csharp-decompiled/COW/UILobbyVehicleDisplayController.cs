using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyVehicleDisplayController : UINavigationController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PopMenuData> _003C_003E9__20_0;

		public static Comparison<VehicleDisplayItemData> _003C_003E9__22_0;

		internal int _003CGeneratePopMenuData_003Eb__20_0(PopMenuData a, PopMenuData b)
		{
			return 0;
		}

		internal int _003CSetVehicleList_003Eb__22_0(VehicleDisplayItemData a, VehicleDisplayItemData b)
		{
			return 0;
		}
	}

	private UILobbyVehicleDisplayView m_View;

	private UIModelVehicleDisplay m_Model;

	private UIModelCollection m_ModelCollection;

	private UIPopMenuSmallControler m_PopMenuVehicle;

	private GKEDHMFHDFM m_SelectedData;

	private uint m_CurrentSkinID;

	private List<PopMenuData> m_VehicleTypeFilterPopMenuList;

	private Dictionary<uint, VehicleDisplayItemData> m_VehicleDic;

	private UICommonGuideController m_guideController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAutoRotateClicked()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnGotoShopButtonClick()
	{
	}

	private void OnRemoveButtonClicked()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void GeneratePopMenuData()
	{
	}

	private void OnPopMenuItemSelected(object obj)
	{
	}

	private void SetVehicleList(uint vehicleID)
	{
	}

	private void ChangeVehicle(object[] data)
	{
	}

	private void OnCameraMoveEnd(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}

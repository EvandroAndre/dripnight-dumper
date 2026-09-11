using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILegendClothVaultPickController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<ClothVaultData, uint> _003C_003E9__9_0;

		internal uint _003CRefreshView_003Eb__9_0(ClothVaultData x)
		{
			return 0u;
		}
	}

	private UILegendClothVaultPickView m_View;

	private UIModelInventory m_UIModelInventory;

	private UIModelTailor m_UIModelTailor;

	private List<ClothVaultData> m_PickItemsList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshView()
	{
	}

	private void RefreshItemsList()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}

using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewPrivilegeContainerController : UIBaseController
{
	private UIFrontEndPreviewPrivilegeContainerView m_View;

	private List<UIPrivilegeItemIconController> m_PrivilegeIcons;

	private List<ResourceID> m_PrivilegeSpritesResId;

	private ResourceID m_IpSpritesResId;

	private FrontendPreviewType m_PreviewType;

	private UIModelWeaponSkinUpgrader m_modelWeaponSkinUpgrader;

	private UIModelCollectionCustom m_modelCollectionCustom;

	private List<WeaponSkinUpgradeInfoData> m_WeaponSkinUpgradeInfoDatas;

	private List<FinalShotSkinUpgradeInfoData> m_FinalShotSkinUpgradeInfoDatas;

	public uint CurrentItemID;

	private uint m_BundleIpItemId;

	private const int MaxPrivilegeNum = 8;

	private const int OneLinePrivilegeNum = 4;

	private const int MaxPrivilegeNumWithIptag = 5;

	private int m_paddingX;

	private int m_paddingY;

	private int m_HeightWithIpTag;

	private int m_height;

	private bool m_HasCollectionCustomPrivilege;

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

	public void SetData(uint itemId)
	{
	}

	public void SetAnchor(Transform obj, int topOffset = 0)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public int GetPrivilegeIconCount()
	{
		return 0;
	}

	private void RefreshPrivilegeGrid()
	{
	}

	public void SetIpTagPrivilegeIcon()
	{
	}

	public void SetCollectionCustomPrivilegeIcon()
	{
	}

	public void SetWeaponPrivilegeGrid()
	{
	}

	private void OnWeaponPrivilegeClick(int index)
	{
	}

	private int GeteventClothesEffectsCount(uint clothId)
	{
		return 0;
	}

	private void CheckItemHasMultipleEffect(ref bool hasMultipleEffect, ref bool hasFootPrintEffect)
	{
	}

	private void CheckItemHasMultipleEffectInternal(uint id, ref bool hasMultipleEffect, ref bool hasFootPrintEffect)
	{
	}

	private bool HasKillAndBeKilledSpecialEffect(List<EventClothEffectsData> eventClothesEffects)
	{
		return false;
	}

	public void SetClothesPrivilegeGrid()
	{
	}

	private void OnClothesPrivilegeClick(int index)
	{
	}

	public void SetBundlePrivilegeGrid()
	{
	}

	private void OnBundlePrivilegeClick(int index)
	{
	}

	public void SetTransformPrivilegeGrid()
	{
	}

	private void OnTransformPrivilegeClick(int index)
	{
	}

	public void SetSuperEmotePrivilegeGrid()
	{
	}

	private void OnSuperEmotePrivilegeClick(int index)
	{
	}

	private void OnFinishMovePrivilegeClick(int index)
	{
	}

	private void OnFinalShotPrivilegeClick(int index)
	{
	}

	public void SetEmotePrivilegeGrid()
	{
	}

	private void OnEmotePrivilegeClick(int index)
	{
	}

	public void SetFlightPrivilegeGrid()
	{
	}

	private void OnFlightPrivilegeClick(int index)
	{
	}

	public void SetBackpackPrivilegeGrid()
	{
	}

	private void SetLootBoxPrivilegeGrid()
	{
	}

	private void SetVehicleSkinPrivilegeGrid()
	{
	}

	private void SetSkyboardPrivilegeGrid()
	{
	}

	private void SetGroupAnimPrivilegeGrid()
	{
	}

	private void SetFinishMovePrivilegeGrid()
	{
	}

	private void SetFinalShotPrivilegeGrid()
	{
	}

	private void AddVehicleSkinPrivilegeIcon(ResourceID privilegeRes, CollectionPrivilegeTagType privilegeType)
	{
	}

	private void AddVehicleSkinPrivilegeInfo(ResourceID privilegeRes, CollectionPrivilegeTagType privilegeType, List<ResourceID> spritesResId, List<string> descList)
	{
	}

	private void AddNewMatTypePrivilegeToList(uint newMatType, List<ResourceID> list)
	{
	}

	private void OnBackpackPrivilegeClick(int index)
	{
	}

	private void OnLootBoxPrivilegeClick(int index)
	{
	}

	private void OnVehicleSkinPrivilegeClick(int index)
	{
	}

	private void OnSkyboardPrivilegeClick(int index)
	{
	}

	private void OnGroupAnimPrivilegeClick(int index)
	{
	}

	private void OnIpTagPrivilegeClick(int index)
	{
	}

	private void OnPrivilegeGridClick(int index)
	{
	}

	public void SetPrivilegeGridShow()
	{
	}

	public void SetPreviewType(FrontendPreviewType previewType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

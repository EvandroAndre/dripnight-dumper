using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIWeaponSkinPokedexController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	public enum PokedexItemTemplateType
	{
		WeaponSkin,
		NoSplitLine,
		LimitedSplitLine,
		PastDueSplitLine
	}

	public class PokedexQualityMenuData
	{
		public CSSharedItemDataManager.StoreQuality quality;

		public string name;

		public int count;

		public Color qualityColor;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__24_0;

		public static Comparison<PopMenuData> _003C_003E9__25_0;

		internal int _003CGenerateWeaponTypeFilterData_003Eb__24_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CGenerateWeaponModelFilterData_003Eb__25_0(PopMenuData a, PopMenuData b)
		{
			return 0;
		}
	}

	private UIWeaponSkinPokedexView m_View;

	private UIModelWeaponSkinPokedex m_ModelWeaponSkinPokedex;

	private UIPopMenuSmallControler m_WeaponTypeFilterPopMenu;

	private UIPopMenuSmallControler m_WeaponModelFilterPopMenu;

	private Dictionary<uint, string> m_OwnerStateName;

	private CSSharedItemDataManager.StoreQuality m_CurrentQuality;

	private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

	private uint m_CurrentFilterWeaponModel;

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

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void PokedexShareBtnOnClick()
	{
	}

	private void ModelFilterTipsBtnOnClick()
	{
	}

	private void RefreshPokedexQualityMenu()
	{
	}

	private PokedexQualityMenuData InitPokedexQualityMenuData(CSSharedItemDataManager.StoreQuality quality, Color qualityColor, string name = "")
	{
		return null;
	}

	private void OnPokedexQualityItemSelected(object[] data)
	{
	}

	private void GenerateWeaponTypeFilterData()
	{
	}

	private void GenerateWeaponModelFilterData()
	{
	}

	private void ConductFilterByWeaponType(object data)
	{
	}

	private void ConductFilterByWeaponId(object data)
	{
	}

	private void RefreshCurrentFilterWeaponType(CollectionDataManager.ECollectionWeaponType selectType)
	{
	}

	private void RefreshCurrentFilterWeaponModel(uint selectModel)
	{
	}

	private void RefreshPokedexItem()
	{
	}

	private void RefreshPokedexTable(List<WeaponPokedexDesc> permanentList, List<WeaponPokedexDesc> limitedList, List<WeaponPokedexDesc> pastDueList)
	{
	}

	private void AddItemsToPokedexTable(List<WeaponPokedexDesc> list, PokedexItemTemplateType splitLineType = PokedexItemTemplateType.NoSplitLine)
	{
	}

	private void InitPokedexItemTemplate()
	{
	}

	private UIWeaponSkinPokedexItemController OpenPokedexItem()
	{
		return null;
	}

	private void RefreshEvoGunPokedexDesc(object[] data)
	{
	}

	private UITable2.IUITable2Item _003CInitPokedexItemTemplate_003Eb__33_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPokedexItemTemplate_003Eb__33_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPokedexItemTemplate_003Eb__33_2()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}

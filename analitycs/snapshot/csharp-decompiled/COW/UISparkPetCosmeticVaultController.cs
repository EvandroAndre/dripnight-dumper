using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetCosmeticVaultController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	public enum ESparkPetCosmeticListType
	{
		Header = 1,
		Content
	}

	private Transform m_ParentTransform;

	private UISparkPetCosmeticVaultView m_View;

	private UIModelSparkPet m_ModelSparkPet;

	private Dictionary<int, int> m_CosmeticCategoryTabCtrlIndexDict;

	private Dictionary<int, int> m_CosmeticCategoryHeaderCtrlIndexDict;

	private Dictionary<int, Dictionary<uint, int>> m_CosmeticItemCtrlIndexDict;

	private ESparkPetCosmeticType m_CurrentSelectedCosmeticType;

	private List<int> m_HeaderItemIndexList;

	private List<int> m_CategoryBoundsIndices;

	private UITable2VirtualBoundsHelper m_Table2VirtualBoundsHelper;

	private bool m_CanUpdateChangeTab;

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

	private void InitVirtualBoundsHelper()
	{
	}

	private void Update()
	{
	}

	private void UpdateChangeTab()
	{
	}

	private void SelectTabByIndex(int categoryIndex)
	{
	}

	private void SelectTabByType(ESparkPetCosmeticType cosmeticType)
	{
	}

	private void InitUI()
	{
	}

	private void InitCategoryTabs()
	{
	}

	private void InitCosmeticListContent()
	{
	}

	private void OnItemClicked(object[] objects)
	{
	}

	private void OnTabClicked(uint type)
	{
	}

	private void OnBackClick()
	{
	}

	private void CloseWithEvent()
	{
	}

	public void SetParentTransform(Transform parentTransform)
	{
	}

	public void SetContainerPosition(Vector3 position)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private UITable2.IUITable2Item _003COnUIInit_003Eb__13_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003COnUIInit_003Eb__13_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

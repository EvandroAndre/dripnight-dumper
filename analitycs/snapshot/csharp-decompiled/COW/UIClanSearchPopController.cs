using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanSearchPopController : UIPopupWindowController
{
	private const string m_DefaultText = "TXT_SETTING_AIDER_ALLON";

	protected UIClanSearchPopView m_View;

	protected UIModelClan m_ModelClan;

	protected UIModelLeaderBoard m_ModelLeaderBoard;

	private Dictionary<uint, List<ClanTagData>> m_DictTypeToData;

	private Dictionary<uint, UIClanTagItemController> m_DictSingleSelectTag;

	private Dictionary<uint, UIClanTagItemController> m_DictMultiSelectTag;

	protected UIPopMenuSmallControler m_SelectRegionCountryPopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_SelectRegionProvincePopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_SelectRegionCityPopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_SelectApprovalModePopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_SelectClanLevelPopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_SelectActivitiesPopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_SelectMainTagPopMenuSmallCtrl;

	private uint m_AreaCountryId;

	private uint m_AreaProvinceId;

	private uint m_AreaCityId;

	private uint m_AreaId;

	private EClanApproval m_ApprovalState;

	private uint m_ClanLevel;

	private uint m_MainTag;

	private uint m_ActivitiesTag;

	private List<uint> m_Tags;

	private string m_InRegionText;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetData(UIWidget widget, uint areaId)
	{
	}

	protected override void OnUIInit()
	{
	}

	private void InitPopMenus()
	{
	}

	private void InitTags()
	{
	}

	private void InitData()
	{
	}

	private void InitView()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void GenerateCountryMenuData()
	{
	}

	private void OnCountrySelected(object obj)
	{
	}

	protected void GenerateProvinceMenuData()
	{
	}

	private void OnProvinceSelected(object obj)
	{
	}

	protected void GenerateCityMenuData()
	{
	}

	private void OnCitySelected(object obj)
	{
	}

	protected void GenerateApprovalMenuData()
	{
	}

	private void OnApprovalSelected(object obj)
	{
	}

	private void GenerateLevelMenuData()
	{
	}

	private void OnLevelSelected(object obj)
	{
	}

	private void GenerateMainTagData()
	{
	}

	private void OnMainTagSelected(object obj)
	{
	}

	private void GenerateActivitiesData()
	{
	}

	private void OnActivitiesSelected(object obj)
	{
	}

	private void OnTagSelected(object[] data)
	{
	}

	private void OnSearchClick()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}

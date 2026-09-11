using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITitleShowController : UIBaseController, IEasyList
{
	private uint _003CSelectedTitleId_003Ek__BackingField;

	private uint _003CPendingToShowId_003Ek__BackingField;

	private TitleInfo m_SelectedInfo;

	private TitleInfo m_PendingInfo;

	private ETitleBtnState m_TitleBtnState;

	private UIModelCollection m_ModelCollection;

	private UITitleShowView m_View;

	private UIProfilePlayerPreferenceSettingPopWndController m_parent;

	private UIModelAchievement m_ModelAchievement;

	private UIPopMenuSmallControler m_QualityFilterCtrl;

	private List<PopMenuData> m_QualityFilterPopDatas;

	private int m_CurrentQualityFilterType;

	private int m_FilterTitleLeftAnchor;

	private HashSet<int> m_AvailableQualityTypes;

	private Dictionary<int, string> m_QualityFilterKeyDict;

	private Dictionary<int, uint> m_QualityFilterColorDict;

	public uint SelectedTitleId
	{
		get
		{
			return _003CSelectedTitleId_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedTitleId_003Ek__BackingField = value;
		}
	}

	public uint PendingToShowId
	{
		get
		{
			return _003CPendingToShowId_003Ek__BackingField;
		}
		private set
		{
			_003CPendingToShowId_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetParent(UIProfilePlayerPreferenceSettingPopWndController parent)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitPendingToShowId()
	{
	}

	private void InitTitleShowPanel()
	{
	}

	public void OnTitleItemClick(TitleInfo info)
	{
	}

	private void OnTitleBtnClick()
	{
	}

	private void RefreshTitleDesc()
	{
	}

	private void RefreshItemView()
	{
	}

	private void RefreshTitleBtnView()
	{
	}

	private void InitTitleBtnState()
	{
	}

	private void ChangeTitleBtnState()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void SetQualityFilter(int currentQualityFilterType)
	{
	}

	private void UpdateAvailableQualityTypes()
	{
	}

	private void OnQualityFilterClick()
	{
	}

	private void OnQualityTypeSelected(object obj)
	{
	}

	public int GetItemQualityFilterType(byte quality)
	{
		return 0;
	}

	public int GetItemClassTypeFilterType(uint classType)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIAchievementAwardWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public RuleMapping rule;

		internal bool _003COnTabSelected_003Eb__0(RuleMapping tabData)
		{
			return false;
		}
	}

	private List<RuleMapping> m_TabDataList;

	private UIAchievementAwardWndView m_View;

	private UIModelAchievement m_ModelAchievement;

	private int m_TabIndex;

	private bool m_OnlyRefreshTabView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitTabViewData()
	{
	}

	private int RefreshTabViewData()
	{
		return 0;
	}

	public void SetViewData(EAchievement.Type achType)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SelectItem(int index)
	{
	}

	private void OnTabSelected(object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

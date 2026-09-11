using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UICommonSettingContentController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public int type;

		internal bool _003CGetItemCtrlByType_003Eb__0(UICommonSettingItemBaseController c)
		{
			return false;
		}
	}

	protected UICommonSettingContentView m_View;

	protected CommonSettingContentData m_Data;

	protected List<UICommonSettingItemBaseController> m_CtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CommonSettingContentData ContentData)
	{
	}

	protected virtual void UpdateWidgetBounds()
	{
	}

	private void CreateItemController(CommonSettingItemDataBase itemData, int key)
	{
	}

	public void RefreshData(CommonSettingContentData ContentData)
	{
	}

	public void RefreshContent()
	{
	}

	public void RefreshTipsState()
	{
	}

	public UICommonSettingItemBaseController GetItemCtrlByType(int type)
	{
		return null;
	}

	private void _003CSetViewData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

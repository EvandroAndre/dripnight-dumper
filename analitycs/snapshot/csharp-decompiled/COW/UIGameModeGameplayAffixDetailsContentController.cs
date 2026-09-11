using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGameModeGameplayAffixDetailsContentController : UIBaseController, IDynamicLayoutDetailTipsContent
{
	public class InstantiationContext : IDisposable
	{
		public InstantiationContext(ResourceID resID)
		{
		}

		public void Dispose()
		{
		}
	}

	private static ResourceID m_ResourceID;

	private const int m_DisplayedDropdownItemCountLimit = 4;

	private const int m_DropdownItemPaddingY = 5;

	private const int m_DragRegionPaddingY = 2;

	private UIGameModeGameplayAffixDetailsContentView m_View;

	private readonly List<UIGameModeGameplayAffixDetailsDropdownItemController> m_DropdownItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void PopulateContent(object viewData)
	{
	}

	public void RebuildLayout()
	{
	}

	private void SetupDefaultContent()
	{
	}

	private void SetTimeRangeLabel(GameplayAffixEventData gameplayAffixEventData)
	{
	}

	private void PopulateDetailsTable(GameplayAffixEventData gameplayAffixEventData)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

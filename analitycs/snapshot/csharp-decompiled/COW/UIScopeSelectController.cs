using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIScopeSelectController : UIBaseController
{
	private const int BgPaddingX = 2;

	private const int BgPaddingY = 2;

	private UIScopeSelectView m_View;

	private List<UIScopeSelectItemController> m_ItemCtrls;

	private uint m_SelectedScopeId;

	private Action<uint> m_OnScopeSelected;

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

	public void InitScopeList(List<uint> scopeAttachmentIds, uint selectedScopeId, Action<uint> onScopeSelected)
	{
	}

	public uint GetSelectedScopeId()
	{
		return 0u;
	}

	private void OnItemSelected(uint scopeId)
	{
	}

	private void RefreshItemStates()
	{
	}

	private void ClearItems()
	{
	}

	private void RefreshBackgroundSize(int itemCount)
	{
	}

	private static string GetScopeLabelName(uint scopeId)
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

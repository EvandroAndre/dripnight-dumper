using System;
using GCommon;

namespace COW;

public class UIScopeSelectItemController : UIBaseController
{
	private UIScopeSelectItemView m_View;

	private uint m_ScopeAttachmentId;

	private Action<uint> m_OnSelected;

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

	public void SetData(uint scopeAttachmentId, string label, bool isSelected, Action<uint> onSelected)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	public uint GetScopeAttachmentId()
	{
		return 0u;
	}

	private void OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

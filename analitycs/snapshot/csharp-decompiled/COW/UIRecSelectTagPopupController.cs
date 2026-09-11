using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIRecSelectTagPopupController : UIPopupWindowController
{
	private UIRecSelectTagPopupView m_View;

	private UIModelLoadout m_ModelLoadout;

	private int m_PlanIndex;

	private uint m_tagLimit;

	private Dictionary<uint, UIRecSelectTagItemController> m_TagControllerList;

	private List<uint> m_SelectedTags;

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

	private void InitAllTags()
	{
	}

	private void RefreshView()
	{
	}

	public void SetData(int planIndex)
	{
	}

	private void OnClickTag(uint index)
	{
	}

	private void OnClickConfirm()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

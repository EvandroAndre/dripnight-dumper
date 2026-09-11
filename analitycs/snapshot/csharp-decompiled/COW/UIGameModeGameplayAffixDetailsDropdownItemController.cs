using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeGameplayAffixDetailsDropdownItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIGameModeGameplayAffixDetailsDropdownItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	public void SetViewData(ResourceID spriteResID, string titleContent, string descContent)
	{
	}

	public int GetBoundsHeight()
	{
		return 0;
	}

	public void SetViewData(object data)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeNewPlayerUnlockFeatureItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIGameModeNewPlayerUnlockFeatureItemView m_View;

	private uint m_MatchMode;

	private uint m_GameMode;

	private uint m_AffixID;

	private UIModelNewPlayerUnlockFeature m_ModelUnlockFeature;

	private string m_CurCDN;

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

	private void OnDetailBtnClick()
	{
	}

	public void SetViewData(object data)
	{
	}

	public void RefreshUnLockState()
	{
	}

	private void SetUnlockConditionView()
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

	private bool _003COnDetailBtnClick_003Eb__9_0(string x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

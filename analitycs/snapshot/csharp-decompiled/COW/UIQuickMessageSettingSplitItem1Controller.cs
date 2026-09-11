using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageSettingSplitItem1Controller : UIBaseController, UITable2.IUITable2Item
{
	private UIQuickMessageSettingSplitItem1View m_View;

	private UIQuickMessageSettingController m_ParentCtrl;

	private uint m_SplitLabelNormalColor;

	private uint m_SplitLabelHighLightColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
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

	private void RefreshUI(object data)
	{
	}

	private void RefreshUI(SplitlineQuickChatData data)
	{
	}

	private void SetSplitLabelColor(EQuickChatMainTab maintab, uint groupId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}

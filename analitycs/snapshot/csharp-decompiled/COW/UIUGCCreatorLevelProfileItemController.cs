using System;
using GCommon;

namespace COW;

public class UIUGCCreatorLevelProfileItemController : UIBaseController
{
	private UIUGCCreatorLevelProfileItemView m_View;

	private uint m_Level;

	private Action<uint> m_OnClick;

	private bool m_IsUserSelf;

	private bool m_IsSelected;

	private UIUGCCreatorLevelIconController m_CreatorLevelIconCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetData(WorkShopCreatorLevel levelInfo, uint selectedLevel, uint currentLevel, bool IsUserSelf, Action<uint> onClick)
	{
	}

	public void RefreshRedPoint()
	{
	}

	private void OnIconBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

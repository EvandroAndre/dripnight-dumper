using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCCreatorLevelUpController : UIPopupWindowController
{
	private UIUGCCreatorLevelUpView m_View;

	private readonly List<UIUGCCreatorLevelProfileAbilityItemController> m_CacheItemList;

	private UIModelCraftlandProfile m_ModelCraftlandProfile;

	private WorkShopCreatorLevel m_WorkShopCreatorLevel;

	private uint m_CurrentLevel;

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

	protected override void OnUIDestory()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void OnProcessAnimEvt(object[] data)
	{
	}

	public void SetData(WorkShopCreatorLevel workShopCreatorLevel, uint lastPopupLevel)
	{
	}

	private void RefreshGrid(uint lastPopupLevel)
	{
	}

	private int ComparePrivilegeWeight(WorkshopCreatorPrivilegeWarp a, WorkshopCreatorPrivilegeWarp b)
	{
		return 0;
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

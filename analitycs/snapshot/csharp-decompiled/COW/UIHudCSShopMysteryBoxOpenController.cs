using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIHudCSShopMysteryBoxOpenController : UIBaseController
{
	private UIHudCSShopMysteryBoxOpenView m_View;

	private List<UIToggleButton> m_ListToggles;

	private uint m_SelectedBoxItemID;

	private uint m_SelectedBoxUniqueID;

	private UIHudCSMysteryBoxOptionItemView.MysterBoxData m_MysteryBoxData;

	private List<UIHudCSMysteryBoxOptionItemView.MysterBoxData> m_OptionItemsDataList;

	private UIHudCommonlTipsController m_CurrentTips;

	private UITimeLabelHelper m_TimeHelper;

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

	protected override void OnUIClose()
	{
	}

	private void Update()
	{
	}

	public void SetUIData(List<FNOONHDEHEA> data, float duration)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnOptionItemSelected(object[] data)
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void AutoChooseOption()
	{
	}

	public void OnTimeUp()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}

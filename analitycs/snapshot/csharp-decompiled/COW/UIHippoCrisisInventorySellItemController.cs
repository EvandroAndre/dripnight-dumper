using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisInventorySellItemController : UIEasyListItemController
{
	private UIHippoCrisisInventorySellItemView m_View;

	private HippoCrisisOutGameItemUIData m_Data;

	private bool m_IsSelect;

	private uint m_SelectCnt;

	private uint m_MaxCnt;

	private UIHippoCrisisInventoryItemController m_Ctrl;

	private HENEHAGJCLI m_Itemdata;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnMinusBtnClick()
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnSliderValueChange()
	{
	}

	private void SetModifyBtnView()
	{
	}

	private void SetMinBtnView()
	{
	}

	private void SetPlusBtnView()
	{
	}

	private void OnSelectedBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

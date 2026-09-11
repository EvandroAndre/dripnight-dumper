using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISelectLanguageController : UIPopupWindowController
{
	private UISelectLanguageView m_View;

	private LocLang m_SelectedLan;

	private List<UISelectLangItemController> m_ToggleItemList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void HideBtnUI()
	{
	}

	private void OnLocLanConfirm()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetUnLimitedData(PopMenuData data, int GroupID)
	{
	}

	public void SetDatas(List<PopMenuData> dataList, int GroupID)
	{
	}

	private void ReFreshToggles()
	{
	}

	public void SetLanSelect(LocLang lan)
	{
	}

	private void _003COnLocLanConfirm_003Eb__6_0()
	{
	}

	private void _003COnLocLanConfirm_003Eb__6_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}

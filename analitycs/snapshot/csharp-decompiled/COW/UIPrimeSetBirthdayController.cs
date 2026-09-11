using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPrimeSetBirthdayController : UIPopupWindowController
{
	private UIPrimeSetBirthdayView m_View;

	private UIPopMenuSmallControler m_PopMenuMonth;

	private UIPopMenuSmallControler m_PopMenuDay;

	private static readonly Dictionary<int, string> m_DicMonthNames;

	private int m_CurrentSelectedMonth;

	private int m_CurrentSelectedDay;

	private List<PopMenuData> m_MonthDataList;

	private List<PopMenuData> m_DayDataList;

	private static readonly Dictionary<int, int> m_DicMonthDays;

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

	private void SetViewData()
	{
	}

	private void CreatePopMenus()
	{
	}

	private void GenerateMonthMenuData()
	{
	}

	private void GenerateDayMenuData()
	{
	}

	private void OnMonthSelected(object data)
	{
	}

	private void OnDaySelected(object data)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void _003COnConfirmBtnClick_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

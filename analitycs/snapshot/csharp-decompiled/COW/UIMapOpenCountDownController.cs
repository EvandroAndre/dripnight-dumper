using System;
using GCommon;

namespace COW;

public class UIMapOpenCountDownController : UIBaseController
{
	private UIMapOpenCountDownView m_View;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private uint m_CountDown;

	private DateTime m_EndDate;

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

	public void SetData(MapOpeningInfo mapInfo)
	{
	}

	private void UpdateTime()
	{
	}

	private void ShowTime(int days, int hours, int minutes, int seconds)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

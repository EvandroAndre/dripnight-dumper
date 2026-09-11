using System.Collections.Generic;
using GCommon;

namespace COW;

public class AutoPopupWindowDataManager : SingletonModule<AutoPopupWindowDataManager>
{
	private int strategy;

	private List<AutoPopupWindowCtrlData> m_Data;

	private string AutoPopupWindowStrategy => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public int LevelLimit(AutoPopupWindowID windowID)
	{
		return 0;
	}

	public int RegDayLimit(AutoPopupWindowID windowID)
	{
		return 0;
	}
}

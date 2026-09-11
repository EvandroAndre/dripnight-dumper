using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPopMenuLeaderBoardControler : UIPopMenuSmallControler
{
	private Func<FilterData, List<PopMenuData>> DataInjectWithParams;

	private FilterData FilterData;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitPopMenu(Func<FilterData, List<PopMenuData>> injectDataListAction, FilterData filterData, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true, NGUIText.Alignment alignment = NGUIText.Alignment.Automatic)
	{
	}

	protected override bool CallDataInject()
	{
		return false;
	}

	public PopMenuData FindPopMenuData(string filter)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_CallDataInject()
	{
		return false;
	}
}

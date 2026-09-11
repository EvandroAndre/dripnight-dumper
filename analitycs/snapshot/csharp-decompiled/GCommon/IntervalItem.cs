using System;
using System.Collections.Generic;

namespace GCommon;

public class IntervalItem
{
	public UIEasyListItemController[] ItemCachedCtrls;

	public List<object> Datalist;

	public int TotalItemCnt;

	public float LineCountPerPage;

	public Func<int, float, bool> ScrollTo;

	public int Columns;

	public IntervalItem(UIEasyListItemController[] itemCachedCtrls, List<object> dataList, int totalItemCnt, float lineCountPerPage, Func<int, float, bool> scrollTo, int columns)
	{
	}
}

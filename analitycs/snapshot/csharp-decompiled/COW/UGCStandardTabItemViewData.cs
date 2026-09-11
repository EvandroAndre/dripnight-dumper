using System;
using System.Collections.Generic;

namespace COW;

public class UGCStandardTabItemViewData
{
	public string key;

	public string tabName;

	public Action onClick;

	public object extraPara;

	public bool visiable;

	public bool isSelected;

	public List<UGCStandardTabItemViewData> subTabs;

	public UIUGCStandardTabBaseItemController tabCtrl;

	public bool inAnim;

	public UGCStandardTabItemViewData(string key, string tabName, List<UGCStandardTabItemViewData> subTabs, Action onClick = null, object extraPara = null, bool visiable = true)
	{
	}
}

using System;

namespace COW;

public class StandardSubTabItemViewData
{
	public string tabName;

	public ETipsType tipType;

	public EEventTag eventTag;

	public Action onClick;

	public object extraPara;

	public bool hasRedPoint;

	public bool useNewRedPoint;

	public Action onTipChange;

	public Func<bool, bool> canClick;

	public Func<bool> canShow;

	public StandardSubTabItemViewData(string tabName, ETipsType tipType = ETipsType.None, EEventTag eventTag = EEventTag.NONE, Func<bool, bool> canClick = null, Func<bool> canShow = null)
	{
	}
}

using System;

namespace COW;

public class StandardTabItemViewData
{
	public enum StandardTabType
	{
		Normal,
		ClanWar,
		Member,
		ClanActive
	}

	public string tabName;

	public string tabBgName;

	public string selectSpriteName;

	public ETipsType tipType;

	public EEventTag eventTag;

	public Action onClick;

	public bool hasRedPoint;

	public object extraPara;

	public bool clearTagOnClick;

	public Func<bool> canClick;

	public StandardTabType standardTabType;

	public ulong countDowntEndTime;

	public bool IsAlwaysShowSubItem;

	public bool useNewTabCountDown;

	public bool shortDisplay;

	public StandardTabItemViewData(string tabName, ETipsType tipType = ETipsType.None, EEventTag eventTag = EEventTag.NONE, string tabSpriteName = "", Action onClick = null, object extraPara = null, Func<bool> canClick = null, string selectSpriteName = "")
	{
	}
}

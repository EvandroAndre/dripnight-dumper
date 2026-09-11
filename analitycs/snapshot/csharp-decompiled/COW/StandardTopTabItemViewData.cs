using System;
using UnityEngine;

namespace COW;

public class StandardTopTabItemViewData
{
	public string tabName;

	public string tabIconName;

	public string selectIconName;

	public string unSelectIconName;

	public string tabNameColor;

	public bool changeSelectedNameColorOnly;

	public ETipsType tipType;

	public Action onClick;

	public object extraPara;

	public Color SelectIconColor;

	public bool textCentered;

	public bool hideUnSelectLine;

	public Func<bool> CheckCanClick;

	public Vector3 TabIconScale;

	public bool showNotice;

	public string noticeText;

	public uint noticeBg02Color;

	public uint noticeTextColor;

	public bool showNoticeBg;

	public bool ShowLine;

	public string iconCdnUrl;

	public string selectBgCdnUrl;

	public StandardTopTabItemViewData(string tabName, string tabIconName, ETipsType tipType = ETipsType.None)
	{
	}
}

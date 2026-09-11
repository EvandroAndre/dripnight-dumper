using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomDropListTemplateController : UIBaseController
{
	public delegate List<PopMenuData> OnDropBtnClick();

	private UIRoomDropListTemplateView m_View;

	private OnDropBtnClick m_OnDropBtnClickCallback;

	private UIPopMenuSmallControler m_PopMenuSmallControler;

	private int m_BaseDepth;

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

	public void SetDropListInfoAndDefault(string labelTxt, OnDropBtnClick callback, string text, float maxCnt = 4.5f)
	{
	}

	public void SetDropListInfo(string labelTxt, OnDropBtnClick callback, float maxCnt = 4.5f, float popMenuOffset = 346f, int popMenuWidth = 260, UIModelCustomRoom.ECustomRoomGameSetting setting = UIModelCustomRoom.ECustomRoomGameSetting.None, PopUpStyle style = PopUpStyle.Down)
	{
	}

	public void SetEnabled(bool enabled)
	{
	}

	public void SetDropListDepth(int depth)
	{
	}

	public void SetSelectedText(string txt)
	{
	}

	protected override T OpenChildController<T>(Transform parent, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
	{
		return null;
	}

	private void _003CSetDropListInfoAndDefault_003Eb__8_0()
	{
	}

	private void _003CSetDropListInfo_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

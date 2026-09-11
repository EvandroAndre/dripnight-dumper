using System;
using GCommon;
using proto;

namespace COW;

public class UIRoomToggleBtnTemplateController : UIBaseController
{
	private UIRoomToggleBtnTemplateView m_View;

	private Action m_EnableClickCallback;

	private Action m_DisableClickCallback;

	private string m_HelpKey;

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

	public void SetToggleBtnInfo(bool initEnabled, string labelTxt, string enabledTxt = "TXT_OB9_ZJS_ROOM_WATCH_SWITCH_YES", string disabledTxt = "TXT_OB9_ZJS_ROOM_WATCH_SWITCH_NO", string helpKey = "", UIModelCustomRoom.ECustomRoomGameSetting setting = UIModelCustomRoom.ECustomRoomGameSetting.None)
	{
	}

	public void RegisterCallBack(Action enableCB, Action disableCB)
	{
	}

	public void UpdateHelpKey(string helpKey)
	{
	}

	private void OnEnabledClick()
	{
	}

	private void OnDisabledClick()
	{
	}

	private void OnHelpClick()
	{
	}

	public void ChooseFirst(bool first)
	{
	}

	public void SetEnabled(bool enabled)
	{
	}

	public void SetStates(ERoom.DropPresetState state)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

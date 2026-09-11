using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomModeSelectPopupWindowController : UIPopupWindowController, IEasyList
{
	private UIRoomModeSelectPopupWindowView m_View;

	private List<UIRoomModeSelectPopupItemController> m_GroupModes;

	private UIWidget m_PasswordWidget;

	private UIWidget m_SimulatorWidget;

	private List<string> m_PasswordIDs;

	private List<string> m_SimulatorIDs;

	private List<string> m_PasswordAllIDs;

	private List<string> m_SimulatorAllIDs;

	private List<MultiPopMenuListData> m_PopMenuListPasswords;

	private List<MultiPopMenuListData> m_PopMenuListSimulators;

	private static bool[] m_LastSelectGameModes;

	private static int m_LastSelectPasswordIndex;

	private static int m_LastSelectSimulatorIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static void ClearSavedData()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void OnCountDownStarted()
	{
	}

	public void OnCountDownUpdate(string countDownTxt)
	{
	}

	public void OnCountDownFinished()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void UpdateGroupMode()
	{
	}

	public void OnClickPassword()
	{
	}

	private void UpdatePasswordView()
	{
	}

	public void OnClickSimulator()
	{
	}

	private void UpdateSimulatorView()
	{
	}

	private void OnClickApplyBtn()
	{
	}

	private void _003COnClickPassword_003Eb__23_0(List<string> ids)
	{
	}

	private void _003COnClickSimulator_003Eb__25_0(List<string> ids)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

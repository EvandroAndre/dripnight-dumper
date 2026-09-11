using GCommon;
using UnityEngine;

namespace COW;

internal class UIDebugInfoController : UISettingContentBase
{
	private UIDebugSettingView m_View;

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

	private void OnDebugUIClick()
	{
	}

	private void OnDebugSamoNavPathClick()
	{
	}

	private void OnDebugSamoDebugInfoClick()
	{
	}

	private void OnDebugInfoClick()
	{
	}

	private void OnlyShowRemoteConsoleContainer()
	{
	}

	private void OnBEDEBUGChange()
	{
	}

	private void OnTestChangeClothCheckBox()
	{
	}

	private void OnTestAutoChangeClothCheckBox()
	{
	}

	private void OnRemoteConsoleToggleChange()
	{
	}

	private void OnRemoteConsoleBtnClick()
	{
	}

	private void InitLogLevels()
	{
	}

	private void OnLogLevelChange()
	{
	}

	private LogType GetLogLevelInSetting()
	{
		return LogType.Error;
	}

	private LogType GetLogLevelInToggles(LogType defaultVal)
	{
		return LogType.Error;
	}

	private void OnClickMobileMatchResultBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

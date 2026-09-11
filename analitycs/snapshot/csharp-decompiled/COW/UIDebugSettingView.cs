using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugSettingView : UIBaseView
{
	public UIToggle DebugUIOn;

	public UIToggle DebugUIOff;

	public UIToggle DebugInfoOn;

	public UIToggle DebugInfoOff;

	public GameObject LogLevel;

	public UIToggle LogLevelAll;

	public UIToggle LogLevelError;

	public UIToggle LogLevelNone;

	public GameObject PCHideContainer;

	public UICheckboxButton TestChangeClothCheckBox;

	public UICheckboxButton TestAutoChangeClothCheckBox;

	public UIToggle RemoteConsoleOn;

	public GameObject RemoteConsoleInputContainer;

	public UIInput RemoteConsoleInput;

	public UIButton RemoteConsoleBtn;

	public UILabel RemoteConsoleBtnLabel;

	public UICheckboxButton BEDEBUGCheckBox;

	public UIButton matchresult;

	public GameObject DebugUI;

	public GameObject DebugInfoOpen;

	public GameObject TestChangeCloth;

	public GameObject TestAutoChangeCloth;

	public GameObject BEDEBUG;

	public UIToggle DebugSamoNavPathOn;

	public UIToggle DebugSamoNavPathOff;

	public GameObject SamoDebugContainer;

	public UIToggle DebugSamoDebugInfoOn;

	public UIToggle DebugSamoDebugInfoOff;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

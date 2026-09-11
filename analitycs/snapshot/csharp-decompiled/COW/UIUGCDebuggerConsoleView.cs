using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCDebuggerConsoleView : UIBaseView
{
	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public UIButton BtnScrollToEnd;

	public UIToggle ToggleError;

	public UIToggle ToggleWarnning;

	public UIToggle ToggleInfo;

	public GameObject notify_down;

	public UIButton TestAddLogBtn;

	public GameObject LabelIfEmpty;

	public GameObject ToggleList;

	public UIToggle ToggleSystem;

	public UIButton BtnClearLog;

	public UILabel LabelLogDetail;

	public GameObject LogDetailPanel;

	public GameObject LogDetailPanelDown;

	public UILabel LabelLogDetailDown;

	public GameObject LogDetailPanelScroll;

	public UIPanel LogDetailScroll;

	public UILabel LabelLogDetailScroll;

	public Transform PanelDetailCoord;

	public UIButton BtnCheck;

	public UISprite CheckIcon;

	public UIDropdown LogOriginDropdown;

	public UILabel InfoLogLabel;

	public UILabel WarningLogLabel;

	public UILabel ErrorLogLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

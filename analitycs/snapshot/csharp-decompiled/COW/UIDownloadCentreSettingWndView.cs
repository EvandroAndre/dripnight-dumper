using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreSettingWndView : UIBaseView
{
	public GameObject RepairContainer;

	public UIButton ConfirmBtn;

	public UIButton RepairBtn;

	public UIButton ClearCenterTip;

	public UIToggleButtonGroup ClearToggleGroup;

	public UIToggleButtonGroup DownLoadToggleGroup;

	public UIToggleButton ClearToggleBtnOff;

	public UIToggleButton ClearToggleBtnOn;

	public UIToggleButton DownLoadToggleBtnOff;

	public UIToggleButton DownLoadToggleBtnOn;

	public GameObject AutoClearResource;

	public GameObject AutoDownloadRecommend;

	public UILabel RepairLabel;

	public GameObject RepairIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSMissionPopupWndView : UIBaseView
{
	public UIButton MaskButton;

	public GameObject LabelRefreshTime;

	public UIButton BtnClose;

	public UIButton AllClaimedBtn;

	public UITable2 Table;

	public Animation MainAni;

	public UIScrollView MissionContainer;

	public UINetworkTextureExt TitleCdn;

	public UILabel DailyLimitLabel;

	public UILabel Title;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

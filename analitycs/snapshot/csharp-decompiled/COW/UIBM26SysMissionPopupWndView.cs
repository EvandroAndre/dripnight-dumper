using GCommon;
using UnityEngine;

namespace COW;

public class UIBM26SysMissionPopupWndView : UIBaseView
{
	public UIButton MaskButton;

	public GameObject LabelRefreshTime;

	public UIButton BtnClose;

	public UIButton AllClaimedBtn;

	public UIGrid Grid;

	public UILabel ObtainBRText;

	public UILabel ObtainCSText;

	public UILabel ObtainLWText;

	public UITable Obtain;

	public UILabel TipsText;

	public Animation DialogTips;

	public UIScrollView MissionContainer;

	public UINetworkTextureExt TitleCdn;

	public Animation MainAni;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

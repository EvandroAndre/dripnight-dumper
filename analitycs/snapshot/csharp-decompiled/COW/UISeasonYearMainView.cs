using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonYearMainView : UIBaseView
{
	public UINetworkTextureExt SeasonYearNameCDN;

	public UIButton ShareBtn;

	public UIButton RuleBtn;

	public UIButton CloseBtn;

	public UILabel SeasonDataLabel;

	public UIButton SeasonDataBtn;

	public UIWidget SeasonDataWidget;

	public GameObject TopLeft;

	public GameObject TopRight;

	public GameObject ShareGiftIcon;

	public Transform TitleShareTrans;

	public Transform TitleNormalTrans;

	public VFXCreateHelper UIFXTitle;

	public Transform SwitchYearTrans;

	public UILabel SeasonYearTitleLabel;

	public Animation SwitchAnim;

	public UIToggleButtonGroup CSPeakAndCSToggle;

	public UIToggleButton CSToggle;

	public GameObject CSPeakToggle;

	public UINetworkTextureExt MiddleShareTitleCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

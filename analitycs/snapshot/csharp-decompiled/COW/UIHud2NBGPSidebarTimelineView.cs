using GCommon;
using UnityEngine;

namespace COW;

public class UIHud2NBGPSidebarTimelineView : UIBaseView
{
	public UIProgressBar ProgressBar;

	public UIWidget BoundsWidget;

	public GameObject PhaseBloodMoonGroup;

	public UISprite PhaseBloodMoon_DurationBorder;

	public UISprite PhaseBloodMoon_DurationUnderline;

	public GameObject PhaseBloodMoon_Icon;

	public GameObject PhaseBloodMoon_GrayIcon;

	public GameObject PhaseBigItemsGroup;

	public UISprite PhaseBigItems_DurationBorder;

	public UISprite PhaseBigItems_DurationUnderline;

	public GameObject PhaseBigItems_Icon;

	public GameObject PhaseBigItems_GrayIcon;

	public GameObject PhaseInfoBG_Active;

	public GameObject PhaseInfoBG_NotActive;

	public UILabel CountdownLabel_Active;

	public UILabel CountdownLabel_Before;

	public UILabel CountdownLabel_Ending;

	public UILabel PhaseDescLabel;

	public UISprite PhaseIcon;

	public UILabel PhaseNameLabel;

	public UISprite ProgressBarBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

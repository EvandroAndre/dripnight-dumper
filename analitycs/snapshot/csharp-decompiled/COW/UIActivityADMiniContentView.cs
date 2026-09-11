using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityADMiniContentView : UIBaseView
{
	public GameObject ThirdTogglesRoot;

	public UIToggleButtonGroup ThirdTogglesGroup;

	public UIToggleButton ThirdTogglePrefab;

	public UINetworkTexture ADMini;

	public Animation IntroPanelAnimationObj;

	public GameObject IntroBG;

	public UITable IntroRoot;

	public GameObject Progress;

	public UILabel ProgressNum;

	public UIProgressBar ProgressBar;

	public UILabel Introduction;

	public UILabel Time;

	public GameObject Content;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityADFullContentTemplateView : UIBaseView
{
	public GameObject ThirdTogglesRoot;

	public UIToggleButtonGroup ThirdTogglesGroup;

	public UIToggleButton ThirdTogglePrefab;

	public UIWidget TitleRoot;

	public UICountDownLabel Time;

	public GameObject Content;

	public UIWidget PreviewBorder;

	public UINetworkTexture TitleTexture;

	public UITable TimeTable;

	public GameObject CountDownIcon;

	public UIWidget RightContainer;

	public UICountDownLabel PreviewCountDown;

	public GameObject PreviewRoot;

	public UIButton HelpBtn;

	public UINetworkTexture HelpDescCdn;

	public GameObject TimeRoot;

	public GameObject TimeLock;

	public UILabel TimeLockLabel;

	public GameObject ThirdToggleBg;

	public UINetworkTexture ThirdToggleBgCdn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

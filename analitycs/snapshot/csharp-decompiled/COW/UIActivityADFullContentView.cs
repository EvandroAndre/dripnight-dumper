using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityADFullContentView : UIBaseView
{
	public GameObject ThirdTogglesRoot;

	public UIToggleButtonGroup ThirdTogglesGroup;

	public UIToggleButton ThirdTogglePrefab;

	public UIWidget IntroBG;

	public UICountDownLabel Time;

	public GameObject Content;

	public UIWidget PreviewBorder;

	public UINetworkTexture CDNTitleName;

	public UITable TimeTable;

	public GameObject CountDownIcon;

	public UIWidget RightContainer;

	public UICountDownLabel PreviewCountDown;

	public GameObject PreviewRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

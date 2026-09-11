using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCParadiseRegionView : UIBaseView
{
	public UIToggleButtonGroup ButtonGroup;

	public Transform Main;

	public UIButton BtnEnter;

	public GameObject DisableBg;

	public GameObject EnableBg;

	public GameObject Region;

	public UIToggleButton GlobalBtn;

	public GameObject SelectGlobal;

	public Animation GlobalAni;

	public GameObject UnSelectGlobal;

	public UITexture MapBg;

	public UITexture GlobalBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

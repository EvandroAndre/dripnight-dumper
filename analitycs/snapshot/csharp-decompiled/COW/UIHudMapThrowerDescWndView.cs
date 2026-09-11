using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapThrowerDescWndView : UIBaseView
{
	public UISprite Item1Icon;

	public UILabel Item1Title;

	public UILabel Item1Desc;

	public UISprite Item2Icon;

	public UILabel Item2Title;

	public UILabel Item2Desc;

	public UISprite Item3Icon;

	public UILabel Item3Title;

	public UILabel Item3Desc;

	public GameObject Item1;

	public GameObject Item2;

	public GameObject Item3;

	public UIButton Item1Btn;

	public UIButton Item2Btn;

	public UIButton Item3Btn;

	public GameObject Item1Highlight;

	public GameObject Item3Highlight;

	public GameObject Item2Highlight;

	public Transform UIFXContainer;

	public UIWidget GuideWidget1;

	public UIWidget GuideWidget2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

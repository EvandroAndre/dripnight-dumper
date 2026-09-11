using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBuffPopOverView : UIBaseView
{
	public GameObject DetailBg;

	public UISprite DetailBgSprite;

	public UITable DetailTable;

	public UIHudPlayerDebuffDetailItem DetailItem;

	public UIScrollView ScrollView;

	public Transform UIHudBuffPopOver;

	public GameObject DownArrowPanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

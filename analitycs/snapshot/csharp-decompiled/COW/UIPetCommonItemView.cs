using GCommon;
using UnityEngine;

namespace COW;

public class UIPetCommonItemView : UIBaseView
{
	public UIButton UIButtonUIPetCommonItem;

	public BaseItemView BaseItemViewUIPetCommonItem;

	public GameObject HighLightBG;

	public GameObject BG;

	public UISprite UnlockIcon;

	public GameObject Check;

	public GameObject NewTag;

	public UISprite LoveIcon;

	public VFXCreateHelper VFX_LoveNode;

	public GameObject NewTable;

	public GameObject Time;

	public GameObject EvoPassIcon;

	public UIGrid LeftTopGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

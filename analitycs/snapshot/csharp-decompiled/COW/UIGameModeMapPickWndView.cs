using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeMapPickWndView : UIBaseView
{
	public UIGrid GridMaps;

	public UIButton BtnConfirm;

	public UILabel LabelSelected;

	public UIButton BtnSelectAll;

	public UISprite SpriteAllTick;

	public GameObject RP;

	public UILabel RPLabel;

	public UILabel LabelTip;

	public UIScrollView ScrollView;

	public GameObject BrRp;

	public GameObject CsRp;

	public UIButton MultiMapBonusBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

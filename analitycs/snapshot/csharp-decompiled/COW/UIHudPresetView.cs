using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPresetView : UIBaseView
{
	public TweenPosition ShowAnim;

	public UIButton BGBtn;

	public UIScrollView ScrollView;

	public UITable PresetTable;

	public UIToggleButtonGroup presetToggleBtnGroup;

	public UIButton CloseBtn;

	public UISprite SpriteCloseBtnLight;

	public GameObject LeftTimeShow;

	public UILabel LeftTime;

	public UIButton ConfirmBtn;

	public UILabel title;

	public UIButton RefreshBtn;

	public UILabel Refreshtimes;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

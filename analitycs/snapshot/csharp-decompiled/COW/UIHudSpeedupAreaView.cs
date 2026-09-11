using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSpeedupAreaView : UIBaseView
{
	public GameObject SpeedupArea;

	public UIWidget AreaWgt;

	public UIButton btnSpeedup;

	public UISprite icon;

	public UILabel ActionNameTxt;

	public UISprite CDProgress;

	public GameObject CDMask;

	public UISprite Bg;

	public VFXCreateHelper ClickEffect;

	public UIButton FollowEmoteDriver;

	public UIButton FollowEmotePassenger;

	public GameObject FollowEmoteContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

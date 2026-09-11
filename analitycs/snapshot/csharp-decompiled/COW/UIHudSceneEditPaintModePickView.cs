using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPaintModePickView : UIBaseView
{
	public UIButton ThemeBtn;

	public UINetworkTexture ThemeText;

	public UIButton BatchBtn;

	public UINetworkTexture BatchText;

	public UIUnBlockOtherHudScript UIUnBlockOtherHudScript;

	public UIButton SpeedBtn;

	public UINetworkTexture SpeedTex;

	public UINetworkTexture ItemGenTexture;

	public UIButton ItemGenBtn;

	public GameObject ItemGenNew;

	public GameObject RaceNew;

	public GameObject SpeedMask;

	public UIButton CloseBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

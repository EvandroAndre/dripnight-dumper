using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDEighthTrainEventContentView : UIBaseView
{
	public UIProgressBar TrainProgress;

	public GameObject TrainIcon;

	public UISprite Item1Icon;

	public UISprite Item2Icon;

	public UISprite Item3Icon;

	public UISprite Item4Icon;

	public UILabel LeftTimeLabel;

	public UISprite CurItemIcon;

	public UILabel CurItemNameLabel;

	public UIWidget EmptyBoundWidget;

	public UILabel NextTrainStateLabel;

	public UILabel HightLightLeftTimeLabel;

	public GameObject NormalBGRoot;

	public GameObject HightLightBGRoot;

	public GameObject TopBlackMaskRoot;

	public GameObject ActiveItemEffectRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

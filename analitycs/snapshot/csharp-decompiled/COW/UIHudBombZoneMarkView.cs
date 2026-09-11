using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBombZoneMarkView : UIBaseView
{
	public UISprite BombFg;

	public UISprite RemoveBombFg;

	public GameObject BombBg;

	public UILabel ZoneIDLabel;

	public UISprite ArrowLeft;

	public UISprite ArrowUp;

	public UISprite ArrowDown;

	public UISprite ArrowRight;

	public UILabel DistanceLabel;

	public UIWidget boundWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

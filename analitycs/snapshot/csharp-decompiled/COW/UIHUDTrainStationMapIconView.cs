using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDTrainStationMapIconView : UIBaseView
{
	public UILabel TimeLabel;

	public GameObject WaitingStateRoot;

	public GameObject TrainStopRoot;

	public GameObject ItemRoot;

	public UISprite ItemIcon;

	public GameObject Left30sRoot;

	public GameObject ReviveZoneRoot;

	public UIWidget MarkCheckWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWMultiRoundTransitionView : UIBaseView
{
	public GameObject nextRoundContainer;

	public UILabel matchpoint;

	public UILabel roundNum;

	public UILabel gamezoneName;

	public GameObject winSprite;

	public GameObject ScoreContainer;

	public UIListAnimQueueHelper ListHelper;

	public GameObject BG;

	public Transform item1;

	public Transform item2;

	public Transform item3;

	public Animation main;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

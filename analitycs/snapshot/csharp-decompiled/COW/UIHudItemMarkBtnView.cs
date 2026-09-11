using GCommon;
using UnityEngine;

namespace COW;

public class UIHudItemMarkBtnView : UIBaseView
{
	public Transform ExtraMarkGroup;

	public UIEventListener EventListener;

	public Transform BtnMark;

	public UISprite CDProgress;

	public GameObject cancelIcon;

	public GameObject cancelActiveIcon;

	public GameObject EnemyIcon;

	public GameObject SelectPanel;

	public GameObject LeftPanel;

	public GameObject RightPanel;

	public GameObject NormalIcon;

	public GameObject LeftSelectPanel;

	public GameObject RightSelectPanel;

	public GameObject MoveTipContainer;

	public UISprite MoveTipIcon;

	public GameObject AutoEnemyMarkContainer;

	public UISprite bg;

	public UISprite Sprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

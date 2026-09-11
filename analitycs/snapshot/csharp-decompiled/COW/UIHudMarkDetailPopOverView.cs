using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMarkDetailPopOverView : UIBaseView
{
	public GameObject UIHudMarkDetailPopOver;

	public BoxCollider DetailBg;

	public UILabel Title;

	public Transform Style1;

	public Transform Style2;

	public UILabel Desc;

	public UIGrid ItemGrid;

	public UIHippoCrisisPopItemController UIHippoCrisisMarkPopItem;

	public Transform Style3;

	public UISprite Icon;

	public UILabel Style3Title;

	public UILabel Time;

	public UILabel Description;

	public UILabel RewardNumber;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

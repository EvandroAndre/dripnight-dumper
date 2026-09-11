using GCommon;
using UnityEngine;

namespace COW;

public class UIHudItemInfosView : UIBaseView
{
	public UIGrid Grid;

	public GameObject IceWall;

	public GameObject Grenade;

	public GameObject Medkit;

	public GameObject TechDevice;

	public UISprite IceWallIcon;

	public UILabel IceWallnum;

	public UISprite GrenadeIcon;

	public UILabel Grenadenum;

	public UISprite MedkitIcon;

	public UILabel Medkitnum;

	public UISprite TechDeviceIcon;

	public UILabel TechDevicelnum;

	public UISprite InCD;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

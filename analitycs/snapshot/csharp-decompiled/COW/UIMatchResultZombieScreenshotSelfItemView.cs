using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchResultZombieScreenshotSelfItemView : UIBaseView
{
	public GameObject baseProfile;

	public GameObject briefProfile;

	public UISprite WeaponIcon;

	public UILabel Kills;

	public UILabel Damages;

	public UILabel SurvivedTime;

	public UISprite NormalBG;

	public UISprite FirstBG;

	public GameObject MVPIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

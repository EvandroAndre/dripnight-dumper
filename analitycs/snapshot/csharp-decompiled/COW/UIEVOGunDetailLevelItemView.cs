using GCommon;
using UnityEngine;

namespace COW;

public class UIEVOGunDetailLevelItemView : UIBaseView
{
	public GameObject LevelBG;

	public UILabel LevelBgLabel;

	public UISprite LevelBgSpriteNormal;

	public GameObject LevelLockedIcon;

	public GameObject LevelTipsIcon;

	public UISprite LevelHighLight;

	public UIButton SelectBtn;

	public UISprite LevelBgSpriteOwned;

	public GameObject LevelVIPIcon;

	public GameObject LevelMorePrivilegeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

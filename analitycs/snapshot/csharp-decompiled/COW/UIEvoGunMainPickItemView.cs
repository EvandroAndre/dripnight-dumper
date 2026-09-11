using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunMainPickItemView : UIBaseView
{
	public GameObject Selected;

	public UILabel LabelWeaponName;

	public UILabel LabelWeaponNickName;

	public GameObject NameAndLevel;

	public UIWidget WidgetName;

	public GameObject Lock;

	public UIWidget WidgetLock;

	public UIButton BtnPick;

	public GameObject Content;

	public Animation AnimationNavigation;

	public GameObject Bg;

	public UIWidget WidgetBg;

	public UINetworkTexture NetworkTextureNaviBg;

	public UITexture TextureNaviBg;

	public GameObject NaviBgLocked;

	public GameObject Unlock;

	public UISprite SpriteLockIcon;

	public UISprite SpriteUnLockIcon;

	public GameObject RedPoint;

	public GameObject Level;

	public UITable TableLevelIconContainer;

	public Transform LevelIconContainer;

	public UILabel LabelLevel;

	public GameObject UnLockLight;

	public GameObject SpriteVIP;

	public GameObject SpriteLock;

	public GameObject WeaponNickNameWithNewTag;

	public UILabel LabelWeaponNickNameWithNewTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

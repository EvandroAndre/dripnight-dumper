using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSysEntranceView : UIBaseView
{
	public UIButton BtnWeaponSkinUpgrader;

	public GameObject UpgraderClickEffect;

	public UILabel LabelWSPName;

	public GameObject WSUNotInOpenTime;

	public GameObject WSURedPoint;

	public UIButton BtnWeaponSkinEnter;

	public UIWidget CustomSkinGuideWidget;

	public GameObject SkinLobbyClickEffect;

	public UIButton BtnWeaponProficiency;

	public GameObject WPRedPoint;

	public GameObject WPNewTip;

	public GameObject WPClickEffect;

	public Transform BackupPosWeaponSkinEnter;

	public Transform BackupPosWeaponSkinUpgrader;

	public GameObject WSUNewTip;

	public GameObject SpriteWeaponSkinEnter;

	public UINetworkTexture NetworkTextureWeaponSkinEnter;

	public UISprite SpriteWeaponSkinUpgrader;

	public UINetworkTexture NetworkTextureWeaponSkinUpgrader;

	public Transform CustomSkinGuidePos;

	public Transform CustomSkinHandGuidePos;

	public GameObject WeaponSkinUpgradertLock;

	public Transform WeaponSkinUpgradertLockTransForm;

	public GameObject WeaponProficiencyLock;

	public Transform WeaponProficiencyLockTransForm;

	public GameObject WPRedRedPointState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

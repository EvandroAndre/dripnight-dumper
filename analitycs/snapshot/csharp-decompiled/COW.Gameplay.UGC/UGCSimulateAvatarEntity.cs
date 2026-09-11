using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSimulateAvatarEntity : Entity
{
	private AvatarPropManager m_AvatarPropManager;

	protected ResourceID m_GunResId;

	protected ResourceID m_GunDefaultResId;

	private ResourceID m_GunParticleId;

	private ResourceID m_GunFireEffectId;

	private ResourceID m_MeleeRunEffectId;

	protected ResourceID m_GunResIdSecond;

	protected AFOLPMOCBOG m_CollectionResData;

	private ResourceID m_GunFireSoundId;

	private bool m_DualWield;

	private bool m_FistUseForeArm;

	private bool m_FistRightZScaleInverse;

	private bool m_DoubleWeapon;

	protected Transform m_entityTransform;

	public uint WeaponSkinOnHand => 0u;

	public void InitSimulateAvatar(GameObject entityObject)
	{
	}

	public void LoadFFWeapon(uint weaponSkinID, uint avatarID)
	{
	}

	public static bool CreateWeaponObject(uint weaponSkinID, out GameObject outWeaponObj, out GameObject outEffObj)
	{
		outWeaponObj = null;
		outEffObj = null;
		return false;
	}

	public void ShowWeapon(bool show = true)
	{
	}

	public void loadFFWeapon(AFOLPMOCBOG data, ResourceID defaultid, bool rebind = true, bool dualWeild = false)
	{
	}

	private void loadFFWeapon(AFOLPMOCBOG data, ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weaponfiresoundid, ResourceID weapondefaultid, ResourceID weaponMeleeRunEffectId, bool rebind = true, bool dualWeild = false)
	{
	}
}

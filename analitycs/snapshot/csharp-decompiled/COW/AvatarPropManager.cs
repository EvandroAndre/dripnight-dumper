using GCommon;
using UnityEngine;
using UnityEngine.Rendering;

namespace COW;

public class AvatarPropManager
{
	private GameObject m_PropGORight;

	private GameObject m_PropGOLeft;

	private GameObject m_PropGORoot;

	private GameObject m_PropGOHead;

	private GameObject m_PropSkyBoard;

	private GameObject m_PropWeapon;

	private ResourceID m_CurrentPropWeapon;

	private GameObject m_PropFireEffect;

	private GameObject m_PropSecondaryWeapon;

	private ResourceID m_CurrentSecondaryPropWeapon;

	private GameObject m_PropSecondaryFireEffect;

	private GameObject m_PropMeleeRunEffect;

	private GameObject m_PropSecondaryMeleeRunEffect;

	private ResourceID m_CurrentPropIDRight;

	private ResourceID m_CurrentPropIDLeft;

	private ResourceID m_CurrentPropIDRoot;

	private ResourceID m_CurrentPropIDHead;

	private ITransformNode m_ParentRight;

	private ITransformNode m_ParentRightForeArm;

	private ITransformNode m_ParentLeft;

	private ITransformNode m_ParentLeftForeArm;

	private ITransformNode m_ParentRoot;

	private ITransformNode m_ParentHead;

	private Animator m_PropAnimator;

	private PropAnimComponent m_LeftPropAnim;

	private Entity m_OwnerEntity;

	private bool hasweapon;

	private bool isLocalPlayer;

	private UIMaleAvatar m_Avatar;

	private bool m_ShowState;

	public AvatarPropManager(Entity ownerEntity, bool isLocal)
	{
	}

	public void ClearShowingWeapon()
	{
	}

	public bool IsDualWeild()
	{
		return false;
	}

	public void RecycleCurrentProp()
	{
	}

	public void Clear()
	{
	}

	public void SetPropItemVisibiltiy(bool visible)
	{
	}

	public void SetPropCastShadow()
	{
	}

	private void ProcessCastShadow(GameObject go, ShadowCastingMode shadowCastingMode)
	{
	}

	public void UpdatePropItem(PropertyData pData)
	{
	}

	public bool CheckHasPropWeapon()
	{
		return false;
	}

	public void ShowPropWeaponState(bool flag)
	{
	}

	public void ShowPropWeaponMesh(bool flag)
	{
	}

	public GameObject GetCurPropWeapon()
	{
		return null;
	}

	public void ShowPropWeapon(bool show = true)
	{
	}

	public void UpdateWeaponItem(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weapondefaultid, ResourceID weaponMeleeRunId, bool secondary = false, bool isLeft = false, bool skipLeftOffset = false)
	{
	}

	public void UpdateNoAnimWeaponItem(ResourceID weaponResId, ResourceID weaponDefaultId)
	{
	}

	public bool CheckHasWeapon()
	{
		return false;
	}

	private void UpdateWeaponItem(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weapondefaultid, ResourceID weaponMeleeRunId, ref GameObject propWeapon, ref ResourceID currentPropWeapon, ref ITransformNode parent, ref GameObject propFireEffect, ref GameObject propMeleeRunEffect, bool secondary, bool isLeft, bool fistUseForeArm, bool fistZScaleInverse, bool skipLeftOffset = false)
	{
	}

	public void UpdateSkyBoardItem(ResourceID skyboardid)
	{
	}

	private void ResetObjectTransform(GameObject obj, bool isLeft = false)
	{
	}

	public void StartShowPose(bool immediately = false)
	{
	}

	public void PlayClothesChangeAnim()
	{
	}

	public void StopClothesChangeAnim()
	{
	}

	public void StopShowPose(bool immediately = false)
	{
	}

	public void SetOverrideAnim(AnimationClip clip, AnimationClip baseClip)
	{
	}

	public void RebindAnimator()
	{
	}

	public void PlayLeftPropAnim(int index)
	{
	}

	public void PlayRootPropAnim(int index)
	{
	}

	public void PlayMeleeRunEffect()
	{
	}

	public bool PlayFistFireEffect(bool right)
	{
		return false;
	}

	public void ResetCacheTransformNode()
	{
	}
}

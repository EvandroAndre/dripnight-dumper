using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class IngameAvatarWeaponEffectComponent : MonoBehaviour
{
	private Player m_Player;

	private IUmaAvatar m_Avatar;

	private EntityVisualEffectManager m_VisualEffectManager;

	private uint m_CurrentWeaponSwitchEffectUniqueID;

	private GameObject m_CurrentWeaponSwitchEffectInstance;

	private List<BoneNameRef> m_BoneNameRefObjs;

	public bool CastShadow;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public uint PlayWeaponSwitchEffect(ResourceID weaponSwitchResID, Transform attachBone = null)
	{
		return 0u;
	}

	public void ClearCurrentWeaponSwitchEffect()
	{
	}

	public void OnPlayerVisibleChanged(bool visible)
	{
	}

	public void OnWeaponSwitchEffectLoaded(uint uniqueID, ResourceID vfxResID, GameObject instance)
	{
	}

	private void ProcessCastShadow(GameObject effectInstance)
	{
	}

	private void ProcessBoneNameRefs(GameObject effectInstance)
	{
	}

	private void ProcessSingleBoneNameRef(BoneNameRef boneRef)
	{
	}

	private void RecordOriginalTransform(BoneNameRef boneRef)
	{
	}

	private void RestoreBoneNameRefsBeforeRecycle()
	{
	}

	private bool ScaleInLocalSpace(GameObject go)
	{
		return false;
	}
}

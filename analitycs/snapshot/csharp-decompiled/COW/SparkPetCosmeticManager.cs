using GCommon;
using UnityEngine;

namespace COW;

public class SparkPetCosmeticManager
{
	private class CosmeticSlot
	{
		public GameObject CosmeticGO;

		public ResourceID CurrentID;

		public ITransformNode ParentNode;
	}

	private CosmeticSlot[] m_CosmeticSlots;

	private Entity m_OwnerEntity;

	private const int COSMETIC_TYPE_COUNT = 5;

	private GameObject[] m_HideMaterialByDressUp;

	private bool m_IsHeadMaterialHidden;

	public SparkPetCosmeticManager(Entity ownerEntity, GameObject[] hideMaterialByDressUp)
	{
	}

	public void UpdateCosmetics(SparkPetCosmeticData cosmeticData)
	{
	}

	public void UpdateCosmeticItem(ESparkPetCosmeticType cosmeticType, ResourceID resourceID)
	{
	}

	public void RecycleAllCosmetics()
	{
	}

	public void Clear()
	{
	}

	public void SetAnimHideCosmeticsVisible(bool visible)
	{
	}

	public void RefreshHeadMaterialVisibility()
	{
	}

	private int GetSlotIndex(ESparkPetCosmeticType cosmeticType)
	{
		return 0;
	}

	private void RecycleCosmeticSlot(CosmeticSlot slot)
	{
	}

	private GameObject LoadAndAttachCosmetic(ResourceID resourceID, ref ITransformNode cachedParent)
	{
		return null;
	}

	private void ProcessChildBoneNameRefs(GameObject rootGO)
	{
	}

	private void RestoreBoneNameRefs(GameObject rootGO)
	{
	}

	private void ResetCosmeticTransform(GameObject cosmeticGO)
	{
	}

	private void SetGameObjectActive(GameObject go, bool active)
	{
	}

	public void ResetCachedTransformNodes()
	{
	}

	private void HideHeadMaterial()
	{
	}

	private void ShowHeadMaterial()
	{
	}

	private bool IsAnyOtherCosmeticHidingHeadMaterial(int excludeSlotIndex)
	{
		return false;
	}

	private uint GetItemIDFromResourceID(ResourceID resourceID)
	{
		return 0u;
	}
}

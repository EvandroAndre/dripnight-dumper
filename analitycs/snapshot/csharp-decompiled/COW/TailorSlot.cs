using GCommon;
using UnityEngine;

namespace COW;

public class TailorSlot : MonoBehaviour
{
	public UIModelAvatarBase.EWardrobeType SlotType;

	public Vector3 BGRotation;

	public UIBasicSprite.Flip BGFlip;

	public UIButton Button;

	private TailorSlotItem m_SlotItem;

	private TailorItemInfo m_TailorItemInfo;

	public void SetTailorSlotItem(TailorSlotItem slotItem)
	{
	}

	private void RefreshTailorSlotItemBG()
	{
	}

	private void RefreshDefaultIcon()
	{
	}

	private string EmptyIconName()
	{
		return null;
	}

	private void RefreshTailorSlotLockState(bool isLock)
	{
	}

	public void SetNoClothState()
	{
	}

	public void SetEmptyState()
	{
	}

	private void SetSlotItemIcon(ResourceID resourceID)
	{
	}

	public void SetClothInfo(TailorItemInfo tailorItemInfo)
	{
	}

	public bool HasSetTailorSlotItem()
	{
		return false;
	}

	private void OnBtnClick()
	{
	}
}

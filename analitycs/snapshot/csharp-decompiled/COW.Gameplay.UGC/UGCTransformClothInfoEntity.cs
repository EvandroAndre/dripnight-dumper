using System.Collections.Generic;

namespace COW.Gameplay.UGC;

internal class UGCTransformClothInfoEntity
{
	private UGCTransformClothInfoRepItem m_ugcTransformClothInfoEntity;

	private Dictionary<int, int> m_ugcUserSetClothType2ClothIDMap;

	private int m_userSetBagSkinID;

	private int m_userSetCurWeaponSkinID;

	private UGCSkeletonAvatarSystem m_avatar;

	public void ChangeAvatar(UGCSkeletonAvatarSystem avatar)
	{
	}

	public void OnTransformClothInfoChanged(string clothInfoEntityID)
	{
	}

	private void OnTransformClothBagSkinIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothCurWeaponSkinIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothSetIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothHairIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothHeadAdditiveIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothChestIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothFeetIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothLegsIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothFaceIDChangeEvent(int newValue)
	{
	}

	private void OnTransformClothChangeEvent(int newValue, UIModelAvatarBase.EWardrobeType type)
	{
	}
}

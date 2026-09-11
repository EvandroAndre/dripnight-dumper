using System;
using System.Collections.Generic;

namespace COW;

public class UIAvatarStateBase
{
	public uint AvatarID;

	public uint CollectionId;

	public uint CollectionLevel;

	public float SkinColorNormed;

	public bool IsLocalAvatar;

	public bool UseLobbyRecipes;

	public List<uint> Clothes;

	public ulong AccountID;

	public ulong SetSharerID;

	public Dictionary<uint, AvatarCustomData> CustomData;

	public HashSet<uint> ClothEffectUnlockItems;

	public int ClothesNotReadyCnt;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	public bool PlayTriggerEffect;

	public bool HideSkinRendererUntilNotDirty;

	public Action<bool> AvatarInitedCallbackOnce;

	public Action<UIStatedAvatar> AvatarUpdateCallbackOnce;

	public Action OnAvatarUpdateFinished;

	public bool IsSkipSetAnimator;

	protected UIModelCollectionCustom ModelCollectionCustom => null;

	public void SetClothes(IEnumerable<uint> cs, ulong setSharerId = 0uL, bool clone = false)
	{
	}

	public void RefreshCustomDataForCurrentClothes(ulong setSharerId = 0uL)
	{
	}

	public void refreshCustomData(uint clothid, ulong setSharerId = 0uL)
	{
	}

	public void SetCollection(uint id, uint level = 3u)
	{
	}

	public void ClearCollection()
	{
	}

	public void SetClothEffectUnlockItems(IEnumerable<uint> cs)
	{
	}

	public void CloneTo(UIAvatarStateBase s)
	{
	}

	public virtual void ResetOnceValues()
	{
	}
}

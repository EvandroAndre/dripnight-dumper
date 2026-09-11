using UMA;
using UnityEngine;

namespace COW;

public class UIAvatar : UIAvatarBase
{
	protected uint m_AvatarID;

	protected bool m_AvatarIsABReady;

	protected bool m_AvatarAnimIsAbReady;

	private bool _003CIsDirty_003Ek__BackingField;

	protected bool m_IsCurrentModelFemale;

	protected bool m_IsSettingAvatar;

	protected CSSharedAvatarData m_SettingAvatarData;

	protected Coroutine m_PlayGunCoroutine;

	protected Coroutine m_PlayGunAnimCoroutine;

	protected Coroutine m_PlayGunResetAnimCoroutine;

	private uint m_RepairPreAvatarID;

	public bool IsDirty
	{
		get
		{
			return _003CIsDirty_003Ek__BackingField;
		}
		protected set
		{
			_003CIsDirty_003Ek__BackingField = value;
		}
	}

	public bool IsCurrentModelFemale()
	{
		return false;
	}

	public static CSSharedAvatarData GetAvatarData(uint id)
	{
		return null;
	}

	public static AvatarWardrobeData GetWardrobeData(uint id)
	{
		return null;
	}

	public static string GetSlot(AvatarWardrobeData data)
	{
		return null;
	}

	public uint GetAvatarID()
	{
		return 0u;
	}

	internal void SetSlot(AvatarWardrobeData wData, bool isFemale, uint avatarId = 0u)
	{
	}

	internal virtual void SetAvatar(uint avatarId)
	{
	}

	protected virtual void OnSetAvatar(CSSharedAvatarData aData)
	{
	}

	protected override void CharacterUpdateCallBack(UMAData data)
	{
	}

	protected virtual void OnSetAvatarDone(CSSharedAvatarData aData)
	{
	}

	protected void UpdateSlotsWithDefaultClothes(CSSharedAvatarData aData, bool facialDataReady)
	{
	}

	public void ClearLobbyAnimEffect()
	{
	}

	public void ForceSetColor(float f)
	{
	}

	internal void SetColor(float f, bool updateTexture)
	{
	}

	protected void SetDefaultColor(CSSharedAvatarData aData, bool updateTexture, bool facialDataReady)
	{
	}

	public virtual void ResetAvatar()
	{
	}

	public void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}
}

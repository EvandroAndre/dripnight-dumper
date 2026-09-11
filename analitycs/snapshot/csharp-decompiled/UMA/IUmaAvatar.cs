using UMACharacterSystem;
using UnityEngine;

namespace UMA;

public interface IUmaAvatar : IUmaAvatarWithSlots, IUmaAvatarBase
{
	void SetForceChangeRace();

	void ChangeRace(string racename, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults);

	void SetColor(string Name, OverlayColorData colorData, bool UpdateTexture = true);

	void SetMaskColors(Color[] mask, Color[] additive, bool updateTexture = false);

	void ForceUpdateColor();

	void BuildCharacterImmediatly();

	void BuildCharacter();

	void ForceUpdate(bool DnaDirty, bool TextureDirty = false, bool MeshDirty = false);

	void InitAsyncLoading(bool pre);

	bool IsAsyncLoading();

	void SetUpdateWeaponFlag(bool flag);

	bool GetUpdateWeaponFlag();

	void SetCustomTextureDirty(bool dirty);
}

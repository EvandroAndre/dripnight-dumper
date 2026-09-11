namespace COW;

public interface IClothTriggerEffectPreviewContext
{
	FrontEndPreviewComponent FrontEndPreviewComponent { get; }

	uint ClothOrBundleId { get; set; }

	uint ClothesSetID { get; }

	bool IsFemaleAvatar { get; set; }

	void SwtichEffectAvatarPreview(bool isAvatarPreview);

	void RefreshPreview(uint clothID, int clothEffectTriggerID, bool refreshNow, EPrivilegePreviewType privilegePreviewType);
}

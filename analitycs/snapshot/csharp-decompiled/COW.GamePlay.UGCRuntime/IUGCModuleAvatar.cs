namespace COW.GamePlay.UGCRuntime;

internal interface IUGCModuleAvatar : IUGCModule
{
	void CreateAvatarController(EntityIndex index, string resID);

	void ChangeAvatarPart(EntityIndex index, string partName);

	void DisableAvatarPart(EntityIndex index, string partName);

	void EnableAvatarPart(EntityIndex index, string partName);

	bool IsAvatarableEntity(EntityIndex index);

	bool SetAppearanceMaterial(EntityIndex index, string group, string part, int slotOneBase, string materialResUUID);

	bool ResetAppearanceMaterial(EntityIndex index, string group, string part, int slotOneBase);

	bool ResetAppearanceMaterialGroup(EntityIndex index, string group);

	bool TryGetAppearanceMaterial(EntityIndex index, string group, string part, int slotOneBase, out string materialResUUID);
}

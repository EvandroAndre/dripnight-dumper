using System.Collections.Generic;
using COW.Gameplay.UGC;

namespace COW.GamePlay.UGCRuntime;

public class UGCAvatarModule : IUGCModuleAvatar, IUGCModule
{
	private UGCRuntime ugcRuntime;

	private UGCEntityDataStore dataStore;

	private Dictionary<uint, UGCAvatarController> avatarMap;

	private uint lastTickGameTime;

	private UGCAvatarMaterialOverride m_materialOverride;

	public IUGCModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	private void OnAddCustomLevelObject(string entityID)
	{
	}

	private void OnRemoveCustomLevelObject(string entityID)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void OnTickEventHandle()
	{
	}

	public void Destroy()
	{
	}

	public void CreateAvatarController(EntityIndex avatarAbleID, string avatarResUUID)
	{
	}

	public bool IsAvatarableEntity(EntityIndex avatarAbleID)
	{
		return false;
	}

	internal void LinkAvatarSystem(EntityIndex avatarAbleID, UGCSkeletonAvatarSystem avatarSystem)
	{
	}

	public bool SetAppearanceMaterial(EntityIndex avatarAbleID, string group, string part, int slotOneBase, string materialResUUID)
	{
		return false;
	}

	public bool ResetAppearanceMaterial(EntityIndex avatarAbleID, string group, string part, int slotOneBase)
	{
		return false;
	}

	public bool ResetAppearanceMaterialGroup(EntityIndex avatarAbleID, string group)
	{
		return false;
	}

	public bool TryGetAppearanceMaterial(EntityIndex avatarAbleID, string group, string part, int slotOneBase, out string materialResUUID)
	{
		materialResUUID = null;
		return false;
	}

	private static void LogError(EntityIndex eid, string group, string part, int slotOneBase, string code)
	{
	}

	public void ChangeAvatarPart(EntityIndex avatarAbleID, string partName)
	{
	}

	public void DisableAvatarPart(EntityIndex avatarAbleID, string partName)
	{
	}

	public void EnableAvatarPart(EntityIndex avatarAbleID, string partName)
	{
	}

	private void TickAll(float deltaTimeMS)
	{
	}
}

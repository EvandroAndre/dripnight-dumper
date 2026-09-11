using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCAvatarController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UGCAvatarMaterialOverride materialOverride;

		public UGCAvatarController _003C_003E4__this;

		public UGCSkeletonAvatarSystem capturedSysForPart;

		public UGCAvatarMaterialOverride capturedOverride;

		public EntityIndex capturedEid;

		public UGCSkeletonAvatarSystem capturedSys;

		internal void _003CLinkAvatarSystem_003Eb__0(string group, string part, Renderer rd)
		{
		}

		internal Material _003CLinkAvatarSystem_003Eb__1(SkinnedMeshRenderer renderer, int subMeshIndex)
		{
			return null;
		}
	}

	private UGCRuntime ugcRuntime;

	private MNJPGANHNOK resController;

	private List<UGCAvatarPartInfo> partList;

	private UGCLogicEntity ControllerEntity;

	private UGCEntityDataStore entityModule;

	private List<int> tempDisableGroupList;

	private string ControllerEntityName;

	private UGCSkeletonAvatarSystem m_linkedAvatarSystem;

	private Action<string, string, Renderer> m_onPartCreatedHandler;

	private EntityIndex m_avatarAbleID;

	internal UGCSkeletonAvatarSystem GetLinkedAvatarSystem()
	{
		return null;
	}

	internal void LinkAvatarSystem(UGCSkeletonAvatarSystem avatarSystem, EntityIndex avatarAbleID, UGCAvatarMaterialOverride materialOverride)
	{
	}

	internal void UnlinkAvatarSystem()
	{
	}

	public bool HasGroup(string group)
	{
		return false;
	}

	public bool HasPart(string group, string part)
	{
		return false;
	}

	public void Create(UGCLogicEntity controllerEntity, UGCEntityDataStore entityModule, UGCRuntime ugcRuntime)
	{
	}

	public void LoadControllerByResUUID(string resUUID, UGCRuntime ugcRuntime)
	{
	}

	public void LoadUGCResAvatarController(MNJPGANHNOK controller)
	{
	}

	public void LoadDefaultPart()
	{
	}

	public bool IsAllResLoaded()
	{
		return false;
	}

	private bool IsInTempDisableList(int groupID)
	{
		return false;
	}

	public void ChangeAvatarPart(string partName)
	{
	}

	public void DisableAvatarPart(string partName)
	{
	}

	public void EnableAvatarPart(string partName)
	{
	}

	private void DisableAvatarPartByBitIndex(int partBitIndex)
	{
	}

	private void EnableAvatarPartByBitIndex(int partBitIndex)
	{
	}

	private void SetAvatarPartByBitIndex(long propID, int partBitIndex, int baseIndex, bool enable)
	{
	}

	private void _003CLoadControllerByResUUID_003Eb__16_0(bool succ, UGCResOneAvatar resObj)
	{
	}
}

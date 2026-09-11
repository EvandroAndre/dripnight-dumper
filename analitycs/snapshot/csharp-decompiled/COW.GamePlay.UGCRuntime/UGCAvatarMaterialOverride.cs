using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

internal class UGCAvatarMaterialOverride
{
	public struct OverrideKey : IEquatable<OverrideKey>
	{
		public uint entityIdx;

		public string group;

		public string part;

		public int slotZeroBase;

		public bool Equals(OverrideKey other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	private struct PartIndex : IEquatable<PartIndex>
	{
		public uint entityIdx;

		public string group;

		public string part;

		public bool Equals(PartIndex other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	private class MaterialCacheEntry
	{
		public UGCMaterial material;

		public int refCount;
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public Renderer capturedRenderer;

		public OverrideKey capturedKey;

		public string capturedMatID;

		public int capturedSlot;

		public UGCSkeletonAvatarSystem capturedSystem;

		public string capturedGroup;

		public string capturedPart;

		public UGCAvatarMaterialOverride _003C_003E4__this;

		internal void _003CApplyToPart_003Eb__0(UGCMaterial mat)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Action<UGCMaterial> onLoaded;

		public UGCAvatarMaterialOverride _003C_003E4__this;

		public string materialResUUID;

		internal void _003CLoadMaterialAsync_003Eb__0(bool succ, UGCMaterial resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string capturedEntityID;

		public string capturedGroup;

		public string capturedPart;

		public int capturedSlot;

		public string capturedMatID;

		public UGCAvatarMaterialOverride _003C_003E4__this;

		public OverrideKey key;

		public UGCSkeletonAvatarSystem avatarSystem;

		internal void _003CSet_003Eb__0(UGCMaterial mat)
		{
		}
	}

	public const int MAX_OVERRIDE_PER_ENTITY = 64;

	private readonly Dictionary<OverrideKey, string> m_overrideMap;

	private readonly Dictionary<PartIndex, List<OverrideKey>> m_partIndex;

	private readonly Dictionary<uint, int> m_entityOverrideCount;

	private readonly Dictionary<string, MaterialCacheEntry> m_loadedMatCache;

	private readonly Dictionary<OverrideKey, Material> m_defaultMaterialSnapshot;

	public bool Set(EntityIndex entityIdx, string group, string part, int slotZeroBase, string materialResUUID, UGCSkeletonAvatarSystem avatarSystem)
	{
		return false;
	}

	public bool Reset(EntityIndex entityIdx, string group, string part, int slotZeroBase, UGCSkeletonAvatarSystem avatarSystem)
	{
		return false;
	}

	public bool ResetGroup(EntityIndex entityIdx, string group, UGCSkeletonAvatarSystem avatarSystem)
	{
		return false;
	}

	public bool TryGet(EntityIndex entityIdx, string group, string part, int slotZeroBase, out string materialResUUID)
	{
		materialResUUID = null;
		return false;
	}

	public void ApplyToPart(EntityIndex entityIdx, string group, string part, Renderer renderer, UGCSkeletonAvatarSystem avatarSystem = null)
	{
	}

	internal Material LookupForCombine(EntityIndex entityIdx, UGCSkeletonAvatarSystem avatarSystem, SkinnedMeshRenderer renderer, int subMeshIndex)
	{
		return null;
	}

	public void ClearByEntity(EntityIndex entityIdx)
	{
	}

	public void Destroy()
	{
	}

	private void AddToPartIndex(OverrideKey key)
	{
	}

	private void RemoveFromPartIndex(OverrideKey key)
	{
	}

	private void LoadMaterialAsync(string materialResUUID, Action<UGCMaterial> onLoaded)
	{
	}

	private void DecRefMaterial(string materialResUUID)
	{
	}

	private void ApplySlot(OverrideKey key, Renderer renderer, int slotZeroBase, UGCMaterial mat)
	{
	}

	private void RestoreDefaultSlot(OverrideKey key, Renderer renderer, int slotZeroBase)
	{
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCFFPlayerAvatarCache : MonoBehaviour
{
	public class UGCFFPlayerAvatarCacheItem
	{
		public int instanceID;

		public Transform self;

		public Transform parent;

		public Vector3 localPosition;

		public Vector3 localScale;

		public Quaternion localRotation;

		public void BackupTransform()
		{
		}

		public void RestoreTransform()
		{
		}
	}

	private Dictionary<int, List<UGCFFPlayerAvatarCacheItem>> m_cache;

	public static UGCFFPlayerAvatarCache Instance()
	{
		return null;
	}

	public bool IsHavePlayerAvatarPushed(int playerID)
	{
		return false;
	}

	public void PopFFPlayerAvatar(int playerID, Transform parent)
	{
	}

	public void PushFFPlayerAvatar(int playerID, GameObject go)
	{
	}

	private UGCFFPlayerAvatarCacheItem RestoreBoneTree(List<UGCFFPlayerAvatarCacheItem> items, Transform parent)
	{
		return null;
	}

	private void BackupBoneTree(List<UGCFFPlayerAvatarCacheItem> items, UGCFFPlayerAvatarCacheItem parentItem)
	{
	}
}

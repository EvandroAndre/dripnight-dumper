using System;
using UnityEngine;

namespace PrefabEvolution;

public class PEPrefabScript : MonoBehaviour, ISerializationCallbackReceiver
{
	public static class EditorBridge
	{
		public static Action<PEPrefabScript> OnValidate;

		public static Func<GameObject, string> GetAssetGuid;

		public static Func<string, GameObject> GetAssetByGuid;
	}

	private class PrefabInternalData
	{
		private readonly PEExposedProperties Properties;

		private readonly PELinkage Links;

		private readonly PEModifications Modifications;

		private readonly string ParentPrefabGUID;

		private readonly string PrefabGUID;

		public PrefabInternalData(PEPrefabScript script)
		{
		}

		public void Fill(PEPrefabScript script)
		{
		}
	}

	public PEExposedProperties Properties;

	public PELinkage Links;

	public PEModifications Modifications;

	public string ParentPrefabGUID;

	public string PrefabGUID;

	private PrefabInternalData _prefabInternalData;

	private Action m_OnBuildModifications;

	public GameObject ParentPrefab
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject Prefab
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action OnBuildModifications
	{
		add
		{
		}
		remove
		{
		}
	}

	private void OnValidate()
	{
	}

	public void InvokeOnBuildModifications()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	private void ClearInternalData()
	{
	}
}

using System;
using System.Collections.Generic;
using COW.GamePlay;
using message;

namespace COW.Gameplay.UGC;

public class EditorEntityData
{
	private enum ECategory
	{
		ForInstance,
		ForType
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<IPIFNFDIIKK> _003C_003E9__38_0;

		public static Func<IBILCDHHNHM, long> _003C_003E9__39_0;

		internal bool _003CGetEntityCustomAttributes_003Eb__38_0(IPIFNFDIIKK rep)
		{
			return false;
		}

		internal long _003CGetInstanceEntityCustomAttributesByConfig_003Eb__39_0(IBILCDHHNHM item)
		{
			return 0L;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string entityID;

		internal bool _003CRemoveEntity_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public string entityType;

		internal bool _003CHasEntityOfType_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string entityID;

		public string entityType;

		internal bool _003CHasEntity_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}

		internal bool _003CHasEntity_003Eb__1(INAMDLOFOHF x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string entityID;

		internal bool _003CHasEntity_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string entityID;

		internal bool _003CGetEntityData_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public string entityType;

		internal bool _003CGetInstanceEntityData_003Eb__0(INAMDLOFOHF data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public long componentID;

		internal bool _003CGetInstanceEntityDataByComponetID_003Eb__0(INAMDLOFOHF data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string entityType;

		internal bool _003CGetEntityDataOnType_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public Func<INAMDLOFOHF, bool> selector;

		internal bool _003CFindEntityInternal_003Eb__0(INAMDLOFOHF x)
		{
			return false;
		}
	}

	public const string ENTITYID_FOR_TYPE = "forType";

	private readonly Dictionary<int, List<INAMDLOFOHF>> m_EntityData;

	public bool IsLoadTemplate;

	public List<INAMDLOFOHF> TemplateEntityData;

	public Dictionary<string, string> TemplateEntityMapping;

	public HashSet<string> TempEntityIDs;

	public HashSet<string> DeletedEntityIDs;

	public bool ImportAllEntityDataForEditor(List<INAMDLOFOHF> dataToImport)
	{
		return false;
	}

	public void ClearGraphBinding(Func<string, bool> containsFunc)
	{
	}

	public List<INAMDLOFOHF> ExportAllEntityDataForEditor()
	{
		return null;
	}

	public List<PLMKOPJMIEP> ExportAllEntityDataForRuntime()
	{
		return null;
	}

	public bool AddEntity(string entityType, string entityID)
	{
		return false;
	}

	public bool RemoveEntity(string entityID)
	{
		return false;
	}

	public void MarkForDelete(string entityID)
	{
	}

	public void MarkForUnDelete(string entityID)
	{
	}

	private bool RemoveEntityInternal(List<INAMDLOFOHF> entityList, Func<INAMDLOFOHF, bool> selector)
	{
		return false;
	}

	public bool HasEntityOfType(string entityType)
	{
		return false;
	}

	public bool HasEntity(string entityType, string entityID)
	{
		return false;
	}

	public bool HasEntity(string entityID)
	{
		return false;
	}

	public bool AddEntityData(INAMDLOFOHF entityData)
	{
		return false;
	}

	private void ExpandTypeID2Components(INAMDLOFOHF entityData)
	{
	}

	public long[] GetExpandComponentsID(long[] typeIDs)
	{
		return null;
	}

	public INAMDLOFOHF GetEntityData(string entityID)
	{
		return null;
	}

	public List<INAMDLOFOHF> GetInstanceEntityData(string entityType)
	{
		return null;
	}

	public List<INAMDLOFOHF> GetInstanceEntityDataByComponetID(long componentID)
	{
		return null;
	}

	public INAMDLOFOHF GetEntityDataOnType(string entityType)
	{
		return null;
	}

	public List<INAMDLOFOHF> GetAllInstanceEntityDataForInstance()
	{
		return null;
	}

	public void RemoveAllEntityData()
	{
	}

	private int FindEntityInternal(List<INAMDLOFOHF> entityList, Func<INAMDLOFOHF, bool> selector)
	{
		return 0;
	}

	public bool AddBindingOnType(string entityType, string graphID)
	{
		return false;
	}

	public bool AddBinding(string entityID, string graphID)
	{
		return false;
	}

	public bool RemoveBindingOnType(string entityType, string graphID)
	{
		return false;
	}

	public bool RemoveBinding(string entityID, string graphID)
	{
		return false;
	}

	public bool HasAnyBinding(string entityID)
	{
		return false;
	}

	public INAMDLOFOHF GetTemplateEntityData(string graphID)
	{
		return null;
	}

	public INAMDLOFOHF GetOwnerEntityData(string graphID)
	{
		return null;
	}

	public List<IPIFNFDIIKK> GetEntityCustomAttributes(string entityID)
	{
		return null;
	}

	public List<IPIFNFDIIKK> GetInstanceEntityCustomAttributesByConfig(string entityID, AOKBGKNKKLJ config)
	{
		return null;
	}

	public static string GetLevelObjectLogicEntityType(SceneEditPrefabConfigData prefabConfigData)
	{
		return null;
	}

	public static string GetUniqueLogicEntityID()
	{
		return null;
	}

	public static PLMKOPJMIEP CloneEntityData(PLMKOPJMIEP entityData)
	{
		return null;
	}

	public void RemoveReduntEntities()
	{
	}

	public bool AddComponent(string entityID, long componentID)
	{
		return false;
	}

	public bool RemoveComponent(string entityID, long componentID)
	{
		return false;
	}

	private void InitializeComponentRepDataItem(INAMDLOFOHF entityData, long componentID)
	{
	}

	private SceneEditObjectBase CreateTemporaryObjectForInitialization(INAMDLOFOHF entityData)
	{
		return null;
	}

	private void RemoveComponentRepDataItem(INAMDLOFOHF entityData, long componentID)
	{
	}
}

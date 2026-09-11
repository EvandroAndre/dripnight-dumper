using System.Collections.Generic;
using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCCustomLevelObjectEditorSetting
{
	public class SettingData
	{
		public List<PrefabData> Prefabs;

		internal Dictionary<string, PrefabData> m_PrefabMapping;

		public bool FromJsonData()
		{
			return false;
		}

		public bool TryGetPrefabData(string prefabUUID, out PrefabData prefabData)
		{
			prefabData = null;
			return false;
		}
	}

	public class PrefabData
	{
		public string PrefabName;

		public string PrefabUUID;

		public string ItemTipsLocKey;

		public int Cost;

		public JsonData SelectionRange;

		public JsonData SelectionCenter;

		public string IconResID;

		public string EntityType;

		public JsonData EntityData;

		public int Numlimit;

		public string IconUrl;

		public int OptionID;

		public bool AllowBatchCombine;

		private long m_ComponentID;

		private Vector3 m_SelectionRange;

		private Vector3 m_SelectionCenter;

		public bool FromJsonData(SettingData context)
		{
			return false;
		}

		public bool TryGetSelectionRange(out Vector3 selectionRange)
		{
			selectionRange = default(Vector3);
			return false;
		}

		private bool BuildSelectionRange()
		{
			return false;
		}

		public bool TryGetSelectionCenter(out Vector3 selectionCenter)
		{
			selectionCenter = default(Vector3);
			return false;
		}

		private bool BuildSelectionCenter()
		{
			return false;
		}

		private bool BuildVector3(JsonData jsonData, out Vector3 result)
		{
			result = default(Vector3);
			return false;
		}
	}
}

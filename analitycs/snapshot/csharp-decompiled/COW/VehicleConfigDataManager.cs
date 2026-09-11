using System;
using System.Collections.Generic;
using GCommon;
using LitJson;
using UnityEngine;

namespace COW;

public class VehicleConfigDataManager : SingletonModule<VehicleConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ImporterFunc<double, float> _003C_003E9__9_0;

		public static ImporterFunc<string, BoxCollider> _003C_003E9__9_1;

		public static ImporterFunc<string, Vector3> _003C_003E9__9_2;

		internal float _003CLoadAndStoreConfigData_003Eb__9_0(double input)
		{
			return 0f;
		}

		internal BoxCollider _003CLoadAndStoreConfigData_003Eb__9_1(string input)
		{
			return null;
		}

		internal Vector3 _003CLoadAndStoreConfigData_003Eb__9_2(string input)
		{
			return default(Vector3);
		}
	}

	public const bool CacheConfigs = true;

	private Dictionary<uint, VehicleConfigDataMap> m_Dic;

	private uint m_CurrentDataId;

	private VehicleConfigDataMap m_CurrentData;

	private VehicleConfigDataMap m_DefaultData;

	public VehicleConfigData GetConfigData(uint mapId, uint modeId, int vehId)
	{
		return null;
	}

	internal VehicleConfigDataMap GetConfigData(uint mapId, uint modeId)
	{
		return null;
	}

	private VehicleConfigDataMap LoadAndStoreConfigData(uint id)
	{
		return null;
	}

	private VehicleConfigDataMap LoadAndStoreDefaultConfigData()
	{
		return null;
	}

	private VehicleConfigDataMap LoadAndStoreConfigData(ResourceID resID)
	{
		return null;
	}

	public void Clear()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}

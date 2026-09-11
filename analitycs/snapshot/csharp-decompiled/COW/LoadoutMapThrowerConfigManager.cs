using System;
using System.Collections.Generic;
using GCommon;
using LitJson;
using UnityEngine;

namespace COW;

public class LoadoutMapThrowerConfigManager : SingletonModule<LoadoutMapThrowerConfigManager>
{
	public class LoadoutMapThrowerConfigItem
	{
		public int TeamIndex;

		public List<Vector3> Position;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LoadoutMapThrower> _003C_003E9__12_0;

		internal int _003CGetCurCanUseMapThrowerItems_003Eb__12_0(LoadoutMapThrower a, LoadoutMapThrower b)
		{
			return 0;
		}
	}

	private CSVAsyncDataMap<uint, LoadoutMapThrower> m_DictIdToConfig;

	private List<LoadoutMapThrower> m_CanUseConfig;

	private string m_CurMapName;

	private Dictionary<int, List<LoadoutMapThrowerConfigItem>> m_InGameMapThrowerPointDict;

	private float m_OuterRadius;

	public Vector3 MapThrowerPosition;

	public float OuterRadius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public List<LoadoutMapThrower> GetCurCanUseMapThrowerItems()
	{
		return null;
	}

	public LoadoutMapThrower GetMapThrowerConfigByIndex(uint index)
	{
		return null;
	}

	public LoadoutMapThrower GetMapThrowerConfigByType(uint subType)
	{
		return null;
	}

	public List<Vector3> GetMapThrowerPoint(int zoneIndex, int teamIndex)
	{
		return null;
	}

	private void InitInGameMapThrowerPointConfig(string mapName)
	{
	}

	private Vector3 JsonData2Vector3(JsonData position)
	{
		return default(Vector3);
	}

	public static bool CheckMapThrowerValid()
	{
		return false;
	}

	public static bool IsMapLoadout(uint subType)
	{
		return false;
	}
}

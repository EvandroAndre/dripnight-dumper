using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourceLoadChunk
{
	public class PckFileItem
	{
		public string m_pckUUID;

		public bool m_isLoaded;
	}

	private bool m_isLoaded;

	private List<PckFileItem> m_pckFileList;

	private DEEOIEHKGLM _003CPolicyData_003Ek__BackingField;

	public DEEOIEHKGLM PolicyData
	{
		get
		{
			return _003CPolicyData_003Ek__BackingField;
		}
		set
		{
			_003CPolicyData_003Ek__BackingField = value;
		}
	}

	public void Init(DEEOIEHKGLM policyData)
	{
	}

	private Vector3 ToVector3(KCEOCGOLEAD vec)
	{
		return default(Vector3);
	}

	private bool IsInArea(Vector3 playerPos, KCEOCGOLEAD start, KCEOCGOLEAD end)
	{
		return false;
	}

	public bool Load()
	{
		return false;
	}

	public bool Unload()
	{
		return false;
	}

	private void LoadPck(PckFileItem pckInfo)
	{
	}

	private void UnloadPck(PckFileItem pckInfo)
	{
	}

	private bool LoadFileFromLocal(string localPath, out byte[] content)
	{
		content = null;
		return false;
	}
}

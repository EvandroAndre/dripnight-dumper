using System.Collections.Generic;
using COW;
using UnityEngine;

public class ABSceneGOInfo
{
	public int m_id;

	public int m_prefabID;

	public Vector3 m_pos;

	public Quaternion m_rotation;

	public Vector3 m_scale;

	public string m_previewName;

	public List<ABSceneLightMapInfo> m_lightmapInfoList;

	public ABLevelObjectInfo LevelObjectInfo;

	public List<AlterationInfo> m_alterations;

	public ABSceneGOInfo(int id, int prefabid, Vector3 pos, Quaternion rotation, Vector3 scale, string previewname, List<ABSceneLightMapInfo> lightmapInfoList)
	{
	}

	public ABSceneGOInfo(int prefabid, Vector3 pos, Quaternion rotation, Vector3 scale, string previewname, List<ABSceneLightMapInfo> lightmapInfoList)
	{
	}

	public static bool IsSame(ABSceneGOInfo a, ABSceneGOInfo b)
	{
		return false;
	}

	public static bool IsSameExceptID(ABSceneGOInfo a, ABSceneGOInfo b)
	{
		return false;
	}
}

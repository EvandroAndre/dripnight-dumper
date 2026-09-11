using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;

namespace COW;

public class MapPatchUtil
{
	public const int PatchBaseIndexGap = 10000000;

	public const int SubPatchBaseIndexGap = 100000;

	public const string MapPatchConfigName = "mappatchconfig.csv";

	private const string m_MapPatchConfigABName = "mappatchconfig_";

	public static string GetMapPatchConfigABName(ResDownloadType downloadType)
	{
		return null;
	}

	public static StreamPrefabSource StreamPrefabIdToIndex(int prefabID, out int patchIndex, out int abPathIndex)
	{
		patchIndex = default(int);
		abPathIndex = default(int);
		return StreamPrefabSource.PrototypicalScene;
	}

	public static int GetPatchBaseID(StreamPrefabSource patchType, int patchIndex)
	{
		return 0;
	}

	public static List<CSVBaseData> LoadMapPatchDefCSV(string mapPatchConfigABName)
	{
		return null;
	}

	public static Transform FindNodesRecursive(Transform parent, string[] pathSegments, int index, Vector3 targetPos)
	{
		return null;
	}

	public static string ReadString(BinaryReader binReader)
	{
		return null;
	}

	public static List<ABSceneGOInfo> ReadListABSceneGOInfo(BinaryReader binReader, int formatVersion, bool needAlter = false)
	{
		return null;
	}

	public static List<int> ReadListInt(BinaryReader binReader)
	{
		return null;
	}

	public static List<string> ReadListString(BinaryReader binReader)
	{
		return null;
	}

	public static List<NonstreamData> ReadListNonstreamData(BinaryReader binReader)
	{
		return null;
	}

	public static List<NotInStreamerData> ReadListNotInStreamerData(BinaryReader binReader)
	{
		return null;
	}

	public static NotInStreamerLightmaps ReadNotInStreamerLightmaps(BinaryReader binReader)
	{
		return null;
	}
}

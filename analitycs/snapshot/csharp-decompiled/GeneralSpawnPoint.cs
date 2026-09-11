using COW.GamePlay;
using UnityEngine;
using message;

public class GeneralSpawnPoint : MonoBehaviour
{
	private uint GUID;

	public int ID;

	public KLFAKNMCCLO Type;

	public uint TypeBasedConfigID;

	public string UserData;

	public GeneralSpawnPoint[] ReferencedPoints;

	public GeneralSpawnPointSphereRegion[] SphereRegions;

	public GeneralSpawnPointBoxRegion[] BoxRegions;

	public bool ExportDirection => false;

	public string GetTypeNameNoPrefix()
	{
		return null;
	}

	public string GetUniqueSpawnPointName()
	{
		return null;
	}

	public bool IsUniversalIdentified()
	{
		return false;
	}

	public bool IsUniqueIdentifiedAmongType()
	{
		return false;
	}

	public void ResetIdentifier()
	{
	}

	public void ResetIdentifierAmongType()
	{
	}

	public void SetUniqueID(uint uniqueID)
	{
	}

	public void SetUniqueIDAmongType(int uniqueID)
	{
	}

	public uint GetUniqueID()
	{
		return 0u;
	}

	public int GetUniqueIDAmongType()
	{
		return 0;
	}

	public static int SortAscend(GeneralSpawnPoint a, GeneralSpawnPoint b)
	{
		return 0;
	}
}

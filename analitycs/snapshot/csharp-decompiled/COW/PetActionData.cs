using GCommon;

namespace COW;

public class PetActionData : CSVBaseData
{
	public uint ID;

	public int Type;

	public float Time;

	public int PetID;

	public int PetLevel;

	public string ResourceName;

	public ResourceID ActionSound;

	public ResourceID ActionMoodSound;

	public bool IsActive;

	public ResourceID AnimResource;

	public ResourceID ActionVFX;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}

using GCommon;

namespace COW;

public class AIClientData : CSVBaseData
{
	public int ID;

	public ResourceID InGameModel;

	public float BaseWalkSpeed;

	public float BaseRunSpeed;

	public ResourceID[] TransformLevelModels;

	public string AIName;

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

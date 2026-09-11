using GCommon;

namespace COW;

public class PreviewParticleData : CSVBaseData
{
	public int ID;

	public ResourceID previewRes;

	public float PosX;

	public float PosY;

	public float PosZ;

	public float RotX;

	public float RotY;

	public float RotZ;

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

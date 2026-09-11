using GCommon;

namespace COW;

public class WorkshopNPCACGenarate : CSVBaseData
{
	public int Seq;

	public string AnimResName;

	public string ClipName;

	public int ClipIndex;

	public float Speed;

	public bool IsLoop;

	public string ParentState;

	public bool StateLoop;

	public string Parent;

	public uint ParentUMA;

	public float Length;

	public float FadeInTime;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}

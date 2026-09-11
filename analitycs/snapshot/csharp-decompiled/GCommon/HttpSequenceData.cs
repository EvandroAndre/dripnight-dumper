namespace GCommon;

public class HttpSequenceData : CSVBaseData, IGetId
{
	public uint id;

	public string controllerType;

	public string[] cmdSequence;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}
}

using GCommon;

public class AvatarTransformData : CSVBaseData
{
	public enum ShowType
	{
		Normal,
		Collection
	}

	public uint ID;

	public ResourceID TransformerResId_1P;

	public ResourceID Transformer2ResId_1P;

	public ResourceID TransformerResId_3P;

	public ResourceID Transformer2ResId_3P;

	public bool isfemale;

	public ShowType showType;

	public ResourceID TransformVFXIngame1pStep1;

	public ResourceID TransformVFXIngame1pStep2;

	public ResourceID TransformVFXIngame3pStep1;

	public ResourceID TransformVFXIngame3pStep2;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public ResourceID GetInGameResourceId(bool isLocalPlayer, uint avatarTransformType = 0u)
	{
		return default(ResourceID);
	}

	public ResourceID GetLobbyResourceId(uint avatarTransformType = 0u)
	{
		return default(ResourceID);
	}

	public ResourceID GetTransformVFXResId(bool isLocalPlayer, uint avatarTransformType)
	{
		return default(ResourceID);
	}

	public ResourceID GetLobbyTransformVFXResId(uint avatarTransformType)
	{
		return default(ResourceID);
	}
}

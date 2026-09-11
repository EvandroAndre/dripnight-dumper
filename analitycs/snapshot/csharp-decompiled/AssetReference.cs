using System;

public sealed class AssetReference : Attribute
{
	private AssetRefType _003CRefType_003Ek__BackingField;

	public AssetRefType RefType
	{
		get
		{
			return _003CRefType_003Ek__BackingField;
		}
		private set
		{
			_003CRefType_003Ek__BackingField = value;
		}
	}

	public AssetReference(AssetRefType refType)
	{
	}
}

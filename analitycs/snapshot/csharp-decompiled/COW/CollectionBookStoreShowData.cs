using GCommon;

namespace COW;

public class CollectionBookStoreShowData : CSVBaseData, IGetId
{
	public uint HyperBookID;

	public ResourceID PreviewRes;

	public ResourceID AnimRes;

	private string _003CBookshelfCoverSpriteName_003Ek__BackingField;

	private ResourceID _003CBookshelfOpenRes_003Ek__BackingField;

	private ResourceID _003CContentRes_003Ek__BackingField;

	private ResourceID _003CContentDecorationNormalRes_003Ek__BackingField;

	private ResourceID _003CContentDecorationHiddenRes_003Ek__BackingField;

	private ResourceID _003CContentBackgroundNormalRes_003Ek__BackingField;

	private ResourceID _003CContentBackgroundHiddenRes_003Ek__BackingField;

	private ResourceID[] _003CContentMaterialNormalResArray_003Ek__BackingField;

	private ResourceID[] _003CContentMaterialHiddenResArray_003Ek__BackingField;

	public bool IsAnimDelete;

	public string CircleLightRoationItemCameraStr;

	public string CircleLightRoationAvatarCameraStr;

	public string BookshelfCoverSpriteName
	{
		get
		{
			return _003CBookshelfCoverSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CBookshelfCoverSpriteName_003Ek__BackingField = value;
		}
	}

	public ResourceID BookshelfOpenRes
	{
		get
		{
			return _003CBookshelfOpenRes_003Ek__BackingField;
		}
		private set
		{
			_003CBookshelfOpenRes_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentRes
	{
		get
		{
			return _003CContentRes_003Ek__BackingField;
		}
		private set
		{
			_003CContentRes_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentDecorationNormalRes
	{
		get
		{
			return _003CContentDecorationNormalRes_003Ek__BackingField;
		}
		private set
		{
			_003CContentDecorationNormalRes_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentDecorationHiddenRes
	{
		get
		{
			return _003CContentDecorationHiddenRes_003Ek__BackingField;
		}
		private set
		{
			_003CContentDecorationHiddenRes_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentBackgroundNormalRes
	{
		get
		{
			return _003CContentBackgroundNormalRes_003Ek__BackingField;
		}
		private set
		{
			_003CContentBackgroundNormalRes_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentBackgroundHiddenRes
	{
		get
		{
			return _003CContentBackgroundHiddenRes_003Ek__BackingField;
		}
		private set
		{
			_003CContentBackgroundHiddenRes_003Ek__BackingField = value;
		}
	}

	public ResourceID[] ContentMaterialNormalResArray
	{
		get
		{
			return _003CContentMaterialNormalResArray_003Ek__BackingField;
		}
		private set
		{
			_003CContentMaterialNormalResArray_003Ek__BackingField = value;
		}
	}

	public ResourceID[] ContentMaterialHiddenResArray
	{
		get
		{
			return _003CContentMaterialHiddenResArray_003Ek__BackingField;
		}
		private set
		{
			_003CContentMaterialHiddenResArray_003Ek__BackingField = value;
		}
	}

	public bool IsMaterialNormalResEmpty => false;

	public bool IsMaterialHiddenResEmpty => false;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
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

using GCommon;

namespace COW;

public class HyperBookHiddenPageData : CSVBaseData
{
	private uint _003CAwardID_003Ek__BackingField;

	private string _003CMaskIcon_003Ek__BackingField;

	private ResourceID _003CContentMaskVFX_003Ek__BackingField;

	public uint AwardID
	{
		get
		{
			return _003CAwardID_003Ek__BackingField;
		}
		private set
		{
			_003CAwardID_003Ek__BackingField = value;
		}
	}

	public string MaskIcon
	{
		get
		{
			return _003CMaskIcon_003Ek__BackingField;
		}
		private set
		{
			_003CMaskIcon_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentMaskVFX
	{
		get
		{
			return _003CContentMaskVFX_003Ek__BackingField;
		}
		private set
		{
			_003CContentMaskVFX_003Ek__BackingField = value;
		}
	}

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

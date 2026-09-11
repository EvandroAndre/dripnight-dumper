using GCommon;

namespace COW;

public class WorkShopSkillEditListData : CSVBaseData
{
	private string _003CSkillType_003Ek__BackingField;

	private bool _003CEnabled_003Ek__BackingField;

	public string SkillType
	{
		get
		{
			return _003CSkillType_003Ek__BackingField;
		}
		private set
		{
			_003CSkillType_003Ek__BackingField = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return _003CEnabled_003Ek__BackingField;
		}
		private set
		{
			_003CEnabled_003Ek__BackingField = value;
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

using GCommon;

namespace COW;

public class IngameQuickChatResponseItemIconData : CSVBaseData
{
	public uint m_ResponseIconType;

	private string _003CIconResId_003Ek__BackingField;

	public string IconResId
	{
		get
		{
			return _003CIconResId_003Ek__BackingField;
		}
		private set
		{
			_003CIconResId_003Ek__BackingField = value;
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

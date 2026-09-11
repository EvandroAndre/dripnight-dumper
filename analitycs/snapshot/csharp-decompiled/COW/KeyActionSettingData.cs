using GCommon;
using UnityEngine;

namespace COW;

public class KeyActionSettingData : CSVBaseData
{
	public int ID;

	public EKeyActionType KeyActionType;

	public string KeyActionName;

	public string KeyActionNameKey;

	public KeyCode DefaultKeyCode;

	public bool EnableModify;

	public bool ShowKeyCodeOnHud;

	public bool UnLockCursor;

	public bool EnableRepeat;

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

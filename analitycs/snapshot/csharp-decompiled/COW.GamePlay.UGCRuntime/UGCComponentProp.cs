using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCComponentProp
{
	public int SyncID;

	public long CmpID;

	public long ID;

	public string Name;

	public long Type;

	public UGCVarValueDataV2 DefaultValue;

	public uint Attributes;

	public ECmpPropAccessType GetAccessType()
	{
		return ECmpPropAccessType.ECmpPropAccessType_Unknown;
	}

	public bool IsOnlyServer()
	{
		return false;
	}

	public bool IsNeedMirror()
	{
		return false;
	}

	public bool IsReadOnly()
	{
		return false;
	}

	public bool IsObservable()
	{
		return false;
	}

	public bool IsAutoSave()
	{
		return false;
	}
}

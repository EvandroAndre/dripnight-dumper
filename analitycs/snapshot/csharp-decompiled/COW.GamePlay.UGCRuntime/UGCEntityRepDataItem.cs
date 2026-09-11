using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCEntityRepDataItem : IUGCObjectPoolItem
{
	public enum DataItemFlag
	{
		SKIP_SYNC,
		SMOOTH
	}

	public UGCEntityRepData owner;

	private UGCRuntime ugcRuntime;

	public bool onlyServer;

	public long propID;

	private long typeID;

	private UGCSimpleValue value;

	private UGCSimpleValue tempValueContainer;

	public bool isDirty;

	public int flag;

	public bool isDefaultValue;

	public UGCEntityRepDataItem Create(UGCRuntime runtime, UGCEntityRepData parent, long propID, long typeID, bool onlyServer, UGCVarValueDataV2 value)
	{
		return null;
	}

	public void LoadFromVarValueData(UGCRuntime runtime, long typeID, UGCVarValueDataV2 varData)
	{
	}

	public void Reset()
	{
	}

	public override string ToString()
	{
		return null;
	}

	private bool CheckIsDifferent(object oldObj, object newObj)
	{
		return false;
	}

	private void RefreshDirty(bool isChanged)
	{
	}

	public bool Set(UGCSimpleValue targetValue)
	{
		return false;
	}

	private bool SetObj(object targetValue)
	{
		return false;
	}

	private bool SetBool(bool targetValue)
	{
		return false;
	}

	private bool SetInt(int targetValue)
	{
		return false;
	}

	private bool SetInt64(long targetValue)
	{
		return false;
	}

	private bool SetFloat(float targetValue)
	{
		return false;
	}

	private bool SetVector2(Vector2 targetValue)
	{
		return false;
	}

	public bool SetVector3(Vector3 targetValue)
	{
		return false;
	}

	public bool SetQuaternion(Quaternion targetValue)
	{
		return false;
	}

	public bool SetLogicEntity(UGCLogicEntity targetValue)
	{
		return false;
	}

	public UGCLogicEntity GetLogicEntity()
	{
		return null;
	}

	public void SetFlag(DataItemFlag df, bool value)
	{
	}

	public bool GetFlag(DataItemFlag df)
	{
		return false;
	}

	public object Get()
	{
		return null;
	}

	public UGCSimpleValue GetRawValue()
	{
		return null;
	}

	public UGCSimpleValue GetTempValueContainer()
	{
		return null;
	}

	public void ResetDirty()
	{
	}

	public bool IsDirty()
	{
		return false;
	}

	public bool IsOnlyServer()
	{
		return false;
	}

	public long TypeID()
	{
		return 0L;
	}

	public long PropID()
	{
		return 0L;
	}

	public void AssignValue(object targetValue)
	{
	}

	internal void AssignValue(KEJFJKMAHNF propValue)
	{
	}

	public void AssignValue(UGCVarValueDataV2 propValue, bool fromRuntime = true)
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}

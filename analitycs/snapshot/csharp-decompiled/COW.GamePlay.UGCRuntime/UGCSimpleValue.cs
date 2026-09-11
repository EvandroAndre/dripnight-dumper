using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCSimpleValue : IUGCValue, IUGCObjectPoolItem
{
	private object value;

	private float floatValue;

	private long int64Value;

	private Vector4 vectorValue;

	private long valueType;

	private long defType;

	public static UGCSimpleValue NULL;

	private static List<object> emptyList;

	private static List<float> emptyListF;

	private static Dictionary<object, object> emptyDic;

	public long DefType => 0L;

	public static void Cleanup()
	{
	}

	public static implicit operator bool(UGCSimpleValue v)
	{
		return false;
	}

	public static implicit operator int(UGCSimpleValue v)
	{
		return 0;
	}

	public static implicit operator long(UGCSimpleValue v)
	{
		return 0L;
	}

	public static implicit operator float(UGCSimpleValue v)
	{
		return 0f;
	}

	public static implicit operator string(UGCSimpleValue v)
	{
		return null;
	}

	public static implicit operator UGCLogicEntity(UGCSimpleValue v)
	{
		return null;
	}

	public static implicit operator Vector2(UGCSimpleValue v)
	{
		return default(Vector2);
	}

	public static implicit operator Vector3(UGCSimpleValue v)
	{
		return default(Vector3);
	}

	public static implicit operator Quaternion(UGCSimpleValue v)
	{
		return default(Quaternion);
	}

	public static implicit operator List<object>(UGCSimpleValue v)
	{
		return null;
	}

	public static implicit operator List<float>(UGCSimpleValue v)
	{
		return null;
	}

	public static implicit operator Dictionary<object, object>(UGCSimpleValue v)
	{
		return null;
	}

	public void SetBool(bool value)
	{
	}

	public bool GetBool()
	{
		return false;
	}

	public void SetInt(int v)
	{
	}

	public int GetInt()
	{
		return 0;
	}

	public long GetInt64()
	{
		return 0L;
	}

	public void SetInt64(long v)
	{
	}

	public void SetFloat(float v)
	{
	}

	public float GetFloat()
	{
		return 0f;
	}

	public double GetDouble()
	{
		return 0.0;
	}

	public void SetVector3(Vector3 v)
	{
	}

	public void SetVector3(float x, float y, float z)
	{
	}

	public Vector3 GetVector3()
	{
		return default(Vector3);
	}

	public void SetQuaternion(Quaternion v)
	{
	}

	public Quaternion GetQuaternion()
	{
		return default(Quaternion);
	}

	public void SetVector2(Vector2 v)
	{
	}

	public void SetVector2(float x, float y)
	{
	}

	public Vector2 GetVector2()
	{
		return default(Vector2);
	}

	public void SetObj(object value)
	{
	}

	public object GetObj()
	{
		return null;
	}

	public object GetValue()
	{
		return null;
	}

	public MHJLOKOOGNB ValueType()
	{
		return MHJLOKOOGNB.Object;
	}

	public void Reset()
	{
	}

	public void CopyTo(UGCSimpleValue other)
	{
	}

	public UGCSimpleValue Create(long t)
	{
		return null;
	}

	public MHJLOKOOGNB GetCoreType()
	{
		return MHJLOKOOGNB.Object;
	}

	public bool IsInt()
	{
		return false;
	}

	public bool IsFloat()
	{
		return false;
	}

	public bool IsNumber()
	{
		return false;
	}

	public void _SetDirectly(object value)
	{
	}

	public void LoadFromVarValueData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
	}

	internal void LoadFromCommonParam(AJFJEGOPEPP p)
	{
	}
}

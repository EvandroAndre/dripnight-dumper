using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

[Serializable]
public abstract class CSVBaseData
{
	private static readonly object m_ObjCommonStringsSync;

	private static Dictionary<string, string> s_CommonStrings;

	public virtual bool UsingIndexedParseData => false;

	public static bool IsDefaultEmptyStringArray(string[] array)
	{
		return false;
	}

	public static bool IsDefaultEmptyResourceIDArray(ResourceID[] array)
	{
		return false;
	}

	public static bool IsDefaultEmptyUIntArray(uint[] array)
	{
		return false;
	}

	public virtual void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public virtual bool AfterParseData()
	{
		return false;
	}

	public virtual int GetIntKey()
	{
		return 0;
	}

	public virtual uint GetUIntKey()
	{
		return 0u;
	}

	public virtual string GetPrimaryKey()
	{
		return null;
	}

	public virtual string[] GetHeadColNames()
	{
		return null;
	}

	public virtual void ParseData(IIndexString ss, int[] index)
	{
	}

	public virtual void DeserializeData(MutableStringBinaryReader br)
	{
	}

	public virtual void PostDeserializeData()
	{
	}

	protected static Color32 ReadHexColor(string hex)
	{
		return default(Color32);
	}

	protected static Color ReadColor(string fieldName, string[] headers, string[] values)
	{
		return default(Color);
	}

	protected static Color ReadColor(string value)
	{
		return default(Color);
	}

	protected static float ReadFloat(string fieldName, string[] headers, string[] values, float defaultValue = 0f)
	{
		return 0f;
	}

	protected static int ReadInt(string fieldName, string[] headers, string[] values, int defaultValue = 0)
	{
		return 0;
	}

	protected static int ReadInt(string value, int defaultValue = 0)
	{
		return 0;
	}

	protected static uint ReadUInt(string fieldName, string[] headers, string[] values, uint defaultValue = 0u)
	{
		return 0u;
	}

	protected static uint ReadUInt(string value, uint defaultValue)
	{
		return 0u;
	}

	protected static uint ReadUInt(string value)
	{
		return 0u;
	}

	protected static byte ReadByte(string value)
	{
		return 0;
	}

	public static void ClearCommonStrings()
	{
	}

	protected static string ReadCommonString(string value)
	{
		return null;
	}

	protected static string ReadCommonString(string fieldName, string[] headers, string[] values, string defaultValue = null)
	{
		return null;
	}

	protected static string ReadString(string fieldName, string[] headers, string[] values, string defaultValue = null)
	{
		return null;
	}

	protected static string[] ReadStringArray(string fieldName, string[] headers, string[] values, string defaultValue = null, char InSplitChar = ',')
	{
		return null;
	}

	protected static uint[] ReadUIntArray(string fieldName, string[] headers, string[] values, uint defaultValue = 0u, char InSplitChar = ',')
	{
		return null;
	}

	protected static int[] ReadIntArray(string fieldName, string[] headers, string[] values, int defaultValue = 0, char InSplitChar = ',', bool IsEmptyLengthOne = true)
	{
		return null;
	}

	protected static long[] ReadLongArray(string fieldName, string[] headers, string[] values, int defaultValue = 0, char InSplitChar = ',')
	{
		return null;
	}

	protected static float[] ReadFloatArray(string value, char InSplitChar = '#', bool IsEmptyLengthOne = true)
	{
		return null;
	}

	protected static float[] ReadFloatArray(string fieldName, string[] headers, string[] values, char InSplitChar = '#', bool IsEmptyLengthOne = true)
	{
		return null;
	}

	protected static bool ReadBoolean(string fieldName, string[] headers, string[] values, bool defaultValue = false)
	{
		return false;
	}

	protected static bool[] ReadBooleanArray(string fieldName, string[] headers, string[] values, char InSplitChar = ',')
	{
		return null;
	}

	protected static bool ReadBoolean(string value)
	{
		return false;
	}

	protected static ResourceID ReadResourceID(string fieldName, string[] headers, string[] values, Type resVarType, bool needReflect = true)
	{
		return default(ResourceID);
	}

	protected static ResourceID ReadResourceID(string strResID, Type resVarType, bool needReflect = true)
	{
		return default(ResourceID);
	}

	protected static ResourceID[] ReadResourceIDArray(string fieldName, string[] headers, string[] values, Type resVarType, char InSplitChar = ',')
	{
		return null;
	}

	protected static string GetFieldValueWithFieldName(string fieldName, string[] headers, string[] values, string defaultValue = null)
	{
		return null;
	}

	public static implicit operator bool(CSVBaseData exists)
	{
		return false;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace GCommon;

public class MutableStringBinaryReader : BinaryReader
{
	private MutableString m_Str;

	private byte[] m_SrcBytes;

	private Dictionary<string, string> m_CommonStrings;

	private unsafe byte* m_SrcBytesPtr;

	private bool isNativeStream;

	public MutableStringBinaryReader(Stream input)
		: base(null)
	{
	}

	private void Init()
	{
	}

	public string ReadStringNoAquire()
	{
		return null;
	}

	public void SkipString()
	{
	}

	public void SkipBinaryHeader()
	{
	}

	public ResourceID ReadResourceID(Type resVarType)
	{
		return default(ResourceID);
	}

	public string ReadLoc()
	{
		return null;
	}

	public Vector3 ReadVector3()
	{
		return default(Vector3);
	}

	public Vector3 ReadVector3(float x, float y, float z, VectorCalculateType calculateType = VectorCalculateType.None)
	{
		return default(Vector3);
	}

	public Vector4 ReadVector4()
	{
		return default(Vector4);
	}

	public string ReadCommonString()
	{
		return null;
	}

	public void CRC32WithStringPrefix(out string hashString, out int hash)
	{
		hashString = null;
		hash = default(int);
	}

	public new int Read7BitEncodedInt()
	{
		return 0;
	}

	public int[] ReadIntArray(bool defaultReturnEmpty = false)
	{
		return null;
	}

	public uint[] ReadUIntArray(bool defaultReturnEmpty = false)
	{
		return null;
	}

	public float[] ReadFloatArray(bool defaultReturnEmpty = false)
	{
		return null;
	}

	public bool[] ReadBooleanArray(bool defaultReturnEmpty = false)
	{
		return null;
	}

	public string[] ReadStringArray(bool defaultReturnEmpty = false)
	{
		return null;
	}

	public ResourceID[] ReadResourceIDArray(Type resVarType, bool defaultReturnNull = false, bool defaultReturnEmpty = false)
	{
		return null;
	}
}

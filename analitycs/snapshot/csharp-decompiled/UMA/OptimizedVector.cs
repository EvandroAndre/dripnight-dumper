using UnityEngine;

namespace UMA;

public static class OptimizedVector
{
	private static int FloatToByte(float x)
	{
		return 0;
	}

	private static float ByteToFloat(uint x)
	{
		return 0f;
	}

	public static uint ConvertToUInt(ref Vector3 normal)
	{
		return 0u;
	}

	public static uint ConvertToUInt(ref Vector4 normal)
	{
		return 0u;
	}

	public static void ConvertToVector4(uint data, out Vector4 res)
	{
		res = default(Vector4);
	}

	public static void ConvertToVector3(uint data, out Vector3 res)
	{
		res = default(Vector3);
	}

	public static Vector3[] ConvertToVector3s(uint[] ops)
	{
		return null;
	}

	public static Vector4[] ConvertToVector4s(uint[] ops)
	{
		return null;
	}

	public static uint[] ConvertFromVector4sToUInts(Vector4[] vs)
	{
		return null;
	}

	public static uint[] ConvertFromVector3sToUInts(Vector3[] vs)
	{
		return null;
	}
}

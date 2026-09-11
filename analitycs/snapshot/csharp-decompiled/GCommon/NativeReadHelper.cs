using System.IO;
using System.Text;
using UnityEngine;

namespace GCommon;

public class NativeReadHelper
{
	private static readonly string USE_NATIVE_STREAM;

	private static bool UseNativeStream;

	public static CustomStreamReader GetCustomStreamReader(TextAsset textAsset, Encoding encoding)
	{
		return null;
	}

	private static bool GetUseNativeStreamPref()
	{
		return false;
	}

	private static void SetUseNativeStreamPref(bool useNative)
	{
	}

	public static void InitUseNativeStream()
	{
	}

	public static void InitUseNativeStreamByGameVar(bool useNative)
	{
	}

	public static StreamReader GetStreamReader(TextAsset textAsset, int minLength, out int length)
	{
		length = default(int);
		return null;
	}
}

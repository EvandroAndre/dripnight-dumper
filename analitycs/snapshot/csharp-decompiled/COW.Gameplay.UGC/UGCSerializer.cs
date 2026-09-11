using System.IO;
using ProtoBuf;
using message;

namespace COW.Gameplay.UGC;

public static class UGCSerializer
{
	public static bool ToBytes<T>(T data, out byte[] dataBytes)
	{
		dataBytes = null;
		return false;
	}

	public static bool FromBytes<T>(byte[] dataBytes, out T data)
	{
		data = default(T);
		return false;
	}

	public static bool ToVersionControlProtoData<T>(T data, byte[] downloadDesc, out MFMLHNJCNGB vcData)
	{
		vcData = null;
		return false;
	}

	public static bool ToProtoBufBytes<T>(T data, out byte[] dataBytes)
	{
		dataBytes = null;
		return false;
	}

	public static bool FromProbufBytes<T>(byte[] dataBytes, out T data, bool logError = true, T cachedObject = default(T))
	{
		data = default(T);
		return false;
	}

	public static bool FromProtobufBytes<T>(byte[] dataBytes, int startIndex, int length, out T data, bool logError = true, T cachedObject = default(T))
	{
		data = default(T);
		return false;
	}

	public static bool FromProtobufByteStream<T>(Stream stream, out T data, bool logError = true, PrefixStyle prefixStyle = PrefixStyle.Fixed32BigEndian)
	{
		data = default(T);
		return false;
	}

	private static bool CheckStreamDataSufficiency(Stream stream, PrefixStyle prefixStyle, bool logError)
	{
		return false;
	}

	private static bool TryReadBase128Length(Stream stream, out int length, out int bytesRead, bool logError)
	{
		length = default(int);
		bytesRead = default(int);
		return false;
	}

	private static int GetPrefixLength(PrefixStyle prefixStyle)
	{
		return 0;
	}

	private static int ParsePrefixLength(byte[] prefixBytes, PrefixStyle prefixStyle)
	{
		return 0;
	}

	public static bool ToProtobufByteStream<T>(T data, Stream stream, bool logError = true, PrefixStyle prefixStyle = PrefixStyle.Fixed32BigEndian)
	{
		return false;
	}

	public static bool ToJson<T>(T data, out string dataString, bool prettyPrint = true)
	{
		dataString = null;
		return false;
	}

	public static bool FromJson<T>(string dataString, out T data)
	{
		data = default(T);
		return false;
	}

	public static bool ToJsonBytes<T>(T data, out byte[] dataBytes)
	{
		dataBytes = null;
		return false;
	}

	public static bool FromJsonBytes<T>(byte[] dataBytes, out T data)
	{
		data = default(T);
		return false;
	}
}

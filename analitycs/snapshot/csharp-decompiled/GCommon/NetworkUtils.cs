using System;
using System.Net;

namespace GCommon;

public static class NetworkUtils
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<int, string> _003C_003E9__4_0;

		internal string _003CParseUDPHeadSecret_003Eb__4_0(int v)
		{
			return null;
		}
	}

	public static bool UseResolveDNS;

	public static string VerAddrHost;

	public static bool ParseUrlAddrAndPort(string url, out string outAddr, out int outPort)
	{
		outAddr = null;
		outPort = default(int);
		return false;
	}

	public static byte[] HexStringToByte(string hexString)
	{
		return null;
	}

	public static int[] ParseUDPHeadSecret(string udpHeadSecret)
	{
		return null;
	}

	public static IPAddress GetAddrByHostName(string serverAddr, PlatformUtility.NetworkInterface network = PlatformUtility.NetworkInterface.None)
	{
		return null;
	}

	public static bool IsValidUrl(string url)
	{
		return false;
	}

	public static bool IsIPv6Only(out byte[] prefix, PlatformUtility.NetworkInterface network = PlatformUtility.NetworkInterface.None)
	{
		prefix = null;
		return false;
	}

	public static IPAddress IPv4ToIPv6ForNAT64(IPAddress ipv4, byte[] prefix)
	{
		return null;
	}

	public static PlatformUtility.NetworkInterface ENetworkType2NetworkInterface(ENetworkType networkType)
	{
		return PlatformUtility.NetworkInterface.WIFI;
	}
}

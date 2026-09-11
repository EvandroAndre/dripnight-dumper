using GCommon;

namespace COW;

public class GPUInfo : CSVBaseData
{
	public class GPUType
	{
		public const int unknown = 0;

		public const int Adreno = 1;

		public const int Immortalis = 2;

		public const int Mali = 3;

		public const int IMG_BXM = 4;

		public const int PowerVR = 6;

		public const int Xclipse = 7;
	}

	public string gpu_name;

	public int quality;

	public int gpu_type;

	public string serial;

	public string serial_ex;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static GPUInfo GetGPUInfo(string strGpuName)
	{
		return null;
	}

	public static bool isAdreno(string strGpuName, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static bool isImmortalis(string strGpuName, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static bool isMali(string strGpuName, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static bool isIMG_BXM(string strGpuName, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static bool isPowerVR(string strGpuName, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static bool isXclipse(string strGpuName, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static bool GetSerialAndSuffix(string strGpuName, int index, out string serial, out string suffix)
	{
		serial = null;
		suffix = null;
		return false;
	}

	public static int isSameGpu(GPUInfo left, GPUInfo right)
	{
		return 0;
	}

	public static bool isSameGpuSerial(string left, string right)
	{
		return false;
	}

	public string WriteLine()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}

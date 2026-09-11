using GCommon;

namespace COW;

public class CPUInfo : CSVBaseData
{
	public class CPUType
	{
		public const int unknown = 0;

		public const int Snapdragon = 1;

		public const int Mediatek = 2;

		public const int Hisilicon = 3;

		public const int Samsung = 4;

		public const int Unisoc = 5;
	}

	public string cpu_name;

	public string cpu_model;

	public int quality;

	public int cpu_type;

	public string serial;

	public string serial_ex;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static CPUInfo GetCPUInfo(string strCpuName)
	{
		return null;
	}

	public static bool isSnapdragon(string strCpuName, out string serial, out string model)
	{
		serial = null;
		model = null;
		return false;
	}

	public static bool isMediatek(string strCpuName, out string serial, out string serial_ex, out string model)
	{
		serial = null;
		serial_ex = null;
		model = null;
		return false;
	}

	public static bool isHisilicon(string strCpuName, out string serial, out string model)
	{
		serial = null;
		model = null;
		return false;
	}

	public static bool isSamsung(string strCpuName, out string serial, out string model)
	{
		serial = null;
		model = null;
		return false;
	}

	public static bool isUnisoc(string strCpuName, out string serial, out string model)
	{
		serial = null;
		model = null;
		return false;
	}

	public static int isSameCpu(CPUInfo left, CPUInfo right)
	{
		return 0;
	}

	public static int isSameCpuSerial(string left, string right)
	{
		return 0;
	}

	public static bool GetCPUSerial(string strCpuName, string flag, out string serial)
	{
		serial = null;
		return false;
	}

	public string WriteLine()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}

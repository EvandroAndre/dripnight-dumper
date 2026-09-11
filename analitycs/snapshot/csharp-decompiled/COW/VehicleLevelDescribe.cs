using GCommon;

namespace COW;

public class VehicleLevelDescribe : CSVBaseData
{
	public uint RouteID;

	public string VehicleIcon;

	public string Name;

	public string Brief;

	public string Lv0Desc;

	public string param0;

	public string Lv1Desc;

	public string param1;

	public string Lv2Desc;

	public string param2;

	public string Lv3Desc;

	public string param3;

	public string Lv4Desc;

	public string param4;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}

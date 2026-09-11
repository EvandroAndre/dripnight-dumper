using System.IO;

namespace GCommon;

internal class S2C_Hello_Res
{
	public string SessionKey;

	public ushort OrderID;

	public ushort RequiredID;

	public string Addr;

	public void UnSerialize(BinaryReader reader)
	{
	}
}

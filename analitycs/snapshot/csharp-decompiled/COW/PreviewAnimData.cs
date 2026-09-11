using GCommon;
using UnityEngine;

namespace COW;

public class PreviewAnimData : CSVBaseData
{
	public uint ItemID;

	public string FrontEndPreview;

	public Vector3 Position;

	public Vector3 Rotation;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class FinalShotPreviewConfig : CSVBaseData
{
	public Vector4 SpecialViewPort;

	public Vector3 VFXPosition;

	public Vector3 VFXScale;

	public Vector3 VFXRotation;

	public Vector3 AvatarPosition;

	public Vector3 AvatarScale;

	public Vector3 AvatarRotation;

	public FrontendPreviewType FrontEndPreviewType;

	public uint FinalShotId;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}

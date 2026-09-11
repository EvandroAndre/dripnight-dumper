using UnityEngine;

public class CameraReflection : MonoBehaviour
{
	public enum SizeEnum
	{
		Sixteenth = 0x40,
		Eighth = 0x80,
		Quarter = 0x100,
		Half = 0x200,
		One = 0x400
	}

	public enum ReflectDistrict
	{
		Sea,
		Dam,
		UnderDam
	}

	public const int DISTRICT_COUNT = 3;

	public CameraClearFlags clearFlag;

	public Color backgroundColor;

	public SizeEnum sizeType;
}

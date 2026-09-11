using GCommon;

namespace COW;

public class PhotoFreeCameraSetting : CSVBaseData
{
	public float CloseMax;

	public float CameraMovingSpeed;

	public float MaxDistance;

	public float WarningDistance;

	public float DownLimit;

	public float AboveLimit;

	public float FarMax;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorSwitchCameraClip : UGCTimelineEditorKeyClip
{
	public const string ARGUMENT_CAMERA_ACTOR_NAME = "CameraActorName";

	public string CameraActorName => null;

	public override string ClipName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Destroy()
	{
	}

	public override long CheckValidateKeyFrame()
	{
		return 0L;
	}

	public string _003C_003EiFixBaseProxy_get_ClipName()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_set_ClipName(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public new long _003C_003EiFixBaseProxy_CheckValidateKeyFrame()
	{
		return 0L;
	}
}

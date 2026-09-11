namespace COW.Gameplay.UGC;

public class UGCTimelineEditorAlongPathClip : UGCTimelineEditorSpeedKeyClip
{
	public const string ARGUMENT_PATH_ACTOR_NAME = "PathActorName";

	public string PathActorName => null;

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

	public override float Duration
	{
		set
		{
		}
	}

	public override float Speed
	{
		get
		{
			return 0f;
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

	public void _003C_003EiFixBaseProxy_set_Duration(float P0)
	{
	}

	public float _003C_003EiFixBaseProxy_get_Speed()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_set_Speed(float P0)
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

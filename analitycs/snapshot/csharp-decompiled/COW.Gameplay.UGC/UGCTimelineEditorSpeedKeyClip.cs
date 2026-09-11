namespace COW.Gameplay.UGC;

public class UGCTimelineEditorSpeedKeyClip : UGCTimelineEditorKeyClip
{
	public const string ARGUMENT_NAME_SPEED = "Speed";

	public virtual float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override float ClipMinDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float _003C_003EiFixBaseProxy_get_ClipMinDuration()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_set_ClipMinDuration(float P0)
	{
	}
}

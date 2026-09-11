namespace COW.Gameplay.UGC;

public class UGCTimelineEditorAnimationKeyClip : UGCTimelineEditorSpeedKeyClip
{
	public const string ARGUMENT_NAME_ANIMATIONCLIPID = "AnimationClipID";

	public const string ARGUMENT_NAME_RESUID = "ResUID";

	public const string ARGUMENT_NAME_ANIMATIONTYPE = "AnimationType";

	public const string ARGUMENT_NAME_AVATARTYPE = "AvatarType";

	public int AnimationClipID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AnimationType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AvatarType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override long CheckValidateKeyFrame()
	{
		return 0L;
	}

	public new long _003C_003EiFixBaseProxy_CheckValidateKeyFrame()
	{
		return 0L;
	}
}

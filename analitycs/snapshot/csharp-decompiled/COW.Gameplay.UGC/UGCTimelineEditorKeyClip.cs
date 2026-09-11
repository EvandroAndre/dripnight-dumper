using message;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorKeyClip : UGCTimelineEditorKeyBase
{
	public const string ARGUMENT_NAME_CLIPNAME = "ClipName";

	public const string ARGUMENT_NAME_CLIPMINDURATION = "ClipMinDuration";

	public const string ARGUMENT_NAME_CLIPLOOPTYPE = "ClipLoopType";

	public const string ARGUMENT_ORIGINAL_DURATION = "OriginalDuration";

	public IJHPDKODECM MapValue => null;

	public virtual string ClipName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float OriginalDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public virtual float ClipMinDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public UGCTimelineEditorDefine.ClipLoopType ClipLoopType => UGCTimelineEditorDefine.ClipLoopType.None;

	public bool CheckOverlap()
	{
		return false;
	}

	public override long CheckValidateKeyFrame()
	{
		return 0L;
	}

	public long _003C_003EiFixBaseProxy_CheckValidateKeyFrame()
	{
		return 0L;
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class PreviewVideoParams
{
	public ResourceID VideoRes;

	public Vector2 VideoSize;

	public bool IsLoop;

	public bool IsShowIcon;

	public bool IsAutoClose;

	public bool IsShowClickSkip;

	public bool UseUnityVideoPlayer;

	public PreviewVideoParams()
	{
	}

	public PreviewVideoParams(ResourceID res, Vector2 size, bool loop, bool isShowIcon, bool isAutoClose, bool isShowClickSkip, bool useUnityVideoPlayer)
	{
	}
}

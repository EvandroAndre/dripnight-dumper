using GCommon;

namespace COW;

public class GEventShowAvatarTransform : GEvent
{
	public ulong AccountID;

	public uint TransformID;

	public uint TransformLevel;

	public uint TransformState;

	public uint TransformExtraInfo;
}

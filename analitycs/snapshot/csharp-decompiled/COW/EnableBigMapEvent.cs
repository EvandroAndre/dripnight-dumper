using GCommon;

namespace COW;

public class EnableBigMapEvent : GEvent
{
	public EBigMapType BigMapType;

	public EBigMapInteractionMode InteractionMode;

	public uint LastTime;
}

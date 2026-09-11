using System;
using GCommon;

namespace COW;

public class GEventLocalAvatarTransformer : GEvent
{
	public ulong AccountID;

	public TransformData TransformData;

	public int TransformerLevel;

	public Action SuccessAction;
}

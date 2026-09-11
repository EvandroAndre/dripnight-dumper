using System;
using message;

namespace COW;

[Serializable]
public class ReplayEvent
{
	public NBAOHLPEKCG Event;

	public uint PlayerID;

	public float Time;

	public float FParam;

	public string SParam;
}

using System;

namespace COW;

[Serializable]
public class MemberEvent
{
	public string channelId;

	public VodkaMemberInfo member;

	public MemberEventType eventType;
}

using ProtoBuf;

namespace proto;

public class AntiAddictionAgeAuthInfo : IMessage
{
	public ulong account_id;

	public EAntiAddiction.AuthState auth_state;

	public string age_type;

	public long sync_time;

	public long last_refresh_time;

	public long re_auth_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}

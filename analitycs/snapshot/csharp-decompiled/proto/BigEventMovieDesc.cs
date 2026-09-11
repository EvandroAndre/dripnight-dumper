using ProtoBuf;

namespace proto;

public class BigEventMovieDesc : IMessage
{
	public uint id;

	public ELimitedEvent.EventID event_id;

	public string movie_url;

	public string frame_image_cdn;

	public void ParseFrom(ProtoReader reader)
	{
	}
}

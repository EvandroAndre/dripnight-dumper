using ProtoBuf;

namespace proto;

public class GroupPhotoModelSettingDesc : IMessage
{
	public uint id;

	public uint pose_place;

	public string resource_name;

	public string position1;

	public string rotation1;

	public string position2;

	public string rotation2;

	public void ParseFrom(ProtoReader reader)
	{
	}
}

using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetAndroidApplicationToDetectRes : IMessage
{
	public List<AndroidApplicationToDetectDesc> android_apps_to_detect_res;

	public void ParseFrom(ProtoReader reader)
	{
	}
}

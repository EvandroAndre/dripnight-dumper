using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditCustomEventKeyFrame : UGCTimelineEditorKeyFrame
{
	public const string CUSTOMEVENT_MAP_KEY = "CustomEventMapKey";

	public const string ARGUMENT_NAME_EVENTSOURCE = "EventSource";

	public const string ARGUMENT_NAME_EVENTGUID = "EventGUID";

	public const string ARGUMENT_NAME_EVENTNAME = "EventName";

	public const string ARGUMENT_NAME_EVENTTYPE = "EventType";

	public const string ARGUMENT_NAME_RECEIVER = "Receiver";

	public const string ARGUMENT_NAME_TARGETSIDE = "TargetSide";

	public const string ARGUMENT_NAME_PARAMS = "Params";

	private CustomEventReader eventReader;

	private List<UGCVarValueDataV2> m_ListValue;

	public List<UGCVarValueDataV2> Events => null;

	public override void Create(float time)
	{
	}

	public override void Serialized()
	{
	}

	private CCHOFCIGDHH CreateEditorKeyFrameData()
	{
		return null;
	}

	public void CreateCustomEvent(string eventName, string eventGUID, int eventType, string receiver, int targetSide, List<UGCVarValueDataV2> list = null)
	{
	}

	public override long CheckValidateKeyFrame()
	{
		return 0L;
	}

	public void _003C_003EiFixBaseProxy_Create(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Serialized()
	{
	}

	public long _003C_003EiFixBaseProxy_CheckValidateKeyFrame()
	{
		return 0L;
	}
}

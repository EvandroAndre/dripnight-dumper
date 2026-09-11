using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using message;

namespace COW;

public class DispatchUserCustomEventRefValue
{
	public List<ValueData> Args;

	public BlockEditContext Context;

	public EUGCUserCustomEventSource EventSource;

	private string m_EventUid;

	public string EventUid => null;

	public NEIFIIBPMOM UserCustomEventItem => null;

	public DispatchUserCustomEventRefValue(BlockEditContext context)
	{
	}

	public DispatchUserCustomEventRefValue(BlockEditContext context, string eventUid, EUGCUserCustomEventSource eventSource)
	{
	}

	public void RegenerateArgs(bool isConstructingData)
	{
	}

	private void RemoveArgs(int startIndex, int endIndex)
	{
	}

	public string GetEventName()
	{
		return null;
	}

	public string GetParamName(int index)
	{
		return null;
	}

	public string GetParamType(int index)
	{
		return null;
	}

	public bool CheckLegality()
	{
		return false;
	}

	public DispatchUserCustomEventRefValue Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, BlockData owner) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}
}

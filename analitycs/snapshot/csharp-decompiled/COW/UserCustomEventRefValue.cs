using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using message;

namespace COW;

public class UserCustomEventRefValue
{
	private BlockEditContext m_Context;

	private GraphData m_Graph;

	public List<LocalVarDefineData> ParamDefines;

	public EUGCUserCustomEventSource EventSource;

	private string m_TypeName;

	private string m_EventUid;

	private BlockData m_BlockData;

	public BlockData BlockData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string EventUid => null;

	public NEIFIIBPMOM UserCustomEventItem => null;

	public UserCustomEventRefValue(BlockEditContext context)
	{
	}

	public UserCustomEventRefValue(BlockEditContext context, BlockData blockData, string eventUid, GraphData graph, EUGCUserCustomEventSource eventSource)
	{
	}

	public void RegenerateParamDefine(bool isConstructingData)
	{
	}

	private void RemoveParamDefines(int startIndex, int endIndex)
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

	public UserCustomEventRefValue Clone(BlockData owner, GraphData graphData)
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

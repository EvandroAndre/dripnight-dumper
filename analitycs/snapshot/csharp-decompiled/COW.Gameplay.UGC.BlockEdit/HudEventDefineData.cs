namespace COW.Gameplay.UGC.BlockEdit;

public class HudEventDefineData
{
	public BlockEditContext Context;

	protected BlockData m_BlockData;

	protected int m_WidgetId;

	protected string m_TypeName;

	protected string m_WidgetName;

	protected int m_LogicEntityType;

	public string graphId;

	public GraphData Graph => null;

	public string WidgetName => null;

	public int WidgetId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LogicEntityType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string EntityID => null;

	public BlockData EventData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string TypeName => null;

	public HudEventDefineData(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, BlockData owner) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public HudEventDefineData Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	public int GetHudEventType()
	{
		return 0;
	}

	private bool _003Cget_WidgetName_003Eb__10_0(UGCHudEventBlockInfo x)
	{
		return false;
	}
}

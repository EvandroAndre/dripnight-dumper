using GCommon;

namespace COW;

public class PetData : CSVBaseData
{
	public string DefaultName;

	public string IdleAction;

	public string FeedAction;

	public string LobbyAction;

	public string HDLobbyWalkAction;

	public int ID;

	public int Tag;

	public int OrderSource;

	public int RareType;

	public float NameHeight;

	public uint MaxLevel;

	public float WanderAnimBaseSpeed;

	public float WalkAnimBaseSpeed;

	public float RunAnimBaseSpeed;

	public float LobbyScale;

	public float IngameHeightMode;

	public float IngameScaleMode;

	public ResourceID IngameModel;

	public ResourceID IngameModel3P;

	public ResourceID IngameSkinPrefabMode;

	public ResourceID IngameSkinPrefab3PMode;

	public ResourceID PreviewModel;

	public ResourceID FeedSfx;

	public ResourceID LobbySfx;

	public ResourceID LobbyVfx;

	public ResourceID MultiFeedVFX;

	public ResourceID FeedVFX;

	public ResourceID InGameBasicActionRes;

	public ResourceID LobbyBasicActionRes;

	public ResourceID ExtraActionRes;

	public ResourceID WalkSfx;

	public float WalkSpeed;

	public ResourceID IdleVoice;

	public ResourceID CheerVoice;

	public ResourceID ShowVoice;

	public bool MirrorIcon;

	public float GameAssistantLobbyEntranceOffsetY;

	public float GameAssistantBubbleOffsetY;

	public float LobbyHeightMode;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}

using GCommon;

namespace COW;

public class ChatStickerData : CSVBaseData
{
	public uint ItemID;

	public uint StickerID;

	public ResourceID ResourceName;

	public float RoomChatStickerPosY;

	public uint EmojiID;

	public static uint TrainingStickerItemId;

	public static uint BattleStickerItemId;

	public static uint CabinWaitingStickerItemId;

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

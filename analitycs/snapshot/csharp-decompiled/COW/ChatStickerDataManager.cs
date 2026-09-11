using System.Collections.Generic;
using GCommon;

namespace COW;

public class ChatStickerDataManager : SingletonModule<ChatStickerDataManager>
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public uint id;

		internal bool _003CGetChatStickerPrice_003Eb__0(ChatStickerPrice x)
		{
			return false;
		}
	}

	private Dictionary<uint, List<ChatStickerData>> m_StickerDic;

	private List<ChatStickerPrice> m_StickerPriceList;

	private Dictionary<uint, ChatStickerData> m_EmojiDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public List<ChatStickerPrice> GetChatStickerPrices()
	{
		return null;
	}

	public ChatStickerPrice GetChatStickerPrice(uint id)
	{
		return null;
	}

	public ChatStickerData GetStickerDataByEmojiId(uint emojiID)
	{
		return null;
	}

	public string GetStickerMessageString(ChatStickerData stickerData)
	{
		return null;
	}

	public string GetStickerMessageString(uint itemID, uint stickerID)
	{
		return null;
	}

	public ChatStickerData IsThisASticker(string strMsg, out bool isSticker, out uint itemId)
	{
		isSticker = default(bool);
		itemId = default(uint);
		return null;
	}

	public List<ChatStickerData> GetChatStickerDatas(uint itemID)
	{
		return null;
	}
}

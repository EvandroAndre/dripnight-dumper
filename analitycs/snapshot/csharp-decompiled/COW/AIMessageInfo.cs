using System.Collections.Generic;
using proto;

namespace COW;

public class AIMessageInfo
{
	public string Content;

	public string MessageId;

	public int MessageIndex;

	public bool IsSelf;

	public bool IsLike;

	public bool IsDislike;

	public bool IsLoading;

	public bool isFullText;

	public bool IsToptip;

	public bool IsFastChat;

	public List<AIAssistantSuggestedQuestionsTableDesc> FastChatData;

	public List<UGCSetParamData> UGCSetParams;

	public List<string> InvalidUGCSetParams;

	public bool PramasModifyExcuted;
}

using System.Collections.Generic;

namespace proto;

public class CSAIBotAgentDescRes
{
	public List<BotAgentPromptDesc> prompt_list;

	public List<BotAgentECADesc> eca_list;

	public List<CSBotAgentPromptDesc> cs_prompt_list;

	public List<CSBotAgentECADesc> cs_eca_list;
}

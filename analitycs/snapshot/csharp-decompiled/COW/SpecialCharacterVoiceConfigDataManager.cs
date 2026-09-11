using System.Collections.Generic;
using GCommon;

namespace COW;

internal class SpecialCharacterVoiceConfigDataManager : SingletonModule<SpecialCharacterVoiceConfigDataManager>
{
	private Dictionary<uint, List<SpecialCharacterVoiceConfigData>> m_Dict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<SpecialCharacterVoiceConfigData> GetConfigDataListByCharacterID(uint characterID)
	{
		return null;
	}
}

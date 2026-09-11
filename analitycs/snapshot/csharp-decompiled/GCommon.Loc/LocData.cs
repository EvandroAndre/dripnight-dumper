using System.Collections.Generic;

namespace GCommon.Loc;

public class LocData
{
	private const uint LocTextIdxMask = 16777215u;

	private const uint LocTextFlagCleared = 2147483648u;

	private const int LocTextFlagsShift = 24;

	private Dictionary<string, uint> m_LocTextName;

	private Dictionary<int, uint> m_LocTextHash;

	private List<string> m_LocTextTranslations;

	public bool HasLobbyOnlyStrings;

	private int m_NextId;

	public LocData(Dictionary<string, uint> names, Dictionary<int, uint> hash, List<string> trans)
	{
	}

	internal int BeforeAddIds()
	{
		return 0;
	}

	internal int AfterAddIds()
	{
		return 0;
	}

	internal void AddTranslation(int hashKey, LocManager.LocUseCase useCase)
	{
	}

	internal void AddTranslation(string id, LocManager.LocUseCase useCase, bool needOverWrite)
	{
	}
}

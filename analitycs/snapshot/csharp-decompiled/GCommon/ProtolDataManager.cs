using System.Collections.Generic;
using System.IO;
using TsiU;

namespace GCommon;

public class ProtolDataManager : TSingleton<ProtolDataManager>
{
	public enum EProtolType : byte
	{
		None,
		StoreRes,
		ActivityInfoRes,
		Max
	}

	private Dictionary<int, MemoryStream> m_SavedProtolData;

	public T GetProtolData<T>(EProtolType protolType)
	{
		return default(T);
	}

	public bool SaveProtolData(EProtolType protolType, object protol)
	{
		return false;
	}
}

using System.Collections.Generic;
using GCommon;

namespace COW;

internal class AvatarInvisbleDataManager : SingletonModule<AvatarInvisbleDataManager>
{
	private Dictionary<uint, AvatarInvisbleData> m_Data;

	private Dictionary<uint, AvatarInvisbleData> m_OriginalIPAvatarKeyMap;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public AvatarInvisbleData GetAvatarInvisbleData(uint id)
	{
		return null;
	}

	public List<AvatarInvisbleData> GetAllData()
	{
		return null;
	}

	public uint? GetMappedAvatar(uint avatarId)
	{
		return null;
	}

	public uint GetAvatarChipIDByAvatarId(uint avatarId)
	{
		return 0u;
	}
}

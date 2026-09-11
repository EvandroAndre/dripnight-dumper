using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class GroupPhotoAvatar
{
	public ulong account_id;

	public string nick_name;

	public UIMaleAvatar avatar;

	public uint avatar_id;

	public uint[] cloths;

	public string alias;

	public List<AccountCollectionCustomItemInfo> customData;

	public List<ResourceID> GetNeedDownLoadList()
	{
		return null;
	}
}

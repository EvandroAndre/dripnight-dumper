using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class ReplayAvatarData
{
	public uint avatarID;

	public List<uint> cloth;

	public List<ReplayCustomData> customData;

	public string sharerNickname;
}

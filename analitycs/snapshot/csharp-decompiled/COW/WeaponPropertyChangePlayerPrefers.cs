using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class WeaponPropertyChangePlayerPrefers
{
	public List<uint> PlayerClickedChangedWeaponID;

	public uint MajorVersion;
}

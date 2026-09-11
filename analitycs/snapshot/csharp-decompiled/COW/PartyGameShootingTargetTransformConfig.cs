using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

[Serializable]
public class PartyGameShootingTargetTransformConfig : ScriptableObject
{
	public List<PartyGameShootingTargetItem> PartyGameShootingList;
}

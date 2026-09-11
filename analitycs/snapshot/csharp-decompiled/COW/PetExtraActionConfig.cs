using System;
using UnityEngine;

namespace COW;

[Serializable]
public class PetExtraActionConfig : ScriptableObject
{
	public PetAnimClipConfig[] ExtraAnims;
}

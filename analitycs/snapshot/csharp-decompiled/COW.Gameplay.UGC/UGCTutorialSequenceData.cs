using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialSequenceData
{
	public string sequenceId;

	public string templateMapId;

	public List<UGCTutorialLevelData> levels;
}

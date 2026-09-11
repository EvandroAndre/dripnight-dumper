using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay;

[Serializable]
public class ClipEvents
{
	public AnimationClip m_Clip;

	public List<ClipEvent> m_Events;
}

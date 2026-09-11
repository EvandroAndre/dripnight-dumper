using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayableSnapLayer
{
	public UGCAnimPlayable_IClipPlayer m_player;

	public int m_index;

	public float m_weight;

	public List<UGCAnimPlayableSnapClip> m_playingClips;
}

using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayableDebugger : MonoBehaviour
{
	public UGCAnimPlayable_Simple m_simpleAnim;

	public List<AnimationClip> m_clipList;

	public bool m_isDebug;

	public List<AvatarMask> m_avatarMaskList;

	public List<Transform> m_avatarMaskTransforms;
}

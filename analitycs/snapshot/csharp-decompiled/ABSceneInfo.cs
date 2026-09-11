using System.Collections.Generic;
using UnityEngine;

public class ABSceneInfo
{
	public bool m_hasLMOrCollider;

	public List<ABSceneGOInfo> m_sceneGOInfoList;

	public List<int> m_sharedSceneGOInfoList;

	public GameObject m_rootGO;
}

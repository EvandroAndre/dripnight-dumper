using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCPlayableController : MonoBehaviour
{
	private GameObject m_Target;

	private string m_UGCEntityID;

	private UGCResPlayableController m_ResData;

	private string m_ResID;

	private UGCLogicEntity m_Entity;

	private List<string> m_Playables;

	private Dictionary<string, List<string>> m_PendingPaths;

	public static UGCPlayableController Create(GameObject go, string entityID)
	{
		return null;
	}

	private void Init()
	{
	}

	public void LoadResource(string resUUID)
	{
	}

	private void RefreshPlayableController()
	{
	}

	private void ClearPlayables()
	{
	}

	public void Dispose()
	{
	}

	private void OnPathEntityCreataed(GameObject obj)
	{
	}

	private void _003CLoadResource_003Eb__9_0(bool succ, UGCResPlayableController resObj)
	{
	}
}

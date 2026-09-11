using COW.GamePlay;
using UnityEngine;

namespace GCommon;

public class AIWarningRegion<T> : MonoBehaviour, IAIWarningRegion
{
	protected T MyParam;

	private Player m_InPlayer;

	Transform IAIWarningRegion.transform => null;

	public void InitParam(T initParam)
	{
	}

	public virtual void OnInit()
	{
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public void OnTriggerEnter(Collider other)
	{
	}

	public void OnTriggerExit(Collider other)
	{
	}

	public void OnRecycle()
	{
	}
}

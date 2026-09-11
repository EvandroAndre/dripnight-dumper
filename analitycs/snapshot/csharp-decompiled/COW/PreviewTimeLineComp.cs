using UnityEngine;
using UnityEngine.Playables;

namespace COW;

public class PreviewTimeLineComp : MonoBehaviour
{
	public PlayableDirector PreviewDirector;

	public float SkipToTarTime;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayTimeLine(bool isfirst = true)
	{
	}

	public void PlayByTime(float time)
	{
	}

	private void OnTimeLineSkipped(object[] data)
	{
	}
}

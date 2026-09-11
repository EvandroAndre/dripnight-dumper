using UnityEngine;

namespace COW;

public class AudioCGPlusEvt : MonoBehaviour
{
	public string voice_resourceid;

	public string voice_resourceid_last;

	private GameObject m_curAudioGo;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ProcessCGEvt(object[] data)
	{
	}

	private void OnEnable()
	{
	}

	private void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}
}

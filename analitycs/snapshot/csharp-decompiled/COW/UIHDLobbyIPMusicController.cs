using UnityEngine;

namespace COW;

public class UIHDLobbyIPMusicController : MonoBehaviour
{
	public GameObject m_Root;

	public Transform MusicDiscTrans;

	public GameObject PlayIconObj;

	public GameObject StopIconObj;

	private bool m_IsInTeam;

	private bool m_IsMusicActive;

	public bool IsMusicActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnIPMusicDiscRotateActivated(object[] data)
	{
	}

	private void UpdateLobbyMusic()
	{
	}

	private void OnIPMusicContainerClick(object[] data)
	{
	}

	private void ShowIPMusicContainer(object[] data)
	{
	}

	private void OnLobbyControllerVisibleChanged(object[] data)
	{
	}

	private void OnLobbyGroupEnter(object[] data)
	{
	}

	private void OnGroupQuit()
	{
	}
}

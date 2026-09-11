using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDIceWallModuleRewardItem : MonoBehaviour
{
	public GameObject Root;

	public UISprite Icon;

	public TweenPosition TweenPos;

	public TweenAlpha TweenA;

	public Transform VFXRoot;

	public float[] PopDuraing;

	public float[] PopDelay;

	private bool m_playing;

	private float m_StartTime;

	private float m_EndTime;

	private ResourceID m_VfxResID;

	private GameObject m_Instance;

	private uint m_AsyncLoadTicket;

	public void Play(uint ItemID, int i, int count, ResourceID effectRes)
	{
	}

	private void Update()
	{
	}

	private void ShowHide(bool value)
	{
	}

	private void OnDestroy()
	{
	}

	public void Stop()
	{
	}

	private void OnVfxPoolInstantiated(uint ticket, bool success, Object instance)
	{
	}

	private void RecyleVFX()
	{
	}
}

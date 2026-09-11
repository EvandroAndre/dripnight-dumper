using COW.GamePlay;
using UnityEngine;

namespace COW;

public class MapUIDeadBox : MonoBehaviour
{
	private static readonly Color NormalLocalColor;

	private static readonly Color NormalRemoteColor;

	private UISprite m_icon;

	private float m_HideTime;

	private bool m_IsLocal;

	private bool m_IsHiddenByReviveBoxMapIcon;

	private VFXCreateHelper m_ReviveBoxUIFX;

	public void OnDead(bool isLocal, BHGGAEEHJCO playerID, Vector3 pos, float elapsedTime = 0f)
	{
	}

	private void ApplyIconColor()
	{
	}

	public void SetHiddenByReviveBoxMapIcon(bool hidden)
	{
	}

	private void RefreshIconVisible()
	{
	}

	private void SetReviveBoxUIFXActive(bool show)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}

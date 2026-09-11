using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIHudKassiePerkEDCrosshairs : MonoBehaviour
{
	public GameObject GameObjectRoot;

	private bool m_Visible;

	private bool m_Registered;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void UnregisterEvents()
	{
	}

	private void OnVisibilityStateChanged(object[] data)
	{
	}

	private void RefreshVisibility()
	{
	}

	private bool ShouldHide()
	{
		return false;
	}

	private bool ShouldShowWithWeapon(Player player)
	{
		return false;
	}

	private void SetVisible(bool visible)
	{
	}
}

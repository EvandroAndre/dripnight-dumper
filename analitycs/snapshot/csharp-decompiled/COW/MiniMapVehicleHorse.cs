using COW.GamePlay;
using UnityEngine;

namespace COW;

public class MiniMapVehicleHorse : MonoBehaviour
{
	public UISprite vehicleIcon;

	private DDOADCIBEGG m_subType;

	public bool NeedRotationWithPlayer()
	{
		return false;
	}

	private bool IsMountableAni()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	public void SetActive(bool active)
	{
	}

	public void SetMapTransform(Vector3 localPosition, Quaternion localRotation, Vector3 localScale, Quaternion mapIconRotation)
	{
	}

	public void SetMapScale(Vector3 localScale)
	{
	}

	public void SetMapRotation(Quaternion localRotation)
	{
	}

	public void SetMapIconRotation(Quaternion mapIconRotation)
	{
	}

	public Transform GetSpawnParent()
	{
		return null;
	}

	public void SetIconColor(Color color, bool isTeamMate = false)
	{
	}

	public void SetIconSpriteNameTeammate(string spriteName, uint subType)
	{
	}

	private void SetIconSpriteName(string spriteName)
	{
	}

	public void DestroySelf()
	{
	}

	public void SetNearestVehicleIcon(string mapIcon, uint subType)
	{
	}

	public void SetLastVehicleIcon(GKEDHMFHDFM vehicledata, string mapIcon, Color flyVehicleColor)
	{
	}

	public void SetVehicleIcon(uint subType)
	{
	}
}

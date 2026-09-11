using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudSpeedRoyaleTeammateGroup : MonoBehaviour
{
	public UIGrid Grid;

	public UISprite VehicleHpSprite;

	public Dictionary<BHGGAEEHJCO, UIHudSpeedRoyaleTeammateItem> TeammateItems;

	public void InitInfo(Vehicle v)
	{
	}

	public void OnVehicleHPChanged(Vehicle v)
	{
	}
}

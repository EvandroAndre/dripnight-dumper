using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class SearchMapObject
{
	public delegate bool IsPositionValid(Vector3 pos, bool delete);

	private Player m_LocalPlayer;

	private uint m_SearchInterval;

	private uint m_MyLastVehicleID;

	private MiniMapVehicleHorse m_MyLastVehicle;

	private Dictionary<uint, MiniMapVehicleHorse> m_VehicleMap;

	private Queue<MiniMapVehicleHorse> m_VehiclePool;

	private MiniMapVehicleHorse m_VehicleClone;

	private Queue<UITeamGatherPointMapIconController> m_TeamGatherPointPool;

	private Dictionary<uint, UITeamGatherPointMapIconController> m_TeamGatherPointMap;

	private Transform m_TeamGatherPointSpawnPos;

	private Dictionary<uint, UISprite> m_LuckyDrawBoxMap;

	private Dictionary<uint, UIHudGeneralConstructionMapItemController> m_generalMapItemTrackMap;

	private Queue<UISprite> m_LuckyDrawBoxPool;

	private UISprite m_LuckyDrawBoxClone;

	private Vector3 m_IconScale;

	private Quaternion m_IconRotation;

	private Color m_LastVehicleColor;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private IsPositionValid m_IsPositionValidCheck;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx, IsPositionValid valid)
	{
	}

	private void OnShowLastVehicleByLocalPlayer(GEvent data)
	{
	}

	public void InitSearchObject(MiniMapVehicleHorse vehicle, UISprite luckyDrawBox, Transform teamGatherPoint)
	{
	}

	public void StartSearch()
	{
	}

	private void SeachAround()
	{
	}

	private void ClearExpiredVehicleSprite()
	{
	}

	private void RefreshMyLastVehicle()
	{
	}

	private void SearchNearestVehicle()
	{
	}

	private void RemoveVehicleFromMap(uint vehicleObjectID)
	{
	}

	private void OnVehicleExploded(object[] data)
	{
	}

	private void SearchTeamGatherPoint()
	{
	}

	private void OnTeamGatherPointStateChanged(object[] param)
	{
	}

	private void SearchLuckyBox()
	{
	}

	private void SearchPantherTruck()
	{
	}

	public void TrackOrDeleteElement(UIHudGeneralConstructionMapItemController ctrl, bool track)
	{
	}

	public void SetElementRotation(Quaternion rotation)
	{
	}

	public void SetElementScale(Vector3 iconScale)
	{
	}

	public void Destroy()
	{
	}
}

using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;
using message;

namespace COW;

public class IIVFloatingLand : MonoBehaviour
{
	public GameObject Model;

	public SceneGraphicsOverride Fog;

	public List<IIVFloatingLandEggCameraFilter> CameraFilters;

	public Vector3 MapCenterPos;

	private bool m_Notice;

	private NMPBHPDCEIH m_CurEggType;

	private Dictionary<uint, IIVFloatingLandEggCameraFilter> m_CameraFilterDict;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void SetCurCameraFilter()
	{
	}
}

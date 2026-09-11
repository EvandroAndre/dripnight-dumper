using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class SceneGraphicsExtData : MonoBehaviour
{
	public GameObject PreviewTerrainGO;

	public GameObject PreviewHouseGO;

	public GameObject TerrainGO;

	public GameObject FarSeaWaterGO;

	public GameObject NearSeaWaterGO;

	public List<GameObject> NearWaterGOList;

	public GameObject CloudPreviewGO;

	public SceneGraphicsParameters Parameters;

	public bool isBaseExtData;

	private bool hasUpdated;

	private void LateUpdate()
	{
	}
}

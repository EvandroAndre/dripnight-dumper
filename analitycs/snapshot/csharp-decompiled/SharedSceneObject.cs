using UnityEngine;

public class SharedSceneObject : MonoBehaviour
{
	public int key;

	public bool isMain;

	public GameObject sceneObject;

	public int[] lightmapIndexList;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}

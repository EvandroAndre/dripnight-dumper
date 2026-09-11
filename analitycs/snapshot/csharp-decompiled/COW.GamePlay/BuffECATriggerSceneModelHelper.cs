using UnityEngine;

namespace COW.GamePlay;

public class BuffECATriggerSceneModelHelper : MonoBehaviour
{
	public SceneBuffECATriggerObject OwnerTrigger;

	public GameObject TriggerModel;

	public uint TriggerObjectID;

	public bool IsOK;

	private void Awake()
	{
	}
}

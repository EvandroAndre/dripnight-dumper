using UnityEngine;

public class TriggerActionBase : MonoBehaviour
{
	public GlobalTriggerAction TriggerType;

	public TriggerActionTarget ActionTargetType;

	public float DelayTime;

	public bool StopWhenEnter;

	public bool DeactivateSelf;
}

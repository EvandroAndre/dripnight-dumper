using UnityEngine;

namespace COW;

public class TrainingShootGameRandomArea : MonoBehaviour
{
	public static TrainingShootGameRandomArea Instance;

	private Transform[] m_areas;

	public Transform[] areas => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}

using UnityEngine;

namespace COW.Graphics;

public class PrefabAttacher : MonoBehaviour
{
	public enum PrefabAttacherType
	{
		Type_Snow,
		Type_None
	}

	public PrefabAttacherType type;

	public string TargetResourceID;

	public bool HideInEvent;

	private GameObject m_Inst;

	private void Start()
	{
	}

	private void OnLoaded(uint tid, bool ret, Object res)
	{
	}
}

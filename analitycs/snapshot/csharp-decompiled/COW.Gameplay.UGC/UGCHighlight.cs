using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHighlight : MonoBehaviour
{
	private List<Renderer> m_MeshRenders;

	private Dictionary<Renderer, Material[]> m_OriginalMats;

	private Material m_ReplaceMat;

	private bool m_HasInited;

	private bool m_HasHighligted;

	private bool m_IsAlwaysHighlight;

	public void ResetHighlight()
	{
	}

	public void SetHighlight()
	{
	}

	public void SetIsAlwaysHighlight(bool isAlwaysHighlight)
	{
	}

	private void GetReplaceMat()
	{
	}

	private void InitMeshInfo()
	{
	}
}

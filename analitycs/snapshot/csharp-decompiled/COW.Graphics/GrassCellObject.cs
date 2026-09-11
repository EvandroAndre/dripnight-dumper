using System;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class GrassCellObject : ScriptableObject
{
	public GrassCell[] m_grassCell;

	public void Init(int cell_num_w, int cell_num_h)
	{
	}
}

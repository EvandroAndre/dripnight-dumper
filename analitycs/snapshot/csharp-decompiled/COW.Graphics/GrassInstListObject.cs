using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class GrassInstListObject : ScriptableObject
{
	public List<GrassInst> m_grassInstList;
}

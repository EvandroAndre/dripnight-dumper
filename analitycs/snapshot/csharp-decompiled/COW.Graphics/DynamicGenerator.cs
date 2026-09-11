using UnityEngine;

namespace COW.Graphics;

public class DynamicGenerator : MonoBehaviour
{
	public enum GeneratorType
	{
		Type_Generic,
		Type_Grass,
		Type_Tree,
		Type_Stone,
		Type_Billboard,
		Type_StaticEnv,
		Type_Pumpkin,
		Type_Total
	}

	public GeneratorType m_type;

	public bool m_streamCollider;

	public bool m_isExclude;
}

using UnityEngine;

namespace COW.Graphics;

public class VegetationGenerator : MonoBehaviour
{
	public enum GeneratorType
	{
		Type_Grass_Large,
		Type_Grass_Medium,
		Type_Grass_Small,
		Type_Grass_Wheat,
		Type_Tree_Pine,
		Type_Tree_Green,
		Type_Tree_Coco,
		Type_Tree_Tropical,
		Type_Total
	}

	public GeneratorType m_type;
}

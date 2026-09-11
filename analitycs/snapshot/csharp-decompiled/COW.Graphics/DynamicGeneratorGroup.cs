using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class DynamicGeneratorGroup : MonoBehaviour
{
	public List<DynamicGeneratorManager.DynamicPrefabInfo> m_dynamicPrefabList;

	public List<DynamicGeneratorManager.DynamicPrefabInfo> m_dynamicGroupPrefabList;

	public List<DynamicGeneratorManager.DistributionData> m_distributionList;
}

using System.Collections.Generic;
using UnityEngine;

public class LevelContainerLocationPreserver : MonoBehaviour
{
	private const string RelatedShaderName1 = "BRMobile/Special/PickupDiffuse";

	private const string RelatedShaderName2 = "BRMobile/Special/PickupCutOff";

	private const string PropertyName = "_OriginPosition";

	private List<Material> m_Materials;

	private int m_PropertyHashID;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Init()
	{
	}

	private void SetFixedWorldPosition()
	{
	}
}

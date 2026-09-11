using UnityEngine;

public class PlanarReflection : MonoBehaviour
{
	public enum SizeEnum
	{
		Sixteenth = 0x40,
		Eighth = 0x80,
		Quarter = 0x100,
		Half = 0x200,
		One = 0x400
	}

	public SizeEnum m_sizeType;

	public Camera m_mainCamera;

	public Camera m_reflectionCamera;

	private Material m_reflectionMaterial;

	private RenderTexture m_reflectionRT;

	private int m_reflectionRTsize;

	private int m_reflectionTexID;

	private Matrix4x4 m_reflectMatrix;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateRefCamera()
	{
	}

	private void OnDestroy()
	{
	}
}

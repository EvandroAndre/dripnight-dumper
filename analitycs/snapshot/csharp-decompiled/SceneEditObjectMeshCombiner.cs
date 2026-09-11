using System.Collections.Generic;
using UnityEngine;

public class SceneEditObjectMeshCombiner : MonoBehaviour
{
	private enum ShaderType
	{
		DiffuseColorTilling,
		UGCPainter
	}

	private class MeshesData
	{
		public List<MeshRenderer> renderers;

		public List<MeshFilter> meshFilters;

		public int vertexCount;
	}

	private struct CombineTextureKey
	{
		public int texture_index0;

		public int texture_index1;

		public int texture_index2;

		public int texture_index3;
	}

	private static readonly string[] ShadersName;

	private static readonly string[] CombinedShadersName;

	private Dictionary<int, MeshesData>[] m_rendererDicArray;

	private int _FrameTexID;

	private int _BrightnessID;

	private int _LightingOnLowID;

	private int _ColorID;

	private int _FrameColorID;

	private int _FrameWidthID;

	private GameObject m_combinedRoot;

	private static readonly int MaxMeshTriangleCount;

	private static readonly int MinMeshCombineCount;

	private static readonly int MaxMeshVertexCount;

	private bool haveCombinedMesh;

	private int FrameTexID => 0;

	private int BrightnessID => 0;

	private int LightingOnLowID => 0;

	private int ColorID => 0;

	private int FrameColorID => 0;

	private int FrameWidthID => 0;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ClassifyMeshRenderers()
	{
	}

	private void SplitMeshData()
	{
	}

	private void CombineMesh()
	{
	}

	private void BindPreZ(Renderer renderer)
	{
	}

	private int CheckShader(MeshRenderer renderer)
	{
		return 0;
	}

	private bool CheckMesh(Mesh mesh)
	{
		return false;
	}

	private bool CheckMeshesData(MeshesData data)
	{
		return false;
	}

	private bool CheckStatic(MeshRenderer renderer)
	{
		return false;
	}
}

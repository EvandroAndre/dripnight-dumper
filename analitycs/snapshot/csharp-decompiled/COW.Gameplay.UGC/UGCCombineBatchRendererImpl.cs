using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCCombineBatchRendererImpl
{
	public class ICombineShader
	{
		public Shader ShaderCombined;

		private bool _003CNeedNormal_003Ek__BackingField;

		private bool _003CNeedColor_003Ek__BackingField;

		private bool _003CNeedTangent_003Ek__BackingField;

		private bool _003CNeedTexCoord1_003Ek__BackingField;

		public bool DisableTexCoordAsTRS;

		public bool NeedNormal
		{
			get
			{
				return _003CNeedNormal_003Ek__BackingField;
			}
			protected set
			{
				_003CNeedNormal_003Ek__BackingField = value;
			}
		}

		public bool NeedColor
		{
			get
			{
				return _003CNeedColor_003Ek__BackingField;
			}
			protected set
			{
				_003CNeedColor_003Ek__BackingField = value;
			}
		}

		public bool NeedTangent
		{
			get
			{
				return _003CNeedTangent_003Ek__BackingField;
			}
			protected set
			{
				_003CNeedTangent_003Ek__BackingField = value;
			}
		}

		public bool NeedTexCoord1
		{
			get
			{
				return _003CNeedTexCoord1_003Ek__BackingField;
			}
			protected set
			{
				_003CNeedTexCoord1_003Ek__BackingField = value;
			}
		}

		public virtual void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		protected float GetFloat(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
		{
			return 0f;
		}

		protected int GetInt(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
		{
			return 0;
		}

		protected Vector4 GetVector(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
		{
			return default(Vector4);
		}

		protected Color GetColor(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
		{
			return default(Color);
		}

		public static void FillVertexAttrib<T>(BatchInst batchInst, List<T> dstArray, T value)
		{
		}
	}

	public class Shader_Origin : ICombineShader
	{
		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void RefreshVertexStreamByMaterial(Material mat)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_DiffuseColor : ICombineShader
	{
		private static readonly int k_BrightnessID;

		private static readonly int k_ColorID;

		private static readonly int k_LightingOnLowID;

		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_DiffuseColorUGC : ICombineShader
	{
		private static readonly int k_BrightnessID;

		private static readonly int k_ColorID;

		private static readonly int k_LightingOnLowID;

		private static readonly int k_MainTex_STID;

		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_BumpDiffuse : ICombineShader
	{
		private static readonly int k_MainTex_STID;

		private static readonly int k_BumpMap_STID;

		public Shader_BumpDiffuse()
		{
		}

		public Shader_BumpDiffuse(ResourceID combineShader)
		{
		}

		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_BumpSpecular : ICombineShader
	{
		private static readonly int k_DiffuseIntensityID;

		private static readonly int k_SpecularIntensityID;

		private static readonly int k_SpecularColorID;

		private static readonly int k_ShininessID;

		private static readonly int k_MainTex_STID;

		private static readonly int k_BumpMap_STID;

		public Shader_BumpSpecular()
		{
		}

		public Shader_BumpSpecular(ResourceID combineShader)
		{
		}

		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_DiffuseColorSphereTilling : ICombineShader
	{
		private static readonly int k_BrightnessID;

		private static readonly int k_LightingOnLowID;

		private static readonly int k_ColorID;

		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_DiffuseColorTilling : ICombineShader
	{
		private static readonly int k_BrightnessID;

		private static readonly int k_LightingOnLowID;

		private static readonly int k_ColorID;

		private static readonly int k_FrameColorID;

		private static readonly int k_FrameWidthID;

		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class Shader_ReflectionBlinnPhong_UGCPainter : ICombineShader
	{
		public override void FillMaterialProperty(Batch batch, BatchResult result, BatchInst batchInst)
		{
		}

		public void _003C_003EiFixBaseProxy_FillMaterialProperty(Batch P0, BatchResult P1, BatchInst P2)
		{
		}
	}

	public class BatchInst
	{
		public int meshIndex;

		public int subMeshIndex;

		public SourceMeshInst meshInst;

		public int[] originSubMeshTriangles;

		public MaterialPropertyBlock mpb;

		public Material instMaterial;
	}

	public class Batch
	{
		public Material sharedMaterial;

		public Material originMaterial;

		public string shaderName;

		public string textureKey;

		public List<BatchInst> combineInstances;

		public ICombineShader combineShader;

		public int[] resultSubMeshTriangles;

		public bool IsNeedNormal;

		public bool IsNeedColor;

		public bool IsNeedTangent;

		public bool IsNeedMaterialPropertyAsUV;

		public void CreateWithOriginMaterial(Material mat, Dictionary<string, Texture2D> textures, UGCCombineBatchRendererImpl impl)
		{
		}

		public void AddBatchInst(int meshIndex, int subMeshIndex, SourceMeshInst meshInst, MaterialPropertyBlock mpb, Material instMaterial)
		{
		}

		public void BuildResultTriangles(BatchResult result)
		{
		}

		public void FillAllNeedVertex(BatchResult result, SourceMeshInst meshInst, BatchInst batchInst)
		{
		}

		public void ClearMemory()
		{
		}
	}

	public class SourceMeshInst
	{
		public Mesh mesh;

		public Matrix4x4 localToBatchMatrix;

		public Vector3 lossyScale;

		public int startVertexIndexInBatch;

		public void FillPosList(Vector3[] srcDataList, Vector3[] dstDataList)
		{
		}

		public void FillNormalList(Vector3[] srcDataList, Vector3[] dstDataList, int vertexCount)
		{
		}

		public void FillList<T>(T[] srcDataList, T[] dstDataList)
		{
		}
	}

	public class BatchResult
	{
		public Mesh batchMesh;

		public List<Batch> batches;

		public List<SourceMeshInst> meshInsts;

		public int vertexCount;

		private Vector3[] m_VertexPos;

		private Color32[] m_VertexColor;

		private Vector3[] m_VertexNormal;

		private Vector4[] m_VertexTangent;

		private Vector2[] m_VertexTexCoord0;

		private List<Vector4> m_VertexTexCoord1;

		private List<Vector4> m_VertexTexCoord2;

		private List<Vector4> m_VertexTexCoord3;

		private List<Vector4> m_VertexTexCoord4;

		private List<Vector4> m_VertexTexCoord5;

		private List<Vector4> m_VertexTexCoord6;

		private List<Vector4> m_VertexTexCoord7;

		public Vector3[] VertexPos => null;

		public Color32[] VertexColor => null;

		public Vector3[] VertexNormal => null;

		public Vector4[] VertexTangent => null;

		public Vector2[] VertexTexCoord0 => null;

		public List<Vector4> VertexTexCoord1 => null;

		public List<Vector4> VertexTexCoord2 => null;

		public List<Vector4> VertexTexCoord3 => null;

		public List<Vector4> VertexTexCoord4 => null;

		public List<Vector4> VertexTexCoord5 => null;

		public List<Vector4> VertexTexCoord6 => null;

		public List<Vector4> VertexTexCoord7 => null;

		public void BuildBatch()
		{
		}

		private void ClearMemory()
		{
		}

		public int AddMesh(Mesh mesh, Matrix4x4 localToBatchMatrix, Vector3 lossyScale, out SourceMeshInst meshInst)
		{
			meshInst = null;
			return 0;
		}

		public Batch GetBatch(Material originMaterial, bool useOriginMaterialAsKey, Dictionary<string, Texture2D> textures, UGCCombineBatchRendererImpl impl)
		{
			return null;
		}
	}

	private Dictionary<int, Texture> m_TempProperty2Texture;

	private BatchResult m_batchResult;

	private Dictionary<string, ICombineShader> m_Name2ShaderConverter;

	private Shader_Origin m_originShader;

	public BatchResult GenerateCombine(List<UGCResCombineMeshRenderer.RendererInfo> rendererInfoList)
	{
		return null;
	}

	private void LazyInitShader()
	{
	}

	public Shader_Origin GetShaderOrigin()
	{
		return null;
	}

	public ICombineShader GetCombineShader(Material mat)
	{
		return null;
	}
}

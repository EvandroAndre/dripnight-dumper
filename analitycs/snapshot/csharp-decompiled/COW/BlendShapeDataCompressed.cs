using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class BlendShapeDataCompressed : ScriptableObject
{
	[Serializable]
	public class BlendShapeChannel
	{
		public string ShapeName;

		public int BlendFrameCount;

		public List<BlendShapeFrameData> BlendShapeFrameDatas;

		public List<float> FrameWeights;
	}

	[Serializable]
	public class BlendShapeFrameData
	{
		public const ushort VERTEX_ZERO_FLAG = ushort.MaxValue;

		public const ushort NORMAL_ZERO_FLAG = 255;

		public const float VERTEX_MIN = -20f;

		public const float VERTEX_MAX = 20f;

		public const float NORMAL_MIN = -1f;

		public const float NORMAL_MAX = 1f;

		public const float TANGENT_MIN = -1f;

		public const float TANGENT_MAX = 1f;

		public ushort[] DeltaVerticeIndices;

		public ushort[] DeltaVertices;

		public byte[] DeltaNormals;

		public byte[] DeltaTangents;

		private List<Vector3> DeltaVerticeList;

		private List<Vector3> DeltaNormalsList;

		private List<Vector3> DeltaTangentsList;

		private List<ushort> VertexList;

		private List<byte> NormalList;

		private List<byte> TangentList;

		public void AddData(Vector3 pos, Vector3 normal, Vector3 tangent)
		{
		}

		public static bool IsVector3Equal(Vector3 lhs, Vector3 rhs)
		{
			return false;
		}

		public void Encode()
		{
		}

		private int AddVertexEncodeData(Vector3 pos)
		{
			return 0;
		}

		private void AddNormalEncodeData(Vector3 normal)
		{
		}

		private void AddTangentEncodeData(Vector3 tangent)
		{
		}

		public Vector3 GetVertex(int nIndex)
		{
			return default(Vector3);
		}
	}

	public string MeshName;

	public List<BlendShapeChannel> BlendShapes;

	public static byte FloatToByte(float value, float min = -1f, float max = 1f)
	{
		return 0;
	}

	public static ushort FloatToUInt16(float value, float min = -20f, float max = 20f)
	{
		return 0;
	}
}

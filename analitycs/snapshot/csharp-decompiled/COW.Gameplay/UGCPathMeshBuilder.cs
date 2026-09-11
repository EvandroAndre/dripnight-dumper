using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay;

public class UGCPathMeshBuilder
{
	public enum MeshType
	{
		Line,
		Track,
		Triangle
	}

	private float _003CPathWidth_003Ek__BackingField;

	private float _003CTrackWidthScale_003Ek__BackingField;

	private List<UGCPath> _003CPathList_003Ek__BackingField;

	private List<Mesh> meshList;

	private List<Vector3> vb;

	private List<int> ib;

	public float PathWidth
	{
		get
		{
			return _003CPathWidth_003Ek__BackingField;
		}
		set
		{
			_003CPathWidth_003Ek__BackingField = value;
		}
	}

	public float TrackWidthScale
	{
		get
		{
			return _003CTrackWidthScale_003Ek__BackingField;
		}
		set
		{
			_003CTrackWidthScale_003Ek__BackingField = value;
		}
	}

	public List<UGCPath> PathList
	{
		get
		{
			return _003CPathList_003Ek__BackingField;
		}
		set
		{
			_003CPathList_003Ek__BackingField = value;
		}
	}

	public void Dispose()
	{
	}

	public void SetPath(List<UGCPath> p)
	{
	}

	public void AddPath(UGCPath path)
	{
	}

	public void ClearAllPath()
	{
	}

	private int AppendPathIndexBufferCount(UGCPath path, MeshType meshType)
	{
		return 0;
	}

	public void AppendMeshBuffer(UGCPath path, List<Vector3> vb, List<int> ib, MeshType meshType)
	{
	}

	public void AppendLineMeshBuffer(UGCPath path, List<Vector3> vb, List<int> ib)
	{
	}

	public void AppendTrackMeshBuffer(UGCPath path, List<Vector3> vb, List<int> ib)
	{
	}

	public void AppendTriangleMeshBuffer(UGCPath path, List<Vector3> vb, List<int> ib)
	{
	}

	public void FillMesh(UGCPath path, ref Mesh mesh, MeshType meshType)
	{
	}

	public void FillLineMesh(UGCPath path, ref Mesh mesh)
	{
	}

	public void FillTrackMesh(UGCPath path, ref Mesh mesh, float pathWidth, float traskWidthScale = 1.2f)
	{
	}

	public void FillTriangleMesh(UGCPath path, ref Mesh mesh, float pathWidth)
	{
	}

	public List<Mesh> GenSeparateMeshList(MeshType meshType)
	{
		return null;
	}

	public List<Mesh> GenCombineMeshList(MeshType meshType, uint indexCountLimit = 65534u)
	{
		return null;
	}

	private void DeleteUnuseMesh(int start)
	{
	}

	private int AddMesh(uint vtxLimit, int curMesh, MeshType meshType)
	{
		return 0;
	}
}

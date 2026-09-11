using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace RuntimeGizmos;

public class TransformGizmo : MonoBehaviour
{
	public TransformSpace Space;

	public TransformType TransformType;

	public Color ColorX;

	public Color ColorY;

	public Color ColorZ;

	public Color ColorAll;

	public Color ColorSelected;

	public float HandleLength;

	public float HandleWidth;

	public float TriangleSize;

	public float BoxSize;

	public float AxisDelta;

	public int CircleDetail;

	public float MinSelectedDistanceCheck;

	public float MoveSpeedMultiplier;

	public float ScaleSpeedMultiplier;

	public float RotateSpeedMultiplier;

	public bool CircularRotationMethod;

	private Camera _003CMyCamera_003Ek__BackingField;

	public bool DisableAxisX;

	public bool DisableAxisY;

	public bool DisableAxisZ;

	private bool m_LockXY;

	private bool m_LockXZ;

	private bool m_LockYZ;

	public Vector3 AxisPosX;

	public Vector3 AxisPosY;

	public Vector3 AxisPosZ;

	private bool _003CIsTransforming_003Ek__BackingField;

	private Vector3 _003CPivot_003Ek__BackingField;

	public SceneEditObjectBase TargetObj;

	private AxisInfo m_AxisInfo;

	private Axis m_NearAxis;

	private AxisVectors m_HandleLines;

	private AxisVectors m_HandleTriangles;

	private AxisVectors m_HandleSquares;

	private AxisVectors m_CirclesLines;

	private LockVectors m_LockLines;

	private static Material m_LineMaterial;

	private Vector3 m_OriginalMousePosition;

	private Vector3 m_OriginalPivot;

	private Vector3 m_Axis;

	private Vector3 m_ProjectedAxis;

	private Vector3 m_PlaneNormal;

	private float m_TotalAngle;

	private Vector3 m_LastDirection;

	private Axis? m_RotatingAxis;

	public Color ClickColorX;

	public Color ClickColorY;

	public Color ClickColorZ;

	public Color SegmentColorX;

	public Color SegmentColorY;

	public Color SegmentColorZ;

	public int RotateStep;

	private List<Vector3> m_AllRotationPoints;

	public int m_StartRotationIndex;

	public Camera MyCamera
	{
		get
		{
			return _003CMyCamera_003Ek__BackingField;
		}
		private set
		{
			_003CMyCamera_003Ek__BackingField = value;
		}
	}

	public bool IsTransforming
	{
		get
		{
			return _003CIsTransforming_003Ek__BackingField;
		}
		private set
		{
			_003CIsTransforming_003Ek__BackingField = value;
		}
	}

	public Vector3 Pivot
	{
		get
		{
			return _003CPivot_003Ek__BackingField;
		}
		private set
		{
			_003CPivot_003Ek__BackingField = value;
		}
	}

	public Axis NearAxis => Axis.None;

	public void Awake()
	{
	}

	public void LateUpdate()
	{
	}

	public void OnPostRender()
	{
	}

	private void DrawLockLines()
	{
	}

	public TransformSpace GetProperTransformSpace()
	{
		return TransformSpace.Global;
	}

	public float GetDeltaMove()
	{
		return 0f;
	}

	public float GetDeltaScale()
	{
		return 0f;
	}

	public float GetDeltaRotate()
	{
		return 0f;
	}

	public float GetDeltaTangent()
	{
		return 0f;
	}

	public void EndAxisTransform()
	{
	}

	public void StartAxisTransform()
	{
	}

	public Vector3 GetNearAxisDirection(out Vector3 otherAxis1, out Vector3 otherAxis2)
	{
		otherAxis1 = default(Vector3);
		otherAxis2 = default(Vector3);
		return default(Vector3);
	}

	public void InitScaleLock(SceneEditObjectBase.LMOFHMAFDPP type)
	{
	}

	public void SetTarget(SceneEditObjectBase editObj)
	{
	}

	public void SetTransformType(TransformType type)
	{
	}

	public void ClearTarget()
	{
	}

	private void UpdateGizmo()
	{
	}

	public AxisInfo GetAxisInfo()
	{
		return default(AxisInfo);
	}

	public void SetNearAxis()
	{
	}

	public void HandleNearestLines(TransformType type, AxisVectors axisVectors, float minSelectedDistanceCheck)
	{
	}

	public void HandleNearestPlanes(TransformType type, AxisVectors axisVectors, float minSelectedDistanceCheck)
	{
	}

	public void HandleNearest(TransformType type, float xClosestDistance, float yClosestDistance, float zClosestDistance, float minSelectedDistanceCheck)
	{
	}

	private float ClosestDistanceFromMouseToLines(List<Vector3> lines)
	{
		return 0f;
	}

	private float ClosestDistanceFromMouseToPlanes(List<Vector3> planePoints)
	{
		return 0f;
	}

	public void SetAxisInfo()
	{
	}

	public float GetDistanceMultiplier()
	{
		return 0f;
	}

	public void SetLines()
	{
	}

	public void SetHandleLines()
	{
	}

	public void SetLockLines()
	{
	}

	public void AddLockQuads(Vector3 startPoint, Vector3 endPoint, Vector3 startDirection, Vector3 endDirection, Vector3 otherDirection, float width, List<Vector3> startBuffer, List<Vector3> endBuffer)
	{
	}

	public void SetHandleTriangles()
	{
	}

	public void AddTriangles(Vector3 axisEnd, Vector3 direction, Vector3 otherDirection1, Vector3 otherDirection2, float size, List<Vector3> resultsBuffer)
	{
	}

	public void AddSquares(Vector3 axisStart, Vector3 axisDirection, Vector3 axisOtherDirection1, Vector3 axisOtherDirection2, float size, List<Vector3> resultsBuffer)
	{
	}

	public void AddQuads(Vector3 axisStart, Vector3 axisDirection, Vector3 otherDirection1, Vector3 otherDirection2, float length, float width, List<Vector3> resultsBuffer)
	{
	}

	public void AddQuads(Vector3 axisStart, Vector3 axisEnd, Vector3 otherDirection1, Vector3 otherDirection2, float width, List<Vector3> resultsBuffer)
	{
	}

	public void AddQuads(Square square1, Square square2, List<Vector3> resultsBuffer)
	{
	}

	private Square GetBaseSquare(Vector3 point, Vector3 direction1, Vector3 direction2, float distance)
	{
		return default(Square);
	}

	public void DrawTriangles(List<Vector3> lines, Color color)
	{
	}

	public void DrawQuads(List<Vector3> lines, Color color)
	{
	}

	private void SetHandleSquares()
	{
	}

	public void SetMaterial()
	{
	}

	private void SetCircles(AxisInfo axisInfo, AxisVectors axisVectors)
	{
	}

	private void AddCircle(Vector3 origin, Vector3 axisDirection, float size, List<Vector3> resultsBuffer, bool depthTest = true, bool segRocord = false)
	{
	}

	private void DrawRotationGizmo()
	{
	}

	public void DrawRotationSegments()
	{
	}

	private void ProcessRotationClicked()
	{
	}

	private int ClosestPointFromMouseToLines(List<Vector3> lines)
	{
		return 0;
	}
}

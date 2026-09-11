using System.Collections.Generic;
using UnityEngine;

public class PaintMeshes : MonoBehaviour
{
	public float radius;

	public float offset;

	public float density;

	public float slopeInfluence;

	public float randomRotation;

	public bool slopeCorrection;

	public Vector2 randomScaleRange;

	private float nextFeasibleStrokeTime;

	public List<GameObject> meshes;

	protected List<Transform> paintedMeshes;

	protected List<Transform> paintedMeshesInsideBrushArea;

	public int meshCount => 0;

	public virtual bool HasMesh => false;
}

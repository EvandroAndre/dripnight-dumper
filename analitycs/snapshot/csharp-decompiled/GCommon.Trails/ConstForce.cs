using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Trails;

public class ConstForce : MonoBehaviour
{
	public enum AxisType
	{
		X,
		Y,
		Z
	}

	public List<SmokePlume> trails;

	public AxisType axis;

	public float speed;

	private void Start()
	{
	}

	private void Update()
	{
	}
}

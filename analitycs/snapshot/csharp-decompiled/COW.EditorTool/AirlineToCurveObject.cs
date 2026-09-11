using COW.GamePlay;
using UnityEngine;

namespace COW.EditorTool;

public class AirlineToCurveObject : MonoBehaviour
{
	private int Step;

	private AirtransportParams airlineParam;

	public void UpdateParam(int step, Vector2 start, Vector2 end, Vector2 center, float yPos, float centerOffset, float yOffset, float yFalling)
	{
	}

	public void OnDrawGizmos()
	{
	}
}

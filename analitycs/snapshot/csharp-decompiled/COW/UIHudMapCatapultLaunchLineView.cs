using UnityEngine;

namespace COW;

public class UIHudMapCatapultLaunchLineView : MonoBehaviour
{
	public GameObject MapCatapultEnd;

	public LineRenderer MapCatapultLine;

	private const float POINT_INTERVAL_METERS = 30f;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	public void SetActive(bool isShow)
	{
	}

	public void SetView(Vector3 playerPos, Vector3 endPos, UIMapUtil.MapOffsetContext ctx)
	{
	}

	private void SetLineWithIntervalPoints(Vector3 worldPlayerPos, Vector3 worldEndPos, Vector2 playerMapPos, Vector2 endMapPos)
	{
	}
}

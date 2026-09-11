using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UICenterTargetHelper : MonoBehaviour
{
	public UIWidget[] m_WidgetArray;

	public float[] m_GapBetweenWidgetArray;

	private List<float> m_WidgetSizeXArray;

	private float m_TotalSize;

	public bool m_IsIgnoreInactive;

	public bool IsDisable;

	private void Awake()
	{
	}

	public void InitHelper()
	{
	}

	private float GetWidgetPosOffset(UIWidget widget)
	{
		return 0f;
	}

	private void LayoutLabel()
	{
	}
}

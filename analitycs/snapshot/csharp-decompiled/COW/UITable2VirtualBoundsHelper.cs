using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UITable2VirtualBoundsHelper
{
	private const float m_Epsilon = 0.001f;

	private readonly UITable2 m_Table2;

	private readonly UIPanel m_ScrollViewPanel;

	private readonly List<Bounds> m_VirtualRelativeBounds;

	private bool m_LessContentThanView;

	private float m_Slope;

	private float m_Bias;

	private float m_ScanlineMin;

	private float m_ScanlineMax;

	private UITable2VirtualBoundsHelper(UITable2 table2, UIPanel scrollViewPanel)
	{
	}

	public static UITable2VirtualBoundsHelper CreateHelper(UITable2 table2, UIPanel scrollViewPanel)
	{
		return null;
	}

	private void CalculateVerticalMappingEquationConstants()
	{
	}

	public void CalculateVirtualRelativeBounds(List<int> indices)
	{
	}

	public int GetPreferredVisibleBoundsFromVertical()
	{
		return 0;
	}
}

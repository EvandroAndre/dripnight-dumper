using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UITableWithBorder : UITable
{
	public float MaxWidth;

	protected List<int> m_RowMemberCount;

	protected void RepositionVariableSizeWithBorder(List<Transform> children)
	{
	}

	public override void Reposition()
	{
	}

	public int GetRowCount()
	{
		return 0;
	}

	public int GetIndexOfFirstObject(int row)
	{
		return 0;
	}
}

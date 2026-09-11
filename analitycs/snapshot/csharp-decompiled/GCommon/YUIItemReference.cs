using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class YUIItemReference : MonoBehaviour
{
	public List<YUIItemVariable> itemVarList;

	public bool IsExistItem(Transform target)
	{
		return false;
	}

	public YUIItemVariable GetItem(Transform target)
	{
		return null;
	}

	public void RemoveItem(YUIItemVariable item)
	{
	}
}

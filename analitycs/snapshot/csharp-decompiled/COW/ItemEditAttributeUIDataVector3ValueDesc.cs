using UnityEngine;
using message;

namespace COW;

public class ItemEditAttributeUIDataVector3ValueDesc : ItemEditAttributeUIDataValueDesc
{
	protected Vector3 m_MinValue;

	protected Vector3 m_MaxValue;

	public Vector3 MinValue
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 MaxValue
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public ItemEditAttributeUIDataVector3ValueDesc(MHJLOKOOGNB valueType)
		: base(MHJLOKOOGNB.Object)
	{
	}
}

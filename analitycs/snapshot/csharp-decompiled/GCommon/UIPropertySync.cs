using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIPropertySync : MonoBehaviour
{
	public enum EUIProperty
	{
		None,
		SpriteColor,
		SpriteName
	}

	private UIWidget m_Target;

	private List<uint> m_RegisterPropertyList;

	public UIWidget Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<uint> RegisterPropertyList => null;

	public void SetTargetDirty()
	{
	}

	private void SyncProperty(EUIProperty property)
	{
	}
}

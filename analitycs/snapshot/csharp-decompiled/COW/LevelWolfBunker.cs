using COW.GamePlay;
using UnityEngine;

namespace COW;

public class LevelWolfBunker : BaseLevelObject
{
	public GameObject wolfHighlight;

	public GameObject highlight;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void OnRoleChange(object[] data)
	{
	}

	public void OnLocalPlayerEnter()
	{
	}

	public void OnLocalPlayerExit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}

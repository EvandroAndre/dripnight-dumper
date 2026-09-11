using COW.GamePlay;
using UnityEngine;

public class LevelWeRunRetreatPoint : BaseLevelObject
{
	private string m_Letter;

	private MeshRenderer m_AreaMeshRenderer;

	private Material m_AreaMeshMat;

	private bool isLocalPlayerEnter;

	public string Letter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public void OnLocalPlayerExit()
	{
	}

	public void OnLocalPlayerEnter()
	{
	}

	private void RefreshEnterEffect()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void SyncAction(object[] param)
	{
	}

	protected override void OnModelShowed()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void OnOnDestroy()
	{
	}
}

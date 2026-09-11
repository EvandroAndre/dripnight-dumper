using UnityEngine;

namespace COW.GamePlay;

public class LevelEmote : BaseLevelObject
{
	public MeshRenderer m_EmoteModelRender;

	public uint m_EmoteID;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void PBFDBJKCJPM(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public bool IsUsed()
	{
		return false;
	}

	public void InitLevelEmote(uint PJMMDOONDOP)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}

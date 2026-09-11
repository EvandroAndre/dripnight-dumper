using UnityEngine;

namespace COW.GamePlay;

public class LevelDetailItemGenerator : BaseLevelObject
{
	public enum PONNBKMDCJN
	{
		Add,
		Destroy
	}

	public uint m_ItemID;

	public float m_RefreshInterval;

	public uint m_ItemCount;

	public bool m_AlwaysGenerate;

	public bool m_WaitStart;

	public GameObject m_TipObject;

	public MeshRenderer m_TimeRender;

	private Material NCMKMLIBCNL;

	private uint JMKEGKLBPDI;

	private GameObject DGINKCNCIOD;

	private const float EKBIBNFFOAP = 0.45f;

	private const float MPENPBEGDLP = 1f;

	private const float JOOGCPMEACE = 0.55f;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void OnNewPropGenerated()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void DHOCFJMBMNJ()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void ShowInMap(string BBFOFADAOIG)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}

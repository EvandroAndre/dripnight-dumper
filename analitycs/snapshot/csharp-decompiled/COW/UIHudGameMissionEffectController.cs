using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGameMissionEffectController : UIBaseController
{
	private UIHudGameMissionEffectView m_View;

	private float m_HideTime;

	private int m_HideCunstomId;

	private string m_TextureRes;

	private Vector2 m_TextureUV;

	private bool m_UseMaterialEffect;

	private bool m_CacheUpBool;

	private Vector3 m_InitPos;

	private int m_InitDepth;

	private VisualInstanceHolder m_GameMissionVfxHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetViewData(ResourceID effectRes, string texRes, int customID, float duration, bool upShow = false, bool newEffect = false, float uvx = 0f, float uvy = 0f)
	{
	}

	public void SetGameMissionEffectBG(GameObject instance)
	{
	}

	public Vector3 GetGlobalMissionPos()
	{
		return default(Vector3);
	}

	private void TryReleaseVfxHolder()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetDyeColorBtnController : UIBaseController
{
	private UISparkPetDyeColorBtnView m_View;

	private uint m_ColorID;

	private Action<uint> m_ClickCallback;

	private UISprite m_ColorSprite;

	private bool m_Unlocked;

	private static Mesh s_SharedSectorMesh;

	private static float s_SharedRadius;

	private static float s_SharedInnerRadius;

	private static float s_SharedAngleDegree;

	private static float s_SharedAngleStart;

	private static float s_SharedOffsetX;

	private static float s_SharedOffsetY;

	private static uint s_SharedSegments;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(uint colorID, string colorStr, bool unlocked, Action<uint> clickCallback)
	{
	}

	public void ClearData()
	{
	}

	public void SetSelected(uint selectedColorID)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public float ApplySectorLayout(float angleDegree)
	{
		return 0f;
	}

	public void ApplyLockedCounterRotation()
	{
	}

	private static void ApplySharedSectorMesh(UICustomMeshCollider customMeshCollider)
	{
	}

	private static Mesh GetSharedSectorMesh(float radius, float innerRadius, float angleDegree, uint segments, float angleStart, float offsetX, float offsetY)
	{
		return null;
	}

	private static bool NeedRebuildSharedSectorMesh(float radius, float innerRadius, float angleDegree, uint segments, float angleStart, float offsetX, float offsetY)
	{
		return false;
	}

	private static void RebuildSharedSectorMesh(Mesh mesh, float radius, float innerRadius, float angleDegree, uint segments, float angleStart, float offsetX, float offsetY)
	{
	}

	private void SetLocked(bool locked)
	{
	}

	private void SetColor(Color color)
	{
	}

	private void OnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

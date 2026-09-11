using System.Collections.Generic;
using UnityEngine;

namespace COW;

internal class CheckBoxCrossHairTrigger : SpawnObjectCrossHairTrigger
{
	protected bool m_ExceedMaxAngle;

	public bool m_AgainstWater;

	protected int m_LayerMask;

	public bool ChangeColor;

	public Color UnavailableColor;

	private Color m_NormalColor;

	private Material[] m_Materials;

	private bool m_Active;

	private Collider[] m_Colliders;

	private float BoxY;

	protected override void OnEnable()
	{
	}

	protected virtual void SetLayerMask()
	{
	}

	public override bool HasAgainstEntities()
	{
		return false;
	}

	public override void UpdateOffYWithDeg(float deg)
	{
	}

	protected virtual void CheckUpdateOff(float deg, float checkDeg)
	{
	}

	public override bool NeedUpdateOffY()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void AddMaterials(Renderer renderer, List<Material> materialList)
	{
	}

	public override void TryChangeColor(bool valid)
	{
	}

	public override bool ActiveStateChange(bool value)
	{
		return false;
	}

	public override bool NeedChangeActive(bool value)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnEnable()
	{
	}

	public bool _003C_003EiFixBaseProxy_HasAgainstEntities()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateOffYWithDeg(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdateOffY()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_TryChangeColor(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_ActiveStateChange(bool P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedChangeActive(bool P0)
	{
		return false;
	}
}

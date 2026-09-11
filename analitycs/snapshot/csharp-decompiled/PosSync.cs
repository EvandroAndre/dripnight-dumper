using System.Collections.Generic;
using COW;
using UnityEngine;

public class PosSync : MonoBehaviour
{
	public MeshRenderer targetMatObj;

	public TechAirdropState State;

	public Vector2 VfxPosYRange;

	private List<Material> targetMats;

	private int m_Custom_PlaneNormalID;

	private int m_Custom_PlanePosID;

	private Vector3 m_PlanePos;

	private Vector3 m_PlaneNormal;

	private bool m_Finish;

	private void Start()
	{
	}

	private void Init(bool test = false)
	{
	}

	private void Refresh(bool test = false)
	{
	}

	private void Update()
	{
	}

	public void Exceute()
	{
	}

	public void InitStateCtrl(TechAirdropState mModelCtrl)
	{
	}
}

using System.Collections.Generic;
using TsiU;
using UnityEngine;

public class HangResourcesManager : TSingleton<HangResourcesManager>
{
	private Queue<GameObject> m_hangStrings;

	private Queue<GameObject> m_hangPivots;

	private Queue<GameObject> m_hangCollider_Capsules;

	private Queue<GameObject> m_hangCollider_Planes;

	private Queue<GameObject> m_hangCollider_Spheres;

	private GameObject m_Parent;

	private const int maxHangStringsCapacity = 20;

	private const int maxHangPivotsCapacity = 10;

	private const int maxHangCollider_CapsulesCapacity = 10;

	private const int maxHangCollider_PlanesCapacity = 10;

	private const int maxHangCollider_SpheresCapacity = 10;

	private void Init()
	{
	}

	public void GetHangString(out GameObject obj, out HangString hangstring)
	{
		obj = null;
		hangstring = null;
	}

	public void GetHangPivot(out GameObject obj)
	{
		obj = null;
	}

	public void GetHangColliderCapsule(out GameObject obj, out HangCollider_Capsule hangcollidercapsule)
	{
		obj = null;
		hangcollidercapsule = null;
	}

	public void GetHangColliderPlane(out GameObject obj, out HangCollider_Plane hangcolliderplane)
	{
		obj = null;
		hangcolliderplane = null;
	}

	public void GetHangColliderSphere(out GameObject obj, out HangCollider_Sphere hangcollidersphere)
	{
		obj = null;
		hangcollidersphere = null;
	}

	public void RecyleHangString(GameObject obj)
	{
	}

	public void RecyleHangPivot(GameObject obj)
	{
	}

	public void RecyleHangColliderCapsule(GameObject obj)
	{
	}

	public void RecyleHangColliderPlane(GameObject obj)
	{
	}

	public void RecyleHangColliderSphere(GameObject obj)
	{
	}
}

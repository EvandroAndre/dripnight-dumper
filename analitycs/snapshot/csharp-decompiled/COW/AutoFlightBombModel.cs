using UnityEngine;

namespace COW;

public class AutoFlightBombModel : MonoBehaviour
{
	public Animator Animator;

	public GameObject RenderRoot;

	public SkinnedMeshRenderer FlightRender;

	public GameObject FlightRenderGB;

	public GameObject YellowVfx;

	public GameObject RedVfx;

	public GameObject FlyingGB;

	public VFXCreateHelper CustomVFXHelper;

	public void EnableFlightRender(bool enable)
	{
	}
}

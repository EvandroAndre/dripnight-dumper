using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class ForceTutorialSkillCameraManager : MonoBehaviour
{
	private Animator m_Animator;

	private Transform m_ReferenceTransform;

	public float TransitionDuration;

	public BJFAEJPOLOA ForcetTutorialSkillCameraType;

	public MNCPCBOIBAG ForcetTutorialSkillCameraTransitionType;

	public float UIExistTime;

	public float TimeScale;

	private Dictionary<int, string> IJPDEHFNEID;

	public Transform ODNHJAPBINA => null;

	public void GetAnimationFirstFrame(int KHMAAFGIIMO, out Vector3 IGDHIDGLOKG, out Quaternion FOALBMBCJLF, out float FFADCBDFANJ)
	{
		IGDHIDGLOKG = default(Vector3);
		FOALBMBCJLF = default(Quaternion);
		FFADCBDFANJ = default(float);
	}

	private void ACLFIMFPKCM(string CHHBBHIFPEP, out Vector3 IGDHIDGLOKG, out Quaternion FOALBMBCJLF, out float FFADCBDFANJ)
	{
		IGDHIDGLOKG = default(Vector3);
		FOALBMBCJLF = default(Quaternion);
		FFADCBDFANJ = default(float);
	}

	public void StartAnimation()
	{
	}

	public void HomerAnimEnd()
	{
	}

	public void KodaAnimEnd()
	{
	}

	public void TasuyaAnimStart()
	{
	}

	public void TasuyaAnimPause()
	{
	}

	public void TasuyaAnimEnd()
	{
	}
}

using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class PetAnimComponentBase : MonoBehaviour, IReusableObjectOwner
{
	public const bool PlayAnimSounds = false;

	public Animation AnimationComp;

	protected List<GameObject> ANHLCOOBBGM;

	public GJCFANLGPJN m_CurrentAnimType;

	public byte m_CurrentAnimIndex;

	private bool PJCFOFIKHGL;

	public MDOIKKNBHCC m_AnimData;

	private NLOCNNCJNEO BPMBINPHNGG;

	protected bool PPNKJMNKKII;

	protected bool PIDOLPCNDCI;

	protected string ODKMPHIHCMM;

	public bool EnableAsyncLoad;

	protected ResourceID PNHFJLKLELO;

	private PetAnimResManager EHKJLEEIDDM;

	private bool LJNNMLAECDJ;

	protected NLOCNNCJNEO FNKKHHGKMMJ => null;

	protected string KMCGDDCELOP => null;

	protected AnimationState GOCCPJKBEDC => null;

	public virtual void Init(PetData JCONDDPFBKK, MDOIKKNBHCC KCIIIMAONDO, List<PetActionData> ACONAMBCBOC, bool FAHMIEKMODJ, bool CIKPGJLDNDP = false)
	{
	}

	public void OnOwnerRoleChange(bool FBMPJEMICLN)
	{
	}

	protected virtual void FCDDABEFLJG(bool FBMPJEMICLN, out bool JBMPKFAJIHB, out bool EIMJDNFDDAH)
	{
		JBMPKFAJIHB = default(bool);
		EIMJDNFDDAH = default(bool);
	}

	private void OnDestroy()
	{
	}

	public void PreloadAnimClipInNeed(ResourceID AOFCDPKJKJO)
	{
	}

	public virtual bool PlayAnim(GJCFANLGPJN MJIFGJPGLAM, byte MDJKOCLLCHC, bool MFEKPFKOMIK = false)
	{
		return false;
	}

	public void UGCPlayClipLoop(AnimationClip KGAAKHKEJLB)
	{
	}

	public void UGCPlayPetActionData(PetActionData JCONDDPFBKK)
	{
	}

	public static bool IsObjectNull(object KKDEEGJPLNG)
	{
		return false;
	}

	private void BNLDGFPFKPF(NLOCNNCJNEO CNPFPHHLCJM)
	{
	}

	private void IIPPHNKPFHG(NLOCNNCJNEO CNPFPHHLCJM)
	{
	}

	private void IMHKCLLBPPK(NLOCNNCJNEO CNPFPHHLCJM)
	{
	}

	private void JBGJFKKEJNJ(NLOCNNCJNEO CNPFPHHLCJM)
	{
	}

	protected void KDIHIOPIJAC()
	{
	}

	protected void JCEMNLIELIH(GJCFANLGPJN MJIFGJPGLAM, NLOCNNCJNEO CNPFPHHLCJM)
	{
	}

	protected void HPCFIDNPHON(AnimationClip KGAAKHKEJLB, bool MFEKPFKOMIK, float IMKNJGHAHPI = 1f)
	{
	}

	public void PlayEffect(ResourceID LIKPJDHGPFG, Transform GJDLFMIFHMG)
	{
	}

	public void PlaySound(ResourceID LIKPJDHGPFG)
	{
	}

	protected T MDPMHODJGPJ<T>(ResourceID LIKPJDHGPFG) where T : class
	{
		return null;
	}

	public static bool IsLoop(GJCFANLGPJN DBJBCFOHNLG)
	{
		return false;
	}

	private void Update()
	{
	}

	protected virtual void BDLAEMHDEFI()
	{
	}

	protected virtual void DNNCLHHJIAP(ResourceID LIKPJDHGPFG)
	{
	}

	public void OnReusableObjectRecycled(ResourceID KIOJBPDOGCH, GameObject HACIJIFIDKM)
	{
	}

	public void PlayAnimEffect(string PKKKFFILLPO)
	{
	}

	public void PlayAnimEffect(ResourceID GGMIDNEJGNO, bool DLALJDPPDPI = true)
	{
	}

	protected void EKENECDJLGD(Transform IBDNJDLJPDG, bool HCLGHJNEFIC, bool HMKCHINMDLA)
	{
	}

	private void BHGENCCCPFB(GameObject CLACOPMJHDI)
	{
	}

	private static bool FHDADJMPPCK(GameObject FJEPEDPFODO)
	{
		return false;
	}

	protected void IEBLONBIDON()
	{
	}
}

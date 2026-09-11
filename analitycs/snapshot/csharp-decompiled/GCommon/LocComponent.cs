using UnityEngine;

namespace GCommon;

public class LocComponent : MonoBehaviour
{
	public enum Alignment
	{
		Automatic,
		Left,
		Center,
		Right,
		Justified
	}

	public string StringID;

	public FontWeight FontWeight;

	public bool NoArabic;

	public bool FixArabicInOtherLang;

	public bool FixArabicNoRegion;

	public bool UseArabicAlignment;

	public Alignment ArabicAlignment;

	public bool ClearStringIDAfterDoLoc;

	private UILabel m_UILabel;

	private void Awake()
	{
	}

	private void FindTarget()
	{
	}

	private void Process()
	{
	}

	public UILabel GetTargetUILabel()
	{
		return null;
	}

	private void FindTargetUILabel()
	{
	}

	private void ProcessUILabel()
	{
	}
}

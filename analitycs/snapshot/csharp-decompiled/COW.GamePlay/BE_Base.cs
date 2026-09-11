using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using UnityEngine;

namespace COW.GamePlay;

public class BE_Base : MonoBehaviour, NCFBEOGFKCN
{
	public const uint CommentBloclColor = 1330600959u;

	public bool IsFromAI;

	public bool IsFromSearch;

	public UIWidget Widget;

	protected BlockData GFBHKKMBJLJ;

	protected bool BJKMMLAGAHE;

	protected UIPanel KGCGGKBMMGC;

	public List<BE_DragDropItemBase> DragItems;

	public BlockData KGAIBJFMLOB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool LJGHEBFJPLB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected bool LFAGLAJIKJK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIPanel HCBMHGPGOGL
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool IsCommentBlock(uint LIKPJDHGPFG)
	{
		return false;
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Init()
	{
	}

	protected virtual bool IIMDDBDFNDN()
	{
		return false;
	}

	protected virtual string BBOGCCFKHJH()
	{
		return null;
	}

	protected virtual void LJLHLABGJDO()
	{
	}

	protected virtual void ALDGFDMDJLJ()
	{
	}

	protected virtual void NPPIECILNHM(bool OGECPGHMIHA)
	{
	}

	public virtual void SetRootPanelDepth(int FPAAFMIONKB)
	{
	}

	public virtual void UpdateDepth(int HOEICAABLAP = 1)
	{
	}

	public virtual void ShowBannerErrMsg()
	{
	}

	public virtual void DisableCloneOnDrag()
	{
	}

	public virtual void SetColliderEnable(bool HCLGHJNEFIC)
	{
	}

	public virtual void SetInLibrary()
	{
	}

	public virtual void SetHighLight(bool EOGOGFLCEHL, bool JJBODLEKMBP = false)
	{
	}

	public virtual void UpdateEnabled()
	{
	}

	public virtual void UpdateSize()
	{
	}
}

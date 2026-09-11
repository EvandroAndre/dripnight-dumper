using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;
using message;

namespace COW;

public class UIModelUGCPlotEdit : UIBaseModel, IUGCModule, IUGCEditor<MPGMIACDBGN>
{
	public class PlotRuntimeData
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public UGCPlotItem res;

			internal void _003CGetPlotDataById_003Eb__0(bool success, UGCPlotItem data)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public UGCPlotActor res;

			internal void _003CGetActorDataById_003Eb__0(bool success, UGCPlotActor data)
			{
			}
		}

		public bool IsPlaying;

		public string CurPlotId;

		public int CurDialogueIndex;

		public int PlayPlotCount;

		public int PlayDialogueCount;

		public UGCPlotItem GetPlotDataById(string id)
		{
			return null;
		}

		public UGCPlotActor GetActorDataById(string id)
		{
			return null;
		}
	}

	public const uint PropID_DialoguesInPlotChanged = 1u;

	public const uint PropID_CurSelectPlotChanged = 2u;

	public const uint PropID_CurSelectDialogueChanged = 4u;

	public const uint PropID_DialogueDisplayDirty = 8u;

	public const uint PropID_OptionsInDialogueChanged = 16u;

	public const uint PropID_RuntimeDataDirty = 32u;

	public const uint PropID_CurSelectOptionChanged = 64u;

	public const uint PropID_RequestToEditOption = 128u;

	public const uint PropID_OptionDisplayDirty = 256u;

	public const uint PropID_CurSelectActorChanged = 512u;

	public const uint PropID_CustomActorsChanged = 1024u;

	public const uint PropID_PlotsChanged = 2048u;

	public const uint PropID_PlotDisplayDirty = 4096u;

	public const uint PropID_RequestToEditPlot = 8192u;

	public const uint PropID_RequestToEditDialogue = 16384u;

	public LLBBNBBFPBP PlotDatas;

	private MPGMIACDBGN m_CurSelectPlot;

	public int PlotsLimit;

	public int PlotNameLimit;

	private HMJODCEJBFF m_CurSelectDialogue;

	private HOOIPPJLMCK m_CurSelectOption;

	public int OptionsLimit;

	public static string DefaultActorIcon;

	private CHEOJCABHJJ m_CurSelectActor;

	public int ActorNameLimit;

	public PlotRuntimeData RuntimeData;

	private UGCLogicEntity m_LocalPlayerEntity;

	public MPGMIACDBGN CurSelectPlot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HMJODCEJBFF CurSelectDialogue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HOOIPPJLMCK CurSelectOption
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CHEOJCABHJJ CurSelectActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCLogicEntity LocalPlayerEntity => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public void LoadPlotDatas()
	{
	}

	public void SaveData()
	{
	}

	bool IUGCEditor<MPGMIACDBGN>.LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData = null)
	{
		return false;
	}

	bool IUGCEditor<MPGMIACDBGN>.UnloadProject()
	{
		return false;
	}

	bool IUGCEditor<MPGMIACDBGN>.Export(out byte[] projectDataBytes, out MPGMIACDBGN runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	bool IUGCEditor<MPGMIACDBGN>.CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	public MPGMIACDBGN GetPlotDataByIndex(int index)
	{
		return null;
	}

	public MPGMIACDBGN GetPlotDataById(string id)
	{
		return null;
	}

	public MPGMIACDBGN CreateNewPlot()
	{
		return null;
	}

	public MPGMIACDBGN CopyPlot(MPGMIACDBGN plot)
	{
		return null;
	}

	public void RemovePlot(MPGMIACDBGN plot)
	{
	}

	private string GetNewPlotName()
	{
		return null;
	}

	private string GetNewCopyPlotName(string originName)
	{
		return null;
	}

	public void ChangeDialogueIndex(MPGMIACDBGN plotRoot, int originIndex, int targetIndex)
	{
	}

	public HMJODCEJBFF CreateNewDialogue(MPGMIACDBGN plotBelongs)
	{
		return null;
	}

	public void RemoveDialogue(MPGMIACDBGN plotBelongs, HMJODCEJBFF dialogue)
	{
	}

	public HOOIPPJLMCK AddDialogueOption(HMJODCEJBFF dialogue, MPGMIACDBGN plotBelongs)
	{
		return null;
	}

	public void ChangeOptionIndex(HMJODCEJBFF dialogueRoot, int originIndex, int targetIndex)
	{
	}

	public void RequestToEditOption()
	{
	}

	public void RemoveOption(HMJODCEJBFF dialogueRoot, HOOIPPJLMCK option)
	{
	}

	public CHEOJCABHJJ GetActorDataByIndex(int index)
	{
		return null;
	}

	public CHEOJCABHJJ GetActorDataById(string id)
	{
		return null;
	}

	public CHEOJCABHJJ CreateNewActor()
	{
		return null;
	}

	public void RemoveActor(CHEOJCABHJJ actor)
	{
	}

	public void SetActorIcon(UISprite iconSprite, HMJODCEJBFF dialogue)
	{
	}

	public string GetActorName(HMJODCEJBFF dialogue)
	{
		return null;
	}

	private string GetNewActorName()
	{
		return null;
	}

	void IUGCModule.Init(object[] args)
	{
	}

	void IUGCModule.LoadParameters(Dictionary<object, object> parameters)
	{
	}

	void IUGCModule.Destroy()
	{
	}

	public void PlayPlotStart(string plotId)
	{
	}

	public void PlayPlotContinue()
	{
	}

	public void PlayPlotEnd()
	{
	}

	public void PlayPlotTurnToPlot(string plotId)
	{
	}

	public void PlayPlotTurnToDialogue(int dialogueIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}

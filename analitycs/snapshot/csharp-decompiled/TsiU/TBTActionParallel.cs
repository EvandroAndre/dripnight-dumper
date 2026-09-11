using System.Collections.Generic;

namespace TsiU;

public class TBTActionParallel : TBTAction
{
	public enum ECHILDREN_RELATIONSHIP
	{
		AND,
		OR
	}

	protected class TBTActionParallelContext : TBTActionContext
	{
		internal List<bool> evaluationStatus;

		internal List<int> runningStatus;
	}

	private ECHILDREN_RELATIONSHIP _evaluationRelationship;

	private ECHILDREN_RELATIONSHIP _runningStatusRelationship;

	public TBTActionParallel()
		: base(0)
	{
	}

	public TBTActionParallel SetEvaluationRelationship(ECHILDREN_RELATIONSHIP v)
	{
		return null;
	}

	public TBTActionParallel SetRunningStatusRelationship(ECHILDREN_RELATIONSHIP v)
	{
		return null;
	}

	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return false;
	}

	protected override int onUpdate(TBTWorkingData wData)
	{
		return 0;
	}

	protected override void onTransition(TBTWorkingData wData)
	{
	}

	private void initListTo<T>(List<T> list, T value)
	{
	}
}

namespace UMA;

public abstract class TextureProcessBaseCoroutine : WorkerCoroutine
{
	public abstract void Prepare(UMAData _umaData, UMAGeneratorBase _umaGenerator);
}

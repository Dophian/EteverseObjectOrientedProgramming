using System;

public class RepaginateProcess : DocumentProcess
{
    public override void Process(Document document)
    {
        DocumentProcesses.Repaginate(document);
    }
}
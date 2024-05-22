using System;

// 맞춤법 검사를 진행하는 클래스.
public class SpellcheckProcess : DocumentProcess
{
    public override void Process(Document document)
    {
        DocumentProcesses.SpellCheck(document);
    }
}
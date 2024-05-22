using System;

// 자동 번역을 처리하는 클래스.

public class TranslateIntoFrenchProcess : DocumentProcess
{
    public override void Process(Document document)
    {
        DocumentProcesses.TranslateInfoFrench(document);
    }
}
using System;

// 공통 유틸리티 클래스의 기능을 사용해 문서를 처리하는 처리자 클래스.
public class DocumentProcessor
{
    // 문서 처리 프로세스.
    private List<DocumentProcess> processes = new List<DocumentProcess>();

    // 문서 처리를 추가하는 메소드.
    public void AddDocumentProcess(DocumentProcess process)
    {
        processes.Add(process);
    }

    // 문서 처리 메소드.
    public void Process(Document document)
    {
        // 문서 처리 과정을 진행.
        foreach (DocumentProcess process in processes)
        {
            // 각 세부 처리 과정을 루프를 돌면서 처리.
            process.Process(document);
        }
    }

    // 인터페이스.
    //public static void Process(Document document)
    //{
    //    DocumentProcesses.SpellCheck(document);
    //    DocumentProcesses.Repaginate(document);
    //    DocumentProcesses.TranslateInfoFrench(document);
    //}
}
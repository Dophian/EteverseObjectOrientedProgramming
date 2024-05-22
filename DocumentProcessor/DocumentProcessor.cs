using System;

// 공통 유틸리티 클래스의 기능을 사용해 문서를 처리하는 처리자 클래스.
public class DocumentProcessor
{
    // 딜리게이트(대리자) 선언.
    // delegate 키워드 뒷 부분이 딜리게이트로 저장할 수 있는 함수의 형태.
    // delegate에서 선언한 함수의 이름이 delegate의 이름.
    public delegate void DocumentProcess(Document document);

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
            //process.Process(document);

            // 딜리게이트 호출(실행).
            // 1번.
            //process(document);

            //// 2번.
            //if (process != null)
            //{
            //    process(document);
            //}

            //// 3번.
            //process.Invoke(document);

            //// 4번.
            //if (process != null)
            //{
            //    process.Invoke(document);
            //}

            // 5번.
            process?.Invoke(document);
        }
    }

    // 인터페이스.
    //public static void Process(Document document)
    //{
    //    DocumentProcesses.SpellCheck(document);
    //    DocumentProcesses.Repaginate(document);
    //    DocumentProcesses.TranslateIntoFrench(document);
    //}
}
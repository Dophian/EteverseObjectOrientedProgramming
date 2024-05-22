using System;

// 문서 처리에 필요한 공통 기능을 제공하는 유틸리티 클래스.
// Utility(유틸리티): 공용 기능을 일컬음.
// Ex: Console.WriteLine / Debug.Log 클래스.
public class DocumentProcesses
{
    // 인터페이스.

    // 맞춤법 검사 기능.
    public static void SpellCheck(Document document)
    {
        Console.WriteLine("문서 맞춤법 처리 완료.");
    }

    // 페이지 재설정 기능.
    public static void Repaginate(Document document)
    {
        Console.WriteLine("문서 페이지 재설정 완료.");
    }

    // 자동 번역 기능.
    public static void TranslateInfoFrench(Document document)
    {
        Console.WriteLine("문서 프랑스어로 자동 번역 완료.");
    }
}
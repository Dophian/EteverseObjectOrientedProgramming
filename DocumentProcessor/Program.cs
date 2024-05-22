// Main 함수 프로그램.
class Program
{
    static void Main(string[] args)
    {
        // 문서 객체 생성.
        Document document1 = new Document
        {
            Author = "Mattew Adams",
            DocumentDate = new DateTime(2024, 04, 20),
            Text = "Programming CSharp"
        };

        Document document2 = new Document
        {
            Author = "Ian Griffiths",
            DocumentDate = new DateTime(2024, 01, 01),
            Text = "Test Text"
        };

        // 문서 처리기 설정.
        DocumentProcessor processor = new DocumentProcessor();
        processor.AddDocumentProcess(new SpellcheckProcess());
        processor.AddDocumentProcess(new RepaginateProcess());
        processor.AddDocumentProcess(new TranslateIntoFrenchProcess());

        // 문서 처리.
        Console.WriteLine("문서1 처리 중");
        processor.Process(document1);
        //DocumentProcessor.Process(document1);

        Console.WriteLine();

        Console.WriteLine("문서2 처리 중");
        processor.Process(document2);
        //DocumentProcessor.Process(document2);

        // 프로그램 바로 종료되지 말라고 추가함.
        Console.ReadKey();
    }
}
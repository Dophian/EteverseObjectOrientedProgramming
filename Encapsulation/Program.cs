class Program
{
    static void Main(string[] args)
    {
        // 계좌 객체 생성.
        BankAccount bankAccount = new BankAccount(10000);
        




        bankAccount.ShowBalance();
        //Console.WriteLine($"잔고: {bankAccount.GetBalance()}");

        // 학생 객체 생성.
        Student kim = new Student("김강훈", 27);
        kim.SetAge(29);
        kim.PrintData();

        // 의미 없음. 키 입력 대기 코드
        Console.ReadKey();
    }
}
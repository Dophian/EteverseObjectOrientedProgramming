class Program
{
    // 프로그램 진입점(Entry Point).
    static void Main(string[] args)
    {
        // 소방관 객체 생성.
        Firefighter jimmy = new Firefighter { Name = "Jimmy" };
        jimmy.ExtinguishFire();

        Console.WriteLine();

        // 수습 소방관 객체 생성.
        TraineeFirefighter bill = new TraineeFirefighter { Name = "Bill" };

        // 소방서장 객체 생성.
        FireChief fireChief = new FireChief { Name = "Harry", NumberOne = jimmy };

        // 관리자 객체 생성.
        Administrator taejun = new Administrator
        {
            Title = "Mr",
            Firstname = "Taejun",
            Lastname = "Jang"
        };

        //출근 도장.
        FireStation fireStation = new FireStation();
        fireStation.ClockIn(jimmy);
        fireStation.ClockIn(bill);
        fireStation.ClockIn(fireChief);
        fireStation.ClockIn(taejun);

        // 출근한 직원의 이름 확인.
        fireStation.RollCall();

        Console.ReadKey();
    }
}
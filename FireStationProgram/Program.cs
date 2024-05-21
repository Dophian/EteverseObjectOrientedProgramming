class Program
{
    // 프로그램 진입점(Entry Point).
    static void Main(string[] args)
    {
        // 소방관 객체.
        Firefighter johnny = new Firefighter { Name = "Johnny" };
        Firefighter james = new Firefighter { Name = "James" };

        // 소방차 객체.
        Firetruck truckOne = new Firetruck();
        truckOne.Driver = johnny;

        // 운전.
        johnny.Drive(truckOne, new Point(3, 4));

        // 불끄기.
        johnny.ExtinguishFire();
        james.ExtinguishFire();

        // ... //
        truckOne.Driver = james;

        // 운전 시도.
        johnny.Drive(truckOne, new Point(10, 2));

        // 소방서장 객체 생성.
        //FireChief fireChief = new FireChief { Name = "Harry",NumberOne = johnny };
        Firefighter fireChief = new FireChief { Name = "Harry",NumberOne = johnny };
        truckOne.Driver = fireChief;
        fireChief.Drive(truckOne, new Point(20, 30));

        // 소방서장이 다른 소방관에게 불끄라고 지시함.
        //fireChief.TellFirefighterToExtinguishFire(johnny);
        fireChief.ExtinguishFire();

        // Harry 소방서장을 참조해 사용함. Firefighter 타입으로 사용.
        // 업캐스팅(Upcasting) - 다형성 활용.
        //Firefighter stillHarry = fireChief;
        //Firefighter joe = new Firefighter { Name = "Joe" };
        // 업캐스팅을 한 후에는 부모 클래스가 가진 기능만 사용이 가능하다.
        //stillHarry.TellFirefighterToExtinguishFire(joe);

        // 수습 소방관 객체 생성.
        Firefighter bill = new TraineeFirefighter { Name = "Bill" };
        bill.ExtinguishFire();

        Console.ReadKey();
    }
}
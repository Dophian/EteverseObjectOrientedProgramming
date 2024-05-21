using System.Collections.Generic;

// 
class FireStation
{
    // 출근한 직원의 명부.
    private List<INamedPerson> clockedInStaff = new List<INamedPerson>();

    // 출근 기록 메소드 (인터페이스).
    public void ClockIn(INamedPerson staffMember)
    {
        if (!clockedInStaff.Contains(staffMember))
        {
            clockedInStaff.Add(staffMember);
            Console.WriteLine($"{staffMember.Name} 직원이 출근했습니다.");
        }
    }

    // 출근한 직원의 이름을 풀력하는 기능 (인터페이스).
    public void RollCall()
    {
        foreach (INamedPerson staffMember in clockedInStaff)
        {
            Console.WriteLine(staffMember.Name);
            // ???
            // 형변환.
            /*if (staffMember is FirefighterBase)
            {
                var fireFighter = staffMember as FirefighterBase;
                Console.WriteLine(fireFighter.Name);
            }
            else if (staffMember is Administrator)
            {
                var admin = staffMember as Administrator;
                Console.WriteLine(admin.Name);*/
        }
        
    }
}
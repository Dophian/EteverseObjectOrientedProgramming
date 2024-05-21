using System;

// 수습 소방관 클래스.
public class TraineeFirefighter : Firefighter
{
    // 필드.
    // 호스가 불에 잘 조준이 되었는 지를 나타내는 변수.
    private bool hoseTrainedOnFire = false;

    protected override void TurnOnHose()
    {
        if ( hoseTrainedOnFire)
        {
            //Console.WriteLine("불이 완전히 꺼졌습니다.");
            base.TurnOnHose();
        }
        else
        {
            Console.WriteLine("물이 엉뚱한 방향으로 발사되었습니다!!");
        }
    }

    protected override void TrainHoseOnFire()
    {
        // 호스 조준 설정.
        hoseTrainedOnFire |= true;
        //Console.WriteLine("호스를 물에 조준.");
        base.TrainHoseOnFire();
    }
}
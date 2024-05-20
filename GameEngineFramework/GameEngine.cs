using System;

// 게임 엔진 클래스.
public class GameEngine
{
    // 메인 씬.
    private Scene scene;

    // 현재 실행할 씬을 설정하는 메소드.
    public void SetScene(Scene scene)
    {
        this.scene = scene;
    }

    // 엔진 실행 함수.
    public void Run()
    {
        while (true)
        {
            // 입력 처리.
            ProcessInput();

            // 업데이트.
            Update(0f);

            // 화면 그리기.
            Draw();
        }
    }

    // 입력을 처리하는 메소드.
    private void ProcessInput()
    {

    }

    // 화면을 그리기 전에 상태(데이터)를 업데이트(갱신)하는 메소드.
    private void Update(float deltaTime)
    {
        scene.Update(deltaTime);
    }

    // 화면을 그리는 메소드.
    private void Draw()
    {
        scene.Draw();
    }
}
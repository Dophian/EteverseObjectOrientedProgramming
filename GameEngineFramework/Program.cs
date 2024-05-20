class Program
{
    static void Main(string[] args)
    {
        // 게임 엔진 객체 생성.
        GameEngine engine = new GameEngine();

        // 씬 생성.
        Scene scene = new Scene();

        // 씬 구성 - 게임 오브젝트 추가 & 배치.
        GameObject gameObject = new GameObject();
        scene.AddGameObject(gameObject);

        // 게임 오브젝트 구성 -> 컴포넌트 구성.
        PlayerControl playerControl = new PlayerControl();
        AnimationControl animationControl = new AnimationControl();
        gameObject.AddComponent(playerControl);
        gameObject.AddComponent(animationControl);

        // 엔진에 씬 설정.
        engine.SetScene(scene);

        engine.Run();

        Console.ReadKey();
    }
}
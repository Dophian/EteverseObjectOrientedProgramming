using System;

// 씬 클래스.
public class Scene
{
    // 씬에는 게임 오브젝트의 배열이 배치됨.
    private List<GameObject> gameObjects;

    public Scene()
    {
        gameObjects = new List<GameObject>();
    }

    // 게임 오브젝트를 추가하는 메소드.
    public void AddGameObject(GameObject gameObject)
    {
        gameObjects.Add(gameObject);
    }

    // 화면을 그리기 전에 상태(데이터)를 업데이트(갱신)하는 메소드.
    public void Update(float deltaTime)
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.Update(deltaTime);
        }
    }

    // 화면을 그리는 메소드.
    public void Draw()
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.Draw();
        }
    }
}
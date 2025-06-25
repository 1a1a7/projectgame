using UnityEngine;

public class TextFollow : MonoBehaviour
{
    public Transform target;  // プレイヤー（追いかける対象）
    public Vector3 offset = new Vector3(0f, 1.5f, 0f);  // プレイヤーの上に表示

    void LateUpdate()
    {
        if (target == null) return;

        // 毎フレーム、プレイヤーの位置＋オフセットに移動
        transform.position = target.position + offset;

        // カメラの方向を向くように（Y軸だけでもOK）
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);
    }
}
using UnityEngine;

public class TextFollow : MonoBehaviour
{
    public Transform target;  // �v���C���[�i�ǂ�������Ώہj
    public Vector3 offset = new Vector3(0f, 1.5f, 0f);  // �v���C���[�̏�ɕ\��

    void LateUpdate()
    {
        if (target == null) return;

        // ���t���[���A�v���C���[�̈ʒu�{�I�t�Z�b�g�Ɉړ�
        transform.position = target.position + offset;

        // �J�����̕����������悤�ɁiY�������ł�OK�j
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);
    }
}
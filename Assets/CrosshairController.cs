using UnityEngine;

/// <summary>
/// �Ə� (Crosshair) �𐧌䂷��R���|�[�l���g
/// �}�E�X�J�[�\���̈ʒu�ɏƏ����ړ�����
/// </summary>
public class CrosshairController : MonoBehaviour
{
    void Start()
    {
        // �}�E�X�J�[�\��������
        Cursor.visible = false;
    }

    void Update()
    {
        // Camera.main �Ń��C���J�����iMainCamera �^�O�̕t���� Camera�j���擾����
        // Camera.ScreenToWorldPoint �֐��ŁA�X�N���[�����W�����[���h���W�ɕϊ�����
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Z ���W���J�����Ɠ����ɂȂ��Ă���̂ŁA���Z�b�g����

        mousePosition.z = 0;
        this.transform.position = mousePosition;

        
    }

   
     


}
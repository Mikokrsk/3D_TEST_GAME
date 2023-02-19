using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Camera : MonoBehaviour
{
    //��������� ������ 
    public float SenX = 5, SensY = 10;
    //�� ������� ������������ ������ �� X � �� Y
    float moveY, moveX;
    //����� �������� �� ���� 
    public bool RootX = true, //��������� ��� ��������� ����������� �� ��� X 
    RootY = true; //��������� ��� ��������� ����������� �� ��� X
    public bool TestY = true,  //�������� ����������� �������� ������ ����� ��� Y
    TestX = false; //��������� ����������� �������� ������ ����� ��� X
    public Vector2 MinMax_Y = new Vector2(-40, 40),    //����������� �� ��� Y
    MinMax_X = new Vector2(-360, 360);  //����������� �� ��� X
    CharacterController MyPawnBody;
    // Start is called before the first frame update
    void Start()
    {
        MyPawnBody = this.GetComponent<CharacterController>();
    }
    //������� ������� ���� ��������
    static float ClampAngle(float angle, float min, float max)
    {
        //���� ���� ������ ���������� �� 0 �� -360 �� �������� ��� 
        if (angle < -360F) angle += 360F;
        //���� ���� ������ ���������� �� 0 �� 360 �� �������� ��� 
        if (angle > 360F) angle -= 360F;
        //������������ ������� �������� �������� ������������ ���� 
        return Mathf.Clamp(angle, min, max);
    }
    // Update is called once per frame
    void Update()
    {
        //�������� ���� �� ������� ���� ������� �� ������ ������ �� Y
        if (RootY) moveY -= Input.GetAxis("Mouse Y") * SensY;
        //������������ ���� �������� ������ ����� ��� �� ��������� ��� ���� 
        if (TestY) moveY = ClampAngle(moveY, MinMax_Y.x, MinMax_Y.y);
        //�������� ���� �� ������� ���� ������� �� ������ ������ �� �
        if (RootX) moveX += Input.GetAxis("Mouse X") * SenX;
        //������������ ���� �������� ������ ����� ��� �� ��������� �� ��� X
        if (TestX) moveX = ClampAngle(moveX, MinMax_X.x, MinMax_X.y);
        //������������ ���� ��������� �� ���� 
        MyPawnBody.transform.rotation = Quaternion.Euler(moveY, moveX, 0);
    }
}
